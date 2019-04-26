﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace WebPageAutomator {

    class Model {

        public delegate void CallViewEventHandler(object source, ResultMessageEventArgs args);

        public event CallViewEventHandler CallView;

        protected virtual void OnCallView(Result result) {

            CallView?.Invoke(this, new ResultMessageEventArgs() { Result = result });

        }

        private IWebDriver driver = null;
        private string logger = "";
               
        public void OnCallingModel(object source, EventArgs e) {

            Console.WriteLine("Model called");

            //this.CallView += View.messageFromModel;

        }

        public void startTestCase(TestCase testCase) {

            Console.WriteLine("Model called");
            Console.WriteLine("starting test case");            

            try {

                foreach (TestStep testStep in testCase.TestSteps) {

                    string name = testStep.Name;
                    switch (name.ToUpper()) {

                        case "OPENWEBPAGE":

                            driver = openWebPage(testStep.Value);
                            break;

                        case "CLICKONELEMENTBYID":

                            clickOnElementById(testStep.Value);
                            break;

                        case "CLICKONELEMENTBYXPATH":

                            clickOnElementByXPath(testStep.Value);
                            break;

                        case "CLICKONELEMENTBYCSSSELECTOR":

                            clickOnElementByCssSelector(testStep.Value);
                            break;

                        case "SWIPETOELEMENTBYID":

                            swipeToElementById(testStep.Value);
                            break;

                        case "SWIPETOELEMENTBYXPATH":

                            swipeToElementByXPath(testStep.Value);
                            break;

                        case "SCROLLDOWN":

                            scrollDown();
                            break;

                        case "SCROLLBY":

                            scrollBy(Int32.Parse(testStep.Value));
                            break;

                        case "GETELEMENTTEXTBYID":

                            getElementTextById(testStep.Value);
                            break;

                        case "GETELEMENTTEXTBYXPATH":

                            getElementTextByXPath(testStep.Value);
                            break;



                        case "SLEEP":

                            Thread.Sleep(Int32.Parse(testStep.Value));
                            break;

                        default:

                            Console.WriteLine("Invalid test step");
                            break;

                    }

                }

                Result result = new Result(Status.Passed, "Test case concluded with success." + Environment.NewLine + 
                                            "Logger info: " + logger);

                Console.WriteLine("Returning results to view");

                // Envia resultado para a view
                OnCallView(result);

            } catch (Exception e) {

                Console.WriteLine(e.GetBaseException());
                Result result = new Result(Status.Failed, e.GetBaseException().ToString() + Environment.NewLine +
                                            "Logger info: " + logger);
                // Envia resultado para a view
                OnCallView(result);

            }

        }

        private IWebDriver openWebPage(string url) {

            String path = Environment.CurrentDirectory;

            path = path.Substring(0, path.IndexOf("bin"));

            IWebDriver driver = new ChromeDriver(Path.Combine(path, @"Sources\\"));

            driver.Manage().Window.Maximize();

            /*if(!url.StartsWith("https://")) {

                url = "https://" + url;

            } else if(!url.StartsWith("http://")) {

                url = "http://" + url;

            }*/

            

            driver.Url = url;

            return driver;

        }

        private void clickOnElementById(string id) {

            driver.FindElement(By.Id(id)).Click();

        }

        private void clickOnElementByXPath(string xpath) {

            driver.FindElement(By.XPath(xpath)).Click();

        }

        private void clickOnElementByCssSelector(string CssSelector) {

            driver.FindElement(By.CssSelector(CssSelector)).Click();

        }

        private void swipeToElementById(string id) {

            var element = driver.FindElement(By.Id(id));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

        }

        private void swipeToElementByXPath(string xpath) {

            var element = driver.FindElement(By.XPath(xpath));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

        }

        private string getElementTextById(string id) {

            Console.WriteLine("Getting element text by id: " + id);
            string text = driver.FindElement(By.Id(id)).Text;
            Console.WriteLine("Text:" + text);
            logger += "Test Step \"get element text by id\"=> text: " + text;
            return text;

        }

        private string getElementTextByXPath(string xpath) {

            Console.WriteLine("Getting element text by xpath: " + xpath);
            string text = driver.FindElement(By.XPath(xpath)).Text;
            Console.WriteLine("Text:" + text);
            logger += "Test Step \"get element text by xpath\"=> text: " + text;

            return text;

        }

        private void scrollDown() {

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

        }

        private void scrollBy(int pixels) {

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, arguments[0])", pixels);

        }

    }

}