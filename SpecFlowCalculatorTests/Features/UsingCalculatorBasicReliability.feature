Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario Outline: Calculate current failure intensity
	 Given I have a calculator
	 When I have entered <value1>, <value2> and <value3> into the calculator and press FailureIntensity
	 Then the failure intensity result should be <value4>
	 Examples:
    |value1 |value2 |value3 |value4 |
    |10      |50     |100      |5      |
    |5     |10     |80     |4      |
    |15     |20     |100     |12      |   

@BasicReliability
Scenario: Calculate average number of expected failures
	 Given I have a calculator
	 When I have entered <value1>, <value2> and <value3> into the calculator and press AverageFailure
	 Then the average expected failures should be <value4>
	 Examples:
    |value1 |value2 |value3 |value4 |
    |10      |10     |100      |63      |
    |10     |100     |100     |100      |  