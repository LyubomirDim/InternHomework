Feature: FailedLogin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@negative
Scenario: Get error message when I login with incorrect credentials
	Given I navigate to webscraper home page
	When I enter "admin" as username
	And enter "1234566" in the password field
	And I click login button
	Then I should see error message
