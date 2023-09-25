using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        private double _result;

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press FailureIntensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.FailureIntensity(p0, p1, p2);
        }

        [Then(@"the failure intensity result should be (.*)")]
        public void ThenTheFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press AverageFailure")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAverageFailure(int p0, int p1, int p2)
        {
            _result = _calculator.AverageFailure(p0, p1, p2);
        }

        [Then(@"the average expected failures should be (.*)")]
        public void ThenTheAverageFailureResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
