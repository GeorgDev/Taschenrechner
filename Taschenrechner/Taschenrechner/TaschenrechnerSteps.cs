using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Taschenrechner
{
    [Binding]
    public class TaschenrechnerSteps
    {
        int number;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            number = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            number = p0;
        }
        
        [When(@"the cosinus is applied on the first number")]
        public void WhenTheCosinusIsAppliedOnTheFirstNumber()
        {
            var expected = 0;
            var actual = Math.Cos(number);
            Assert.Equal(expected, actual, 5);
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
