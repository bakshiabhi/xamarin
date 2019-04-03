using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin_CoreServices.Screens
{
    class LoginScreen : BasePage
    {
        readonly Query settingsBtn;
        readonly Query settingsText;
        readonly Query settingsOkBtn;
        readonly Query usernameText;
        readonly Query pinText;
        readonly Query loginBtn;
        readonly Query ToastMessage;


        Platform platform;
        // http://rmg-pda-coreservices.ukwest.cloudapp.azure.com:9112
        public static String URI = "https://rmgmsft-services-dev-apim.azure-api.net/dso/v1/connect/token";

        protected override PlatformQuery Trait => new PlatformQuery
        {
          
        };

        public LoginScreen()
        {
            settingsBtn = c => c.Id("Login_SettingsButton");
            settingsText = c => c.Id("Settings_ServerUri");
            settingsOkBtn = c => c.Id("button1");
            usernameText = c => c.Id("Login_UsernameEditText");
            pinText = c => c.Id("Login_PinEditText");
            loginBtn = c => c.Id("Login_LoginButton");
            ToastMessage = c => c.Text("invalid_username_or_password");
     
        }
       
        public void ChangeSettingsURI()
        {
         //   app.Repl();
            app.Tap(settingsBtn);
            app.ClearText(settingsText);
            app.EnterText(settingsText, URI);
            app.Tap(settingsOkBtn);
        }

        public void VerifyLoginButtonIsDisabled()
        {
            var elementEnabled = app.Query(loginBtn).FirstOrDefault().Enabled;
            NUnit.Framework.Assert.AreEqual(false, elementEnabled);

            if (!(app.Query(loginBtn).First().Enabled == false))
                Assert.Pass();
        }
        public void EnterUserName(string Username)
        {
            app.EnterText(usernameText, Username);
        }

        public void EnterPin(string Pin)
        {
            app.EnterText(pinText, Pin);
            app.DismissKeyboard();
        }

        public void TapOnLoginButton()
        {
            app.Tap(loginBtn);
            app.Screenshot("LoginButton");
        }

        public void VerifyToastMessage()
        {
            app.WaitForElement(ToastMessage);
        }

    }
}
