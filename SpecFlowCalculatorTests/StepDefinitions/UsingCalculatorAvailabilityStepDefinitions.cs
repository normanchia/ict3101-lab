using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private Calculator _calculator;
        public UsingCalculatorAvailabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredValueAndValueIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMBTFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
