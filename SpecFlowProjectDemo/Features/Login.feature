Feature: PowerOptix
	Simple calculator for adding two numbers
	
# @test
# Scenario: Testing Mobile and Browser Config
# 	Given the application is open
# 		| application |
# 		| android 	|
# 	Then user clicks on continue as guest
# 	Then user clicks on coronavirus
# 	Then user clicks on material
# 	Given the application is open
# 		| application |
# 		| browser 	|
# 	Given open browser
# 	When user enter username  and password 
# 		| Username | Password   |
# 	    | automation.kualitee@gmail.com | kualitatem |

@test
Scenario: API HIT
	Given the application is open
		| application |
		| android 	|
	Then user clicks on continue as guest
	Then user clicks on coronavirus
	Then user clicks on material
	Then the api is hit