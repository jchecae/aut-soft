using System;
using TechTalk.SpecFlow;
using Xunit;

namespace bdd.workshop.calculator.tests.tdd.steps
{
    [Binding]
    public class PrimeNumberSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public PrimeNumberSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"number (.*) is checked")]
        public void WhenNumberIsChecked(int number)
        {

            _scenarioContext.Add("PrimeInfo", Operator.IsPrimeNumber(number));
        }
        
        [Then(@"the answer to know whether is prime or not is (.*)")]
        public void ThenTheAnswerToKnowWhetherIsPrimeOrNotIsUnknown(PrimeNumberInfo primeNumberInfo)
        {
            Assert.True(primeNumberInfo == _scenarioContext.Get<PrimeNumberInfo>("PrimeInfo"));
        }
    }
}
