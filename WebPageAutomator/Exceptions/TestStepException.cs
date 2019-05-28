using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator.Exceptions {

    public class TestStepException : Exception {

        public TestStepException() { }

        public TestStepException(string message) : base(message) { }

        public TestStepException(string message, Exception inner) : base(message, inner) { }

    }

}
