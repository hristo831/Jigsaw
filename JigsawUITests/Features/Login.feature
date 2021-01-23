Feature: Login
	Implement tests for Login page

Background: 
	Given Navigate to Login page

Scenario: Navigate to the Login page
	Then I am on Login page with title "Virtual Learning - Login"

Scenario: Navigate to the My Profile page
	When Click on First Time User button
		And Enter my email
		And Click Continue button
	Then I am on My Profile page with title "Virtual Learning - Register"