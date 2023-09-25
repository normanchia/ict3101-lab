Feature: UsingCalculatorFactorial


@Factorial
Scenario: Factorial zero
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the factorial result should be 1

@Factorial
Scenario Outline: Factorial of a number
    Given I have a calculator
    When I have entered <value1> into the calculator and press factorial
    Then the factorial result should be <value2>
    Examples:
    |value1 |value2 |
    |5      |120     |
    |10     |3628800     |
    |11     |39916800     |  