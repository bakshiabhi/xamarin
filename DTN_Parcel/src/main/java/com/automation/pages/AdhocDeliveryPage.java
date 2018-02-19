package com.automation.pages;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.Dimension;
import org.openqa.selenium.support.PageFactory;
import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.TouchAction;
import io.appium.java_client.android.AndroidDriver;
import io.appium.java_client.android.AndroidKeyCode;
import io.appium.java_client.pagefactory.AndroidFindBy;


public class AdhocDeliveryPage extends basePage{
	

	@AndroidFindBy(id="com.royalmail.pda:id/et_upi_manually")
	private MobileElement enternumber;
	
	@AndroidFindBy(id="com.royalmail.pda:id/centerLayout")
	private MobileElement centerlayout;
	
	@AndroidFindBy(id="com.royalmail.pda:id/disclosure")
	private MobileElement arrow;
	
	@AndroidFindBy(id="com.royalmail.pda:id/submit")
	private MobileElement submit;
	
	
	public AdhocDeliveryPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}

	public void clickNumber(){
		enternumber.click();
	}
	
	public void enterBarcode(String Number){
		enternumber.sendKeys( Number);
	}
    
	public ChangeStatus clickArrow(){
		arrow.click();
		return new ChangeStatus(driver);
	}
	public void tapEnterButtonOnKeyboard() {
        ((AndroidDriver<?>) driver).pressKeyCode(AndroidKeyCode.ENTER);
    }
	
	public NeighbourDetailPage clickSubmitadhoc(){
		submit.click();
		return new NeighbourDetailPage(driver);
	}
	
public AdhocDeliveryPage clicksearchbutton(){
				AndroidDriver<?> androidDriver = (AndroidDriver<?>)driver;
				androidDriver.pressKeyCode(84); // not working
				// Using TouchAction (not good solution but seems to be the official solution provided in appium discussion!)
				Dimension dimens = driver.manage().window().getSize();
				// try to determine position of magnifier icon as % of screen size
				int x = (int) ((dimens.getWidth()  * 1000)/1080); 
				int y = (int) ((dimens.getHeight() * 1698)/1794);
				TouchAction action = new TouchAction(driver);
				action.tap(x,y).perform();
				return new AdhocDeliveryPage(driver);
			}

}

