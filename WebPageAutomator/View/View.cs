using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPageAutomator
{
    public partial class View : Form
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // delegado e evento (baseado no delegado) para a comunicação entre a view e o controller
        public delegate void CallControllerEventHandler(object source, TestCaseEventArgs args);
        public event CallControllerEventHandler CallController;

        // delegado e evento (baseado no delegado) para a comunicação entre a view e o model
        public delegate void CallModelEventHandler(object source, EventArgs args);
        public event CallModelEventHandler CallModel;

        // Método para lançar o evento que envia o test case para o controller
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
            loggerPanel.AutoScroll = true;
        }

        // Carregamento do formulário
        private void Form1_Load(object sender, EventArgs e)
        {

            // Preenche todos os comboBox com os nomes dos test steps
            foreach(var c in teststepsTable.Controls.OfType<ComboBox>()) {

                c.Items.Add("Click on element by ID"); // Clica num elemento identificado a partir de um id fornecido
                c.Items.Add("Click on element by XPath"); // Clica num elemento identificado a partir de um xpath fornecido
                c.Items.Add("Click on element by CSS selector"); // Clica num elemento identificado a partir de um CSS selector fornecido
                c.Items.Add("Get element text by ID"); // Obtém o texto contido num elemento com um id fornecido
                c.Items.Add("Get element text by XPath"); // Obtém o texto contido num elemento com um xpath fornecido
                c.Items.Add("Scroll to element by ID"); // Scroll até um elemento com um id fornecido
                c.Items.Add("Scroll to element by XPath"); // Scroll até um elemento com um xpath fornecido
                c.Items.Add("Scroll down"); // Scroll até à base da página
                c.Items.Add("Scroll by"); // Scroll com base em pixéis fornecidos. Se for valor negativo o scroll é no sentido ascendente
                c.Items.Add("Navigate back"); // Navega até à página anterior
                c.Items.Add("Navigate forward"); // Navega até à página seguinte

                c.Items.Add("Sleep"); // Paragem da execução em milisegundos

            }

        }

        private void start_btn_Click(object sender, EventArgs e) {

            try {

                // Desativar botão até ao final da execução ou até ser retornado algum erro
                start_btn.Enabled = false;

                // Test case a ser enviado para o controller (e depois para o model)
                TestCase testCase = new TestCase();

                // Zera a contagem de test steps, no caso de já se ter executado um test case antes
                TestStep.restartCount();

                // Primeiro test step fixo
                TestStep openWebPage = new TestStep("Open web page", this.url_txt.Text);
                testCase.addTestStep(openWebPage);

                // Test steps dinâmicos
                for (int i = 0; i < teststepsTable.RowCount; i++) {

                    ComboBox comboBox = (ComboBox) teststepsTable.GetControlFromPosition(0, i);
                    TextBox textBox = (TextBox)teststepsTable.GetControlFromPosition(1, i);

                    if (comboBox.SelectedItem != null) {

                        string name = comboBox.SelectedItem.ToString();                        

                        string value = textBox.Text;

                        TestStep testStep = new TestStep(name, value);
                        testCase.addTestStep(testStep);

                    }


                }

                // Envia test case para o controller
                OnCallController(testCase);

            } catch(Exception ex) {

                log.Error(ex.GetBaseException());
                MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Reativa botão de start
                start_btn.Enabled = true;

            }

        }

        // Recebe resultado da execução do test case do model e imprime informação no logger
        public void messageFromModel(object source, ResultMessageEventArgs e) {
            
            log.Info("Obtained results from model");

            // Imprime informação no logger
            logger_lbl.Text = "Status: " + e.Result.Status + "." + Environment.NewLine + "Message:" + e.Result.ResultMessage;

            // Carrega imagem para o respetivo painel
            if(e.Result.ImagePath.Length > 0) {

                screenshotBox.Image = Image.FromFile(e.Result.ImagePath);

            }

            // Reativa botão de start
            start_btn.Enabled = true;

        }

        // Em desenvolvimento
        private void addRow_btn_Click(object sender, EventArgs e) {

            
            /*RowStyle temp = teststepsTable.RowStyles[teststepsTable.RowCount - 1];
            
            teststepsTable.RowCount++;
            
            teststepsTable.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            
            teststepsTable.Controls.Add(new Label() { Text = "test"}, 0, teststepsTable.RowCount - 1);
            teststepsTable.Controls.Add(new Label() { Text = "test"}, 1, teststepsTable.RowCount - 1);*/
            
            
        }
    }

}
