package com.automation.pages;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;

public abstract class basePage {
	
	public static  AppiumDriver<MobileElement> driver;

	public basePage(AppiumDriver<MobileElement> driver) {
		basePage.driver = driver;
	}

}
