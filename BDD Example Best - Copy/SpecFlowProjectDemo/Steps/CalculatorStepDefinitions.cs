using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProjectDemo.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {


        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
        }

        int a, b, res;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            a = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            b = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Calculator calc = new Calculator();
            res = calc.add(a, b);
        }


        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Calculator calc = new Calculator();
            res = calc.multiply(a, b);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, res);
        }
    }
}
