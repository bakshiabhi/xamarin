package com.automation.pages;

import java.io.File;
import java.net.MalformedURLException;
import java.net.URL;

import org.openqa.selenium.remote.DesiredCapabilities;

import io.appium.java_client.AppiumDriver;
import io.appium.java_client.MobileElement;
import io.appium.java_client.android.AndroidDriver;

public class launchPage extends basePage {

	public launchPage(AppiumDriver<MobileElement> driver) {
		super(driver);
	}
	
	public static void launchApplication() throws MalformedURLException {
		File classpathRoot = new File(System.getProperty("user.dir"));
		File appDir = new File(classpathRoot, "/Apps/");
		File app = new File(appDir, "ParcelCR3.2_SIT_1.4Build1.apk");
		DesiredCapabilities capabilities = new DesiredCapabilities();
		capabilities.setCapability("deviceName", "15279522502126");
		capabilities.setCapability("platformVersion", "4.4.3");
		capabilities.setCapability("platformName", "Android");
		capabilities.setCapability("app", app.getAbsolutePath());
		capabilities.setCapability("appPackage", "com.royalmail.pda");
		capabilities.setCapability("appActivity", "com.royalmail.pda.activities.LogonActivity");
		driver = new AndroidDriver<MobileElement>(new URL("http://127.0.0.1:4723/wd/hub"),
				capabilities);
	}

}
