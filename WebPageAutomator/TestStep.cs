using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {

    public class TestStep {

        public string Name { get; set; }
        public string Value { get; set; }
        public int Order { get; set; }
        public int Count { get => _count; set => _count = value; }

        private static int _count = 0;

        public TestStep() {

            Name = "";
            Value = "";
            Order = Count + 1;
            Count++;

        }

        public TestStep(string name, string value) {

            Name = name;
            Value = value;
            Order = Count + 1;
            Count++;

        }

        public static void restartCount() {

            _count = 0;

        }

    }

}
