using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {

    public class TestStep {

        string _name;
        string _value;

        public TestStep() {

            Name = "";
            Value = "";

        }

        public TestStep(string name, string value) {

            Name = name;
            Value = value;

        }

        public string Name { get => _name; set => _name = value; }
        public string Value { get => _value; set => _value = value; }

    }
}
