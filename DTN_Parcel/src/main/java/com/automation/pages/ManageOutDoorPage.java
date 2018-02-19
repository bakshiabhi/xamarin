package com.automation.pages;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class ManageOutDoorPage extends basePage{
	
	@AndroidFindBy(id="com.royalmail.pda:id/btn_continue")
	private MobileElement contin;
	
	@AndroidFindBy(id="com.royalmail.pda:id/deliveryRouteEditText")
	private MobileElement deliveryRoute;

	public ManageOutDoorPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public  PendingPage clickManageOutDoor(){
		contin.click();
		return new PendingPage(driver);
	}
	
	public void EnterDeliveryRoute(String Number) throws InterruptedException{
		deliveryRoute.sendKeys(Number);
		 try {
				driver.hideKeyboard();
			} catch (Exception e) {
			}
		 Thread.sleep(2000);
		}
	
	public void clickDownloadRoute(){
		contin.click();
	}
}

