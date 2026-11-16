using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private int a, b, res;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            a= number;
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
            res = calc.Add(a, b);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDived()
        {
            Calculator calc = new Calculator();
            res = calc.Div(a, b);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, res);
        }
    }
}
