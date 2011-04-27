Feature: Create a new customer
	In order to manage customers in my system
	As a site administrator
	I want to be able to create, view and manage customer records

Scenario: Create a basic customer record
	Given I am logged into the site as an administrator
	When I click the "Create New Customer" link 
	And I enter the following information
		| Field | Value                       |
		| Name  | Hugo Reyes                  |
		| Email | hreyes@dharmainitiative.com |
		| Phone | 720-123-5477                |		 
	And I click the "Create" button
	Then I should see the following details on the screen:
		| Value                       |
		| Hugo Reyes                  |
		| hreyes@dharmainitiative.com |
		| 720-123-5477                |

