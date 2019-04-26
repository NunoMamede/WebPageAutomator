using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageAutomator {
    
    public class TestCase {

       private List<TestStep> _testSteps;

        public TestCase() {

            TestSteps = new List<TestStep>();

        }

        public TestCase(List<TestStep> testSteps) {

            TestSteps = testSteps;

        }

        public List<TestStep> TestSteps { get => _testSteps; set => _testSteps = value; }

        public void addTestStep(TestStep testStep) {

            TestSteps.Add(testStep);
            
        }
    }
}
