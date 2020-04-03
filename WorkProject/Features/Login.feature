Feature: Login
	As a registered user
	I want to log in successfully

@positive
Scenario: Log in Webscrapper Website
	Given I navigate to webscrapper home page
	When I enter "admin" in the username field
	And I enter "12345" in the password field
	And I click on login button
	Then I should see welcome message
