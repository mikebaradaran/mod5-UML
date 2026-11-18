Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result will be 120

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 20
	When the two numbers are multiplied
	Then the result will be 1000

Scenario: div two numbers
	Given the first number is 50
	And the second number is 2
	When the two numbers are divided
	Then the result will be 25