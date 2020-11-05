using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1
{
    [Binding]
    public class RechnerFurKreisfunktionenSteps
    {


        double num, res;
        [Given(@"the number is PI")]
        public void GivenTheNumberIsPI()
        {
            num = Math.PI;
        }

        [When(@"the number use the Sinus function")]
        public void WhenTheNumberUseTheSinusFunction()
        {
            res = Math.Sin(num);
        }

        [When(@"the number use the Cosinus function")]
        public void WhenTheNumberUseTheCosinusFunction()
        {
            res = Math.Cos(num);
        }

        [When(@"the number use the Tangenss function")]
        public void WhenTheNumberUseTheTangenssFunction()
        {
            res = Math.Tan(num);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.Equal(p0, res, 5);
        }
    }
}

