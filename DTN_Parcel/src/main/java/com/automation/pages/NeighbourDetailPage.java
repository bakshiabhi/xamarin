package com.automation.pages;

import java.util.List;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class NeighbourDetailPage extends basePage {

	@AndroidFindBy(className="android.widget.EditText")
	private List<MobileElement>customer;
	
	public NeighbourDetailPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public void EnterNeighbourName(int index){
		customer.get(0).sendKeys("Ramana");
	}
	
	/*public Boolean assert_customer(){
		Boolean iscustomer= isElementVisible(customer,driver);
		return iscustomer;
	} */
}
