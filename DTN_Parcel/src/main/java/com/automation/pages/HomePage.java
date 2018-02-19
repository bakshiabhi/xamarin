package com.automation.pages;

import java.util.List;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class HomePage extends basePage {
	
	@AndroidFindBy(className="android.widget.Button")
	private List<MobileElement> Outdoor;
	

	public HomePage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public ManageOutDoorPage clickOutdoor(int index){
		Outdoor.get(index).click();
		return new ManageOutDoorPage(driver);
	}
	
}
