
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        //private readonly ScenarioContext _scenarioContext;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            //_scenarioContext = scenarioContext;
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
            res = Calculator.Add(a, b);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            res = Calculator.Multiply(a, b);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            res = Calculator.divide(a, b);
        }

        [Then("the result will be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, res);
        }
    }
}
