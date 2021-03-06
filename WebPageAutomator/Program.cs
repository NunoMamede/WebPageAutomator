﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebPageAutomator.Model;

namespace WebPageAutomator
{

    // Event Args para o envio do test case entre a view e o controller
    public class TestCaseEventArgs : EventArgs {

        public TestCase TestCase { get; set; }

    }

    // Event args para o envio dos resultados entre o model e a view
    public class ResultMessageEventArgs : EventArgs {

        public Result Result { get; set; }

    }

    static class Program
    {
        /// <summary>
        /// Esta classe principal serve de ponto de partida e tem o papel de controller
        /// </summary>

        static Model.Model model = null;
        static View view = null;

        public static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            model = new Model.Model();
            view = new View();

            // Subscrições
            // view -> controller
            view.CallController += startTestCase;
            // view -> model
            view.CallModel += model.OnCallingModel;
            // model -> view
            model.CallView += view.messageFromModel;

            // Correr aplicação
            Application.Run(view);
        }

        // Método que recebe a mensagem com o test case da view e reencaminha para o model
        static void startTestCase(object sender, TestCaseEventArgs e) {

            //log.Info("Sending test case to model");
            model.startTestCase(e.TestCase);            

        }

    }
}
