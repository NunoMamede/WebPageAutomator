using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {

    public class MessageRegistry {

        public string Messages { get; set; }

        public MessageRegistry() {

            Messages = "";

        }

        public MessageRegistry(string messages) {

            Messages = messages;

        }

        public void addLine(string message) {
           
            message = DateTime.Now + " " + message;

            Console.WriteLine(message);

            Messages += Environment.NewLine + message;

        }

    }
}
