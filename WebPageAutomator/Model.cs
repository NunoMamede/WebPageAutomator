using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebPageAutomator {

    class Model {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // delegado e evento (baseado no delegado) para a comunicação entre o model e a view
        public delegate void CallViewEventHandler(object source, ResultMessageEventArgs args);
        public event CallViewEventHandler CallView;

        // Método para lançar o evento que envia o result para a view
        protected virtual void OnCallView(Result result) {

            CallView?.Invoke(this, new ResultMessageEventArgs() { Result = result });

        }

        // Driver responsável pela automaçãao web
        private IWebDriver driver = null;

        // Logger onde vai ser adicionada toda a informação individual dos test steps
        MessageRegistry messageRegistry = new MessageRegistry(Environment.NewLine + "<>---Test case message registry---<>");

        // Método que recebe comunicação da View
        public void OnCallingModel(object source, EventArgs e) {

            log.Info("Model called");

        }

        // Método principal, responsável pela execução de todos os test steps do test case
        public void startTestCase(TestCase testCase) {

            log.Info("Beggining test case");
            string imagePath = "";

            try {

                // Executa todos os test steps
                foreach (TestStep testStep in testCase.TestSteps) {

                    string name = testStep.Name;
                    messageRegistry.addLine("Executing test step #" + testStep.Order + ": " + name);
                    // Switch principal onde são selecionados os métodos de cada test step
                    switch (name.Replace(" ", "").ToUpper()) {

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

                        case "GETELEMENTTEXTBYID":

                            getElementTextById(testStep.Value);
                            break;

                        case "GETELEMENTTEXTBYXPATH":

                            getElementTextByXPath(testStep.Value);
                            break;

                        case "SCROLLDOWN":

                            scrollDown();
                            break;

                        case "SCROLLBY":

                            scrollBy(Int32.Parse(testStep.Value));
                            break;

                        case "SCROLLTOELEMENTBYID":

                            scrollToElementById(testStep.Value);
                            break;

                        case "SCROLLTOELEMENTBYXPATH":

                            scrollToElementByXPath(testStep.Value);
                            break;

                        case "NAVIGATEBACK":

                            navigateBack();
                            break;

                        case "NAVIGATEFORWARD":

                            navigateForward();
                            break;


                        case "SLEEP":

                            sleep(Int32.Parse(testStep.Value));
                            break;

                        default:

                            messageRegistry.addLine("Invalid test step");
                            break;

                    }

                    
                    // se for o último test step tira screenshot
                    if(testStep.Order == testStep.Count) {

                        imagePath = takeScreenshot(driver);


                    }

                }

                // Cria resultado de sucesso e com a informação para o logger
                Result result = new Result(Status.Passed, "Test case concluded with success." + messageRegistry.Messages, imagePath);

                messageRegistry.addLine("Ending test case. Returning results to view");

                // Envia resultado para a view
                OnCallView(result);

            } catch (Exception e) {

                log.Error(e.GetBaseException());

                // Cria resultado de insucesso com a informação da exceção e do logger
                Result result = new Result(Status.Failed, e.GetBaseException().ToString() + messageRegistry.Messages, "");

                // Envia resultado para a view
                OnCallView(result);

            }

        }

        // Métodos dos test steps

        private IWebDriver openWebPage(string url) {

            messageRegistry.addLine("Opening web page " + url);

            String path = Environment.CurrentDirectory;

            path = path.Substring(0, path.IndexOf("bin"));

            IWebDriver driver = new ChromeDriver(Path.Combine(path, @"Sources\\"));

            driver.Manage().Window.Maximize();

            if(!url.StartsWith("https://") && !url.StartsWith("http://")) {

                throw new Exception("The url must begin with http:// or https://");

            }      

            // Abre url. Se falhar lança exceção
            driver.Url = url;

            messageRegistry.addLine("Web page " + url + "successfully openned");

            return driver;

        }

        private void clickOnElementById(string id) {

            messageRegistry.addLine("Atempting to click on element with id " + id);

            //WebDriverWait wait = new WebDriverWait(driver, 1000);
           // wait.until(ExcepctedConditions.elementToBeClickable(ById("element"));
            driver.FindElement(By.Id(id)).Click();

            messageRegistry.addLine("Element with id " + id + " clicked with success");

        }

        private void clickOnElementByXPath(string xpath) {

            messageRegistry.addLine("Atempting to click on element with xpath " + xpath);

            driver.FindElement(By.XPath(xpath)).Click();

            messageRegistry.addLine("Element with xpath " + xpath + " clicked with success");

        }

        private void clickOnElementByCssSelector(string CssSelector) {

            messageRegistry.addLine("Atempting to click on element with CSS selector " + CssSelector);

            driver.FindElement(By.CssSelector(CssSelector)).Click();

            messageRegistry.addLine("Element with CSS selector " + CssSelector + " clicked with success");

        }

        private string getElementTextById(string id) {

            messageRegistry.addLine("Atempting to get element text by id: " + id);

            string text = driver.FindElement(By.Id(id)).Text;

            messageRegistry.addLine("Element text by id " + id + "successfully obtained: " + text);

            return text;

        }

        private string getElementTextByXPath(string xpath) {

            messageRegistry.addLine("Atempting to get element text by xpath: " + xpath);

            string text = driver.FindElement(By.XPath(xpath)).Text;

            messageRegistry.addLine("Element text by xpath " + xpath + "successfully obtained: " + text);

            return text;

        }

        private void scrollToElementById(string id) {

            messageRegistry.addLine("Scrolling to element with id " + id);

            var element = driver.FindElement(By.Id(id));

            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            messageRegistry.addLine("Scroll to element with id " + id + " performed with success");

        }

        private void scrollToElementByXPath(string xpath) {

            messageRegistry.addLine("Scrolling to element with xpath " + xpath);

            var element = driver.FindElement(By.XPath(xpath));

            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            messageRegistry.addLine("Scroll to element with xpath " + xpath + " performed with success");

        }

        private void scrollDown() {
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            messageRegistry.addLine("Scrolled to the bottom of the page");

        }

        private void scrollBy(int pixels) {
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, arguments[0])", pixels);
            messageRegistry.addLine("Scrolled " + pixels + " pixels in the page");

        }

        private void navigateBack() {

            messageRegistry.addLine("Navigating to previous page");
            driver.Navigate().Back();
            messageRegistry.addLine("Navigation to previous page performed with success");

        }

        private void navigateForward() {

            messageRegistry.addLine("Navigating to forward page");
            driver.Navigate().Forward();
            messageRegistry.addLine("Navigation to forward page performed with success");

        }

        private void sleep(int milliseconds) {

            messageRegistry.addLine("Sleeping for " + milliseconds);
            Thread.Sleep(milliseconds);
            messageRegistry.addLine("Sleeping concluded");

        }




        public static string takeScreenshot(IWebDriver driver) {
                  
            try {

                string folderPath = Path.Combine(Environment.CurrentDirectory, "Screenshots");

                // Cria diretório, caso não exista
                Directory.CreateDirectory(folderPath);

                // O nome único do ficheiro é baseado na hora atual
                string filePath = Path.Combine(folderPath, DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".png");

                log.Info("Taking screenshot of web page");
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);

                return filePath;

            } catch (IOException e) {

                return "";

            }
            
        }

    }

}
