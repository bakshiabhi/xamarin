package com.automation.steps;

import com.automation.pages.locationPage;
import com.automation.pages.loginPage;

import cucumber.api.PendingException;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;

public class locationStep {
	
	@Then("the user is logged in")
	public static void theUserIsLoggedIn() {
		locationPage.loggedIn();
	}

	 @Then("the user is not logged in")
	 public void the_user_is_not_logged_in() {
		 locationPage.notLoggedIn();
	 }

	@When("^the user selects the location$")
	public void theUserSelectsTheLocation()  {
        locationPage.selectLocation();
	}
}
