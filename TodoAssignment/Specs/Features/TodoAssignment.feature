Feature: TodoAssignment
	In order to Manage To do Operations
	I want to Add and Edit to do

@mytag
Scenario: Add to do
	Given I have opened a Chrome Browser
	And I have opened Todo website
	When I press add
	Then Add to do should be added

	Scenario: Edit to do
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen