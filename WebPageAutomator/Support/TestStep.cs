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

        // Atributo estático que contabiliza o número de test steps instanciados
        private static int _count = 0;

        // Construtores
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

        // Permite reiniciar a contagem de test steps instanciados
        public static void restartCount() {

            _count = 0;

        }

    }

}
