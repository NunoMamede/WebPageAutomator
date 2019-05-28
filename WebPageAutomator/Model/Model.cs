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
using WebPageAutomator.Exceptions;

namespace WebPageAutomator.Model {

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

            //log.Info("Model called");

        }

        // Método principal, responsável pela execução de todos os test steps do test case
        public void startTestCase(TestCase testCase) {

            messageRegistry.addLine("Beggining test case");

            //log.Info("Beggining test case");

            string imagePath = "";

            // Instancia objeto da classe TestStepExecutor que será responsável pelas execuções dos test steps
            TestStepExecutor executor = new TestStepExecutor();
            
            try {

                // Executa todos os test steps
                foreach (TestStep testStep in testCase.TestSteps) {

                    // Executa o test step individualmente
                    executor.executeTestStep(messageRegistry, testStep);
                    
                    // se for o último test step tira screenshot
                    if(testStep.Order == testStep.Count) {

                        imagePath = executor.takeScreenshot(messageRegistry);

                    }

                }

                messageRegistry.addLine("Ending test case. Returning results to view");

                // Cria resultado de sucesso e com a informação para o logger
                Result result = new Result(Status.Passed, "Test case concluded with success." + messageRegistry.Messages, imagePath);                

                // Envia resultado para a view
                OnCallView(result);

            } catch (TestStepException e) {

                //log.Error(e.GetBaseException());

                // Cria resultado de insucesso com a informação da exceção e do logger
                Result result = new Result(Status.Failed, "Test case failed. Cause: " + e.GetBaseException().ToString() + messageRegistry.Messages, "");

                // Envia resultado para a view
                OnCallView(result);

            } catch(Exception e) {

                // Cria resultado de erro com a informação da exceção e do logger
                Result result = new Result(Status.Error, "Internal Error. Cause: " + e.GetBaseException().ToString() + messageRegistry.Messages, "");

                // Envia resultado para a view
                OnCallView(result);

            }

        } 

    }

}
