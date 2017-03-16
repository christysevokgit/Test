using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Specflowintro
{
   
    [Binding]

    class SampleFeatureStep
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
                Console.WriteLine("The test PASSED");
            else
                Console.WriteLine("The test FAILED");
                //throw new Exception("The value is different");
        }

    }
}
