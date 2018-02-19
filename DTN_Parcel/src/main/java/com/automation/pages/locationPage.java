package com.automation.pages;

import io.appium.java_client.android.AndroidElement;
import org.openqa.selenium.By;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import junit.framework.Assert;
import org.openqa.selenium.support.ui.Select;

public class locationPage extends basePage {

	public locationPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}
	
	public static void loggedIn() {
		try {
			Thread.sleep(10000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		org.junit.Assert.assertTrue(driver.findElement(By.id("com.royalmail.pda:id/ivLocation")).isDisplayed());
	}
	
	
	public static void notLoggedIn() {
		org.junit.Assert.assertTrue(driver.findElement(By.id("login_btn_login")).isDisplayed());
	}

	public static void selectLocation() {
        driver.findElement(By.id("com.royalmail.pda:id/tvLocation")).click();
		driver.findElement(By.id("com.royalmail.pda:id/tvSpinnerSelected")).click();
		driver.findElement(By.id("com.royalmail.pda:id/btnSubmit")).click();
	}

}
