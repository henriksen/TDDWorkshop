Feature: Register a new site user
	In order to view customer information
	As a new site user
	I want to be able to register for a new account

Scenario: Register with valid information
	Given I am on the site home page
	When I click the "Log On" link
	And I click the "Register" link
	And I enter a random username
	And I complete the form with the following information:
		| Field           | Value             |
		| Email           | msdnuser@live.com |
		| Password        | password          | 
		| ConfirmPassword | password          |
	And I click the "Register" button
	Then I should see a link with the text "Log Off" on the page

