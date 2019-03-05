Feature: Login
	

Scenario: Enter Credentials
	Given The User Change Settings URI
	And  The user validates loginButton is Disabled Before Login
	When The user Enters  valid credentials of SSO App
	And The user Tap on LoginButton
	And The user continue to AppLauncher Page
	Then The user Tap on PDST App Icon


Scenario: verify toast
 Given The user enters invalid credentials
 And The user Tap on LoginButton
 Then The user verify Toast Message
