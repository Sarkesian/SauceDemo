Feature: LoginScreenTest

Tests the login screen

@tag1
Scenario: User enters website and logs in
	Given User has navigated to website
	And username is entered 
	And password is entered
	Then User is logged in
