using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPageAutomator
{
    public partial class View : Form
    {

        // delegado e evento baseado no delegado para a comunicação entre a view e o controller
        public delegate void CallControllerEventHandler(object source, TestCaseEventArgs args);
        public event CallControllerEventHandler CallController;

        // delegado e evento baseado no delegado para a comunicação entre a view e o model
        public delegate void CallModelEventHandler(object source, EventArgs args);
        public event CallModelEventHandler CallModel;

        // Método para lançar o evento que envia test case para o controller
        protected virtual void OnCallController(TestCase testCase) {

            CallController?.Invoke(this, new TestCaseEventArgs() { TestCase = testCase });

        }

        // Método para lançar o evento que contacta o model
        protected virtual void OnCallModel() {

            CallModel?.Invoke(this, EventArgs.Empty);

        }

        public View()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Preenche todos os comboBox com os nomes dos test steps
            foreach(var c in testStepsPanel.Controls.OfType<ComboBox>()) {

                c.Items.Add("Click on element by ID");
                c.Items.Add("Click on element by XPath");
                c.Items.Add("Click on element by CSS selector");
                c.Items.Add("Swipe to element by ID");
                c.Items.Add("Swipe to element by XPath");
                c.Items.Add("Get element text by ID");
                c.Items.Add("Get element text by XPath");
                c.Items.Add("Scroll down");
                c.Items.Add("Scroll by");

                c.Items.Add("Sleep");

            }            

        }

        private void start_btn_Click(object sender, EventArgs e) {

            // Test case a ser enviado para o controller (e depois para o model)
            TestCase testCase = new TestCase();

            // Primeiro test step fixo
            TestStep openWebPage = new TestStep("openWebPage", this.url_txt.Text);
            testCase.addTestStep(openWebPage);

            // Test steps dinâmicos
            IEnumerable<ComboBox> comboboxes = testStepsPanel.Controls.OfType<ComboBox>();

            int cont = comboboxes.Count();


            /*for(int i = 0; i < comboboxes.Count(); i++) {

                // Se o input não estiver vazio
                if (comboboxes.ElementAt(i).SelectedItem != null) {

                    string name = comboboxes.ElementAt(i).SelectedItem.ToString().Replace(" ", "");
                   
                    string value = this.Controls.Find("textBox" + (i + 1), true)[0].Text;

                    TestStep testStep = new TestStep(name, value);
                    testCase.addTestStep(testStep);

                }


            }*/
            foreach (var c in testStepsPanel.Controls.OfType<ComboBox>()) {

                // Se o input não estiver vazio
                if(c.SelectedItem != null) {

                    string name = c.SelectedItem.ToString().Replace(" ", "");
                    int i = c.Name[c.Name.Length - 1] - '0';
                    string value = this.Controls.Find("textBox" + i, true)[0].Text;

                    TestStep testStep = new TestStep(name, value);
                    testCase.addTestStep(testStep);

                }

            }

            // Envia test case para o controller
            OnCallController(testCase);

        }

        // Recebe resultado da execução do test case do model
        public void messageFromModel(object source, ResultMessageEventArgs e) {

            Console.WriteLine("Obtained results from model:");
            Console.WriteLine("Status: " + e.Result.status + ". Message:" + e.Result.resultMessage);
            logger_lbl.Text = "Status: " + e.Result.status + ". Message:" + e.Result.resultMessage;

        }

    }

}
