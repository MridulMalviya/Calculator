using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Xamarin.UITest.Platform.Android)]
	
	public class Tests
	{
		IApp app;
        Xamarin.UITest.Platform platform;
        public static IWebDriver driver;      

		public Tests(Xamarin.UITest.Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		//[Test]
		//public void WelcomeTextIsDisplayed()
		//{
		//	AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
		//	app.Screenshot("Welcome screen.");

		//	Assert.IsTrue(results.Any());
		//}

        [Test]
        public void NewValueTest()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            string appPath = @"C:\Program Files (x86)\Android\android-sdk\build-tools\27.0.3\com.companyname.Calculator.apk";
            desiredCapabilities.SetCapability("app",appPath);
            desiredCapabilities.SetCapability("sessionOverride","true");
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("platformVersion", "8.1.0");
            desiredCapabilities.SetCapability("deviceName", "d242a680");
            desiredCapabilities.SetCapability("appPackage", "com.companyname.Calculator");
            desiredCapabilities.SetCapability("appActivity", "md509e70ab8317d8a605dce448a31aa014e.MainActivity");
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"),desiredCapabilities,TimeSpan.FromMinutes(3));
            driver.FindElement(By.Id("7")).Click();
            //driver.FindElement(By.Id("")).Click();
            //driver.FindElement(By.Id("")).Click();
            //driver.FindElement(By.Id("")).Click();
        }
	}
}
