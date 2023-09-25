using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {
        private Calculator _calculator;
        public UsingCalculatorDivisionStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be 0.5")]
        public void ThenTheDivisionResultShouldBeEqualsPointFive()
        {
            Assert.That(_result, Is.EqualTo(0.5));
        }

        [Then(@"the division result should be 0")]
        public void ThenTheDivisionResultShouldBeEqualsZero()
        {
            Assert.That(_result, Is.EqualTo(0));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }

        [Then(@"the division result should be 1")]
        public void ThenTheDivisionResultEqualsOne()
        {
            Assert.That(_result, Is.EqualTo(1));
        }
    }
}
