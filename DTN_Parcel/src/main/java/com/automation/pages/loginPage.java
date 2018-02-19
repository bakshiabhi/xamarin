package com.automation.pages;

import org.openqa.selenium.By;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class loginPage extends basePage {

	@AndroidFindBy(id="login_edit_username")
	private MobileElement login;
	
	public loginPage(AppiumDriver<MobileElement> driver) {
		super(driver);

	}
	
	public static void theUserEntersWithFieldUserName() {
		driver.findElement(By.id("login_edit_username")).sendKeys("Rahul");
	}
	
	public static void enterUsername(String arg){
		driver.findElement(By.id("login_edit_username")).sendKeys(arg);
	}
	
	public static void enterPassword(String arg){
		driver.findElement(By.id("login_edit_password")).sendKeys(arg);
	}
	
	public static void clickSubmit() {
		driver.findElement(By.id("login_btn_login")).click();
	}
	
	public void enterUserName(String UserName){
		login.sendKeys(UserName);
	}
}
