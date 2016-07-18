Feature: First click
	I enter the app
	I click the button 1 time

@mytag
Scenario: Click the button for the first time
	Given I see the "Click me" button
	When I click the "Click me" button in the "Home" screen
	Then the message in the "Click me" button shows I clicked 1 time
