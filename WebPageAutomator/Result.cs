using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {

    public enum Status {

        Passed, Failed, Error, Warning,

    }

    public class Result {

        public Status status { get; set; }
        public string resultMessage { get; set; }

        public Result() {
            
            this.status = Status.Error;
            this.resultMessage = "";

        }

        public Result(Status status, string resultMessage) {

            this.status = status;
            this.resultMessage = resultMessage;

        }

    }
}
