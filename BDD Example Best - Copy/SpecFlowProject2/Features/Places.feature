Feature: Places
	Simple calculator for adding two numbers

@mytag
Scenario: Find an interesting location in a city
	Given the city is London And the location is south
	When the users asks for interesting location
	Then the location is Greenwich

Scenario: Pass data through Specflow tables for StudentInfo object
	Given I have entered following info for Student
	| FirstName | LastName | Age | YearOfBirth |
	| test      | student  | 20  | 1995        |
	When I press the Add button
	Then the student details is displayed on the screen