using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {
    
    public class TestCase {

        // Atributo que contém a lista de test steps
        private List<TestStep> _testSteps;
        public List<TestStep> TestSteps { get => _testSteps; set => _testSteps = value; }

        // Construtores
        public TestCase() {

            TestSteps = new List<TestStep>();

        }

        public TestCase(List<TestStep> testSteps) {

            TestSteps = testSteps;

        }

        // Método que permite adicionar um novo test step à lista que compõe o test case
        public void addTestStep(TestStep testStep) {

            TestSteps.Add(testStep);
            
        }
    }
}
