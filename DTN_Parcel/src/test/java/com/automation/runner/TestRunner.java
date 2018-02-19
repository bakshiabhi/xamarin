package com.automation.runner;


import org.junit.runner.RunWith;

//import com.github.mkolisnyk.cucumber.runner.ExtendedCucumber;
//import com.github.mkolisnyk.cucumber.runner.ExtendedCucumberOptions;

import cucumber.api.CucumberOptions;
import cucumber.api.junit.Cucumber;

@RunWith(Cucumber.class)
@CucumberOptions(strict = false, features = "Features", tags="@run", format = { "pretty",
  "json:target/cucumber.json" }, glue = { "com.automation.steps" })

public class TestRunner {

}
