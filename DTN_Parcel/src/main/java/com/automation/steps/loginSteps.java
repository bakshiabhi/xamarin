package com.automation.steps;

import com.automation.pages.loginPage;

import cucumber.api.java.en.And;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;

public class loginSteps {
	
	@When("the user enters username")
	public static void theUserEntersUsername() {
		loginPage.theUserEntersWithFieldUserName();
	}
	
	 @When("^the user enters in with username \"([^\"]*)\"$")
	   public void the_user_enters_in_with_username(String arg1) throws Throwable {
		   loginPage.enterUsername(arg1);    
	    }
	 
	 @And("^the user enters in with password (\\d+)$")
		public void the_user_enters_in_with_password(String arg1) throws Throwable {
			loginPage.enterPassword(arg1);
		}
	 
	 @And("the user clicks on submit")
	 public void the_user_clicks_submit() {
		 loginPage.clickSubmit();
	 }


}
