Feature: UsingCalculatorAvailability
 In order to calculate MTBF and Availability
 As someone who struggles with math
 I want to be able to use my calculator to do this
@Availability
Scenario Outline: Calculating MTBF
	 Given I have a calculator
	 When I have entered <value1> and <value2> into the calculator and press MTBF
	 Then the MTBF result should be <value3>
	 Examples:
    |value1 |value2 |value3 |
    |10      |20     |30      |
    |200     |20     |220     |
    |123     |321     |444     |   

@Availability
Scenario Outline: Calculating Availability
	 Given I have a calculator
	 When I have entered <value1> and <value2> into the calculator and press Availability
	 Then the availability result should be <value3>
	 Examples:
    |value1 |value2 |value3 |
    |20      |40     |50      |
    |10     |30     |33.33     |
    |50     |50     |100     |   

@Availability
Scenario: Calculating Availability when MTTR is zero
	Given I have a calculator
	When I have entered 0 and 15 into the calculator and press Availability
	Then the availability result should be 0

@Availability
Scenario: Calculating Availability when MTTR and MTBF are zeros
	Given I have a calculator
	When I have entered 0 and 0 into the calculator and press Availability
	Then the availability result should be 100

@Availability
Scenario: Calculating Availability when MTTR and MTBF have same values
	Given I have a calculator
	When I have entered 15 and 15 into the calculator and press Availability
	Then the availability result should be 100