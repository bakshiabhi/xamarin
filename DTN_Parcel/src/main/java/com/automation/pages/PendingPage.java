package com.automation.pages;


import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class PendingPage extends basePage {
	
	@AndroidFindBy(id="com.royalmail.pda:id/btManageManifest")
	private MobileElement manage;

	public PendingPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}
   
	public OutDoorPage  clickManageOutDoor(){
		manage.click();
		return new OutDoorPage(driver);
	}
	
}
