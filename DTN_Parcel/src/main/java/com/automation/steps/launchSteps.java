package com.automation.steps;

import java.net.MalformedURLException;

import com.automation.pages.launchPage;

import cucumber.api.java.en.Given;

public class launchSteps {
	
	@Given("the user launches the application")
	public static void theUserLaunchesApplication() throws MalformedURLException {
		launchPage.launchApplication();
	}

}
