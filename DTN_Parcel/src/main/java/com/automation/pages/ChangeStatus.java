package com.automation.pages;

import java.util.List;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.pagefactory.AndroidFindBy;

public class ChangeStatus extends basePage {
	
	@AndroidFindBy(className="android.widget.TextView")
	private List<MobileElement> neighbour;

	public ChangeStatus(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public AdhocDeliveryPage selectDelivertoNeighbour(int index){
		neighbour.get(index).click();
		return new AdhocDeliveryPage(driver);
	}
	
	public void doSomething(String val){
		for (MobileElement vd:neighbour){
			if(vd.getText().equals(val)){
				vd.click();
				break;
			}
		}
	}
}


