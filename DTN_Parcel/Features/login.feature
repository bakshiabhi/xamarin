Feature: Login Feature
 

  @run
  Scenario Outline: As a customer enters with valid data
    Given the user launches the application
    When the user enters in with username "<user_name>"
    And the user enters in with password <password>
    And the user clicks on submit
    Then the user is logged in
    When the user selects the location

    Examples: 
      | user_name        | password |
      | Andrew.Scarlett2 |     1234 |

  Scenario Outline: As a customer enters with invalid data
    Given the user launches the application
    When the user enters in with username "<user_name>"
    And the user enters in with password <password>
    And the user clicks on submit
    Then the user is not logged in

    Examples: 
      | user_name        | password |
      | Andrew.Scarlett2 |      123 |
