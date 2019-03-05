Feature: CoExistance
	

@mytag
Scenario: CoExistance
	Given The user enters invalid credentials
    And The user Tap on LoginButton
    Then The user verify Toast Message
	And The user switch to RON App
	Then The user switch back to Sso App
