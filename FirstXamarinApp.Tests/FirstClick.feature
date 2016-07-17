Feature: First click
	I enter the app
	I click the button 1 time

@mytag
Scenario: Click the button for the first time
	Given I see the button
	When I click the button 1 time
	Then the message shows I clicked 1 time
