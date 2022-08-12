Feature: Kualitee Login
	Loggin in to Kualitee Website with Correct Credentials
	
@test
Scenario: Testing Browser Config
	Given the application is open
		| application |
		| browser 	|
	Given open browser
	When user enter username  and password 
		| Username | Password   |
	    | automation.kualitee+1@gmail.com | kualitatem |
	Then click on sign In button
	Then verify user login successfully
	
