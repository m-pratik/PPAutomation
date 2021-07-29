Feature: GoogleInput
	This is reposnisble to test if the input field is working properly

@mytag
Scenario: Giving input in Input Field
	Given I have navigated to the application
	And I see the input field
	When I give the input
	Then It should display the result