using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private Calculator _calculator;
        public UsingCalculatorFactorialStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        private int _result;
        
        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
