Feature: Taschenrechner
	In order to avoid silly mistakes
	As a math idiot
	I want to be use trigonometric functions


Scenario: use pi
	Given the first number is 0
	And the second number is 70
	When the cosinus is applied on the first number
	Then the result should be 1

Scenario: use sin
	Given the first number is 0
	And the second number is 70
	When the cosinus is applied on the first number
	Then the result should be 0

Scenario: use cos
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: use tan
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120