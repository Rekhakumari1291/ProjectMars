﻿Feature: LoginPage
	Feature: LoginPage
	As a user want to login
	I would like to login into the Skills page
	So that I can see the home page successfully

@automate
Scenario: 1. Navigate to the Login page with valid credentials in my profile
	Given I logged into the Trade Skills portal successfully
	And I click on the sign in button
	When I enter valid '<Email>', '<Password>' records
	Then I click on the login button

	Examples: 
	| Email                      | Password |
	| rekhakumari.1291@gmail.com  |2Rekharakesh |
