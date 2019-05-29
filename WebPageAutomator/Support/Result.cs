using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {

    // Estado final de uma execução
    public enum Status {

        Passed, Failed, Error, Warning,

    }

    // Classe auxiliar que permite partilhar resultados das execuções entre componentes de MVC
    public class Result {

        public Status Status { get; set; }
        public string ResultMessage { get; set; }
        public string ImagePath { get; set; }

        public Result() {
            
            this.Status = Status.Error;
            this.ResultMessage = "";
            this.ImagePath = "";

        }

        public Result(Status status, string resultMessage, string imagePath) {

            this.Status = status;
            this.ResultMessage = resultMessage;
            this.ImagePath = imagePath;

        }

    }
}
