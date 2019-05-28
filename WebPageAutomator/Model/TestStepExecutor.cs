using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebPageAutomator.Exceptions;

namespace WebPageAutomator.Model {

    public class TestStepExecutor {

        public static IWebDriver Driver { get => _driver; set => _driver = value; }

        private static IWebDriver _driver = null;

        public TestStepExecutor() {

            Driver = null;

        }

        public void executeTestStep(MessageRegistry messageRegistry, TestStep testStep) {

            string name = testStep.Name;

            messageRegistry.addLine("Executing test step #" + testStep.Order + ": " + name);

            // Switch principal onde são selecionados os métodos de cada test step
            switch (name.Replace(" ", "").ToUpper()) {

                case "OPENWEBPAGE":

                    Driver = openWebPage(messageRegistry, testStep.Value);
                    break;

                case "CLICKONELEMENTBYID":

                    clickOnElementById(messageRegistry, testStep.Value);
                    break;

                case "CLICKONELEMENTBYXPATH":

                    clickOnElementByXPath(messageRegistry, testStep.Value);
                    break;

                case "CLICKONELEMENTBYCSSSELECTOR":

                    clickOnElementByCssSelector(messageRegistry, testStep.Value);
                    break;

                case "GETELEMENTTEXTBYID":

                    getElementTextById(messageRegistry, testStep.Value);
                    break;

                case "GETELEMENTTEXTBYXPATH":

                    getElementTextByXPath(messageRegistry, testStep.Value);
                    break;

                case "SCROLLDOWN":

                    scrollDown(messageRegistry);
                    break;

                case "SCROLLBY":

                    scrollBy(messageRegistry, Int32.Parse(testStep.Value));
                    break;

                case "SCROLLTOELEMENTBYID":

                    scrollToElementById(messageRegistry, testStep.Value);
                    break;

                case "SCROLLTOELEMENTBYXPATH":

                    scrollToElementByXPath(messageRegistry, testStep.Value);
                    break;

                case "NAVIGATEBACK":

                    navigateBack(messageRegistry);
                    break;

                case "NAVIGATEFORWARD":

                    navigateForward(messageRegistry);
                    break;


                case "SLEEP":

                    sleep(messageRegistry, Int32.Parse(testStep.Value));
                    break;

                default:

                    messageRegistry.addLine("Invalid test step");
                    break;

            }

        }

        // Métodos dos test steps

        private static IWebDriver openWebPage(MessageRegistry messageRegistry, string url) {

            try {

                messageRegistry.addLine("Opening web page " + url);

                // Caminho da driver
                String path = Environment.CurrentDirectory;

                path = path.Substring(0, path.IndexOf("bin"));

                // É instanciado o driver do chrome, sendo aberta uma nova janela do browser
                IWebDriver driver = new ChromeDriver(Path.Combine(path, @"Sources\\"));

                // Maximiza janela do browser
                driver.Manage().Window.Maximize();

                // Se o url não começar por https ou http, é lançada uma exceção pelo model
                if (!url.StartsWith("https://") && !url.StartsWith("http://")) {

                    throw new TestStepException("The url must begin with http:// or https://");

                }

                // Abre url. Se falhar lança exceção
                driver.Url = url;

                messageRegistry.addLine("Web page " + url + "successfully openned");

                return driver;

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void clickOnElementById(MessageRegistry messageRegistry, string id) {

            try {

                messageRegistry.addLine("Atempting to click on element with id " + id);

                Driver.FindElement(By.Id(id)).Click();

                messageRegistry.addLine("Element with id " + id + " clicked with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void clickOnElementByXPath(MessageRegistry messageRegistry, string xpath) {

            try {

                messageRegistry.addLine("Atempting to click on element with xpath " + xpath);

                Driver.FindElement(By.XPath(xpath)).Click();

                messageRegistry.addLine("Element with xpath " + xpath + " clicked with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void clickOnElementByCssSelector(MessageRegistry messageRegistry, string CssSelector) {

            try {

                messageRegistry.addLine("Atempting to click on element with CSS selector " + CssSelector);

                Driver.FindElement(By.CssSelector(CssSelector)).Click();

                messageRegistry.addLine("Element with CSS selector " + CssSelector + " clicked with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static string getElementTextById(MessageRegistry messageRegistry, string id) {

            try {

                messageRegistry.addLine("Atempting to get element text by id: " + id);

                string text = Driver.FindElement(By.Id(id)).Text;

                messageRegistry.addLine("Element text by id " + id + "successfully obtained: " + text);

                return text;

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static string getElementTextByXPath(MessageRegistry messageRegistry, string xpath) {

            try {

                messageRegistry.addLine("Atempting to get element text by xpath: " + xpath);

                string text = Driver.FindElement(By.XPath(xpath)).Text;

                messageRegistry.addLine("Element text by xpath " + xpath + "successfully obtained: " + text);

                return text;

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void scrollToElementById(MessageRegistry messageRegistry, string id) {

            try {

                messageRegistry.addLine("Scrolling to element with id " + id);

                var element = Driver.FindElement(By.Id(id));

                Actions actions = new Actions(Driver);
                actions.MoveToElement(element);
                actions.Perform();

                messageRegistry.addLine("Scroll to element with id " + id + " performed with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void scrollToElementByXPath(MessageRegistry messageRegistry, string xpath) {

            try {

                messageRegistry.addLine("Scrolling to element with xpath " + xpath);

                var element = Driver.FindElement(By.XPath(xpath));

                Actions actions = new Actions(Driver);
                actions.MoveToElement(element);
                actions.Perform();

                messageRegistry.addLine("Scroll to element with xpath " + xpath + " performed with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void scrollDown(MessageRegistry messageRegistry) {

            try {

                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                messageRegistry.addLine("Scrolled to the bottom of the page");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }


        }

        private static void scrollBy(MessageRegistry messageRegistry, int pixels) {

            try {

                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0, arguments[0])", pixels);
                messageRegistry.addLine("Scrolled " + pixels + " pixels in the page");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void navigateBack(MessageRegistry messageRegistry) {

            try {

                messageRegistry.addLine("Navigating to previous page");
                Driver.Navigate().Back();
                messageRegistry.addLine("Navigation to previous page performed with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void navigateForward(MessageRegistry messageRegistry) {

            try {

                messageRegistry.addLine("Navigating to forward page");
                Driver.Navigate().Forward();
                messageRegistry.addLine("Navigation to forward page performed with success");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        private static void sleep(MessageRegistry messageRegistry, int milliseconds) {

            try {

                messageRegistry.addLine("Sleeping for " + milliseconds);
                Thread.Sleep(milliseconds);
                messageRegistry.addLine("Sleeping concluded");

            } catch (Exception e) {

                throw new TestStepException("Exception at test step sleep. Cause: " + e.GetBaseException());

            }

        }

        public string takeScreenshot(MessageRegistry messageRegistry) {

            try {

                string folderPath = Path.Combine(Environment.CurrentDirectory, "Screenshots");

                // Cria diretório, caso não exista
                Directory.CreateDirectory(folderPath);

                // O nome único do ficheiro é baseado na hora atual
                string filePath = Path.Combine(folderPath, DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".png");

                messageRegistry.addLine("Taking screenshot of web page");
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);

                return filePath;

            } catch (IOException e) {

                return "";

            }

        }

    }
}
