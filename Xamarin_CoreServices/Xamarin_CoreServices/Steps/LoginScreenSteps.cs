using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin_CoreServices.Pages;

namespace Xamarin_CoreServices.Steps
{
    [Binding]
    public class LoginScreenSteps
    {
        readonly IApp app;
        readonly Platform platform;
        private readonly string Username = "royal.mail";
        private readonly string InvalidUsername = "r.mail";
        private readonly string Pin = "1234";

        LoginScreen login;
     
        public LoginScreenSteps()
        {
            AppManager.StartApp();
        }

        [Given(@"The User Change Settings URI")]
        public void GivenTheUserChangeSettingsURI()
        {
            login = new LoginScreen();
            login.ChangeSettingsURI();
        }


        [Given(@"The user validates loginButton is Disabled Before Login")]
        public void GivenTheUserValidatesLoginButtonIsDisabledBeforeLogin()
        {
            login.VerifyLoginButtonIsDisabled();
           
        }

        [When(@"The user Enters  valid credentials of SSO App")]
        public void WhenTheUserEntersValidCredentialsOfSSOApp()
        {
            login.EnterUserName(Username);
            login.EnterPin(Pin);
        }

        [When,Given(@"The user Tap on LoginButton")]
        public void WhenTheUserTapOnLoginButton()
        {
            login.TapOnLoginButton();
        }

        [Given(@"The user enters invalid credentials")]
        public void GivenTheUserEntersInvalidCredentials()
        {
            login = new LoginScreen();
            login.EnterUserName(InvalidUsername);
            login.EnterPin(Pin);
        }

        [Then(@"The user verify Toast Message")]
        public void ThenTheUserVerifyToastMessage()
        {
            login.VerifyToastMessage();
            Thread.Sleep(3000);
        }


    }
}