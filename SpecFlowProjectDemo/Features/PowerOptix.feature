Feature: PowerOptix
	Simple calculator for adding two numbers

@mytag
Scenario: Login test and verify UI Elements
	Given open browser
	When user enter username  and password 
		| Username | Password   |
	    | Perfecto | Password2! |
	Then click on sign In button
	Then verify user login successfully
	Then user click on XM link and AESO link
	Then click on transaction 
	Then click on operation link
	Then click on As Availability link
	Then verify Add,Delete,Save,Undo and export is displayed on screen
	Then click on Add Button
	Then click on transcation
	Then click on operation and unit contraints
	Then click on show effective button
	
@test
Scenario: Testing Mobile and Browser Config
	Given the application is open
		| application |
		| android 	|
	Then user clicks on continue as guest
	Then user clicks on coronavirus
	Then user clicks on material
	Given the application is open
		| application |
		| browser 		|
	Given open browser
	When user enter username  and password 
		| Username | Password   |
	    | Perfecto | Password2! |
	Then click on sign In button
	Then verify user login successfully
	# Then user click on XM link and AESO link
	# Then click on transaction 
	# Then click on operation link
	# Then click on As Availability link
	# Then verify Add,Delete,Save,Undo and export is displayed on screen
	# Then click on Add Button
	# Then click on transcation
	# Then click on operation and unit contraints
	# Then click on show effective button