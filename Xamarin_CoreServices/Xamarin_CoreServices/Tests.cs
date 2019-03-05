using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin_CoreServices
{
	[TestFixture(Platform.Android)]
	public class Tests
	{
		IApp app;
		Platform platform;

        public static String URI = "http://rmg-pda-coreservices.ukwest.cloudapp.azure.com:9112";
        
        public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
          
		}
        
		[Test]
  		public void ValidLogin()
		{
           app.Repl();
            var elementEnabled = app.Query(c => c.Id("Login_LoginButton")).FirstOrDefault().Enabled;
            NUnit.Framework.Assert.AreEqual(false, elementEnabled);
            app.EnterText(c => c.Id("Login_UsernameEditText"), "Royal.mail");
            app.EnterText(c => c.Id("Login_PinEditText"), "1234");
            app.DismissKeyboard();
            Thread.Sleep(2000);
            app.Tap(c => c.Id("Login_LoginButton"));
            app.Tap(c => c.Id("LauncherApp_Icon").Index(1));
            app.Tap(c => c.Id("tvLocation"));
            app.Tap(c => c.Id("tvSpinnerSelected").Index(0));
            app.Tap(c => c.Id("btnSubmit"));    
        }

        [Test]
        public void ChangeServerURl()
        {
            app.Tap(c => c.Id("Login_SettingsButton"));
            app.ClearText(c => c.Id("Settings_ServerUri"));
            app.EnterText(c => c.Id("Settings_ServerUri"), URI);
            app.Tap(c => c.Id("button1"));
        }
	}
}
