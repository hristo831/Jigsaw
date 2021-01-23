Feature: My Profile
	Implement tests for My Profile page

Background: 
	Given Navigate to Login page
	When Click on First Time User button
		And Enter my email
		And Click Continue button	


Scenario: Pre-populated email on My Profile page
	Then Email is pre-populated from Login page

Scenario: Session list is empty after fill my profile 
	When Fill my profile form
	|                              |              |
	| Password                     | 123456aS     |
	| ConfirmPassword              | 123456aS     |
	| FirstName                    | Hristo       |
	| LastName                     | Georgiev     |
	| Country                      | Bulgaria     |
	| StateRegion                  | Plovdiv      |
	| City                         | Plovdiv      |
	| TimeZone                     | UTC + 2      |
	| FirstSecurityQuestionAnswer  | Answer one   |
	| SecondSecurityQuestionAnswer | Answer two   |
	| ThirdSecurityQuestionAnswer  | Answer three |
		And Click Save button
	Then I am on My Sessions page with title "My Sessions" 
		And Session list is empty