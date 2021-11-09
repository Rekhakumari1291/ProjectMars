Feature: Profilefeatue
	As a seller I would like to add my all details in my profile 
	So that others can my fully completed profile


@mytag
Scenario:  Login to the website
	Given I go to website Url
	And I click to SignIn Button
	When I enter my valid '<userName>' and '<password>' and click on login button
	Then Then I should be able to see my name on the page
	
	Examples: 
	| userName | password |
	| rekhakumari.1291@gmail.com | 2Rekharakesh |
