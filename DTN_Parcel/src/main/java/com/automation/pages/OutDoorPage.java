package com.automation.pages;

import java.util.List;
import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class OutDoorPage extends basePage {
	
	@AndroidFindBy(id="com.royalmail.pda:id/tvSpinnerDroped")
	private List<MobileElement> adhoc;

	public OutDoorPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public AdhocDeliveryPage clickAdhocDelivery(int index){
		adhoc.get(index).click();
		return new AdhocDeliveryPage(driver);
		
	}
}
