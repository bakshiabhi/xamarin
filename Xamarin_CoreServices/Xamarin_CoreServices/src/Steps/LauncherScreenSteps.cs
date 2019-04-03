using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin_CoreServices.Screens;

namespace Xamarin_CoreServices.Steps
{
    [Binding]
    class LauncherScreenSteps
    {
        readonly IApp app;
        readonly Platform platform;

        public LauncherScreenSteps()
        {

        }
       
        LauncherScreen launcher;
        
        [When(@"The user continue to AppLauncher Page")]
        public void WhenTheUserContinueToAppLauncherPage()
        {
            launcher = new LauncherScreen();
            launcher.WaitforLauncherPage();
            
        }
                
        [Then(@"The user Tap on PDST App Icon")]
        public void ThenTheUserTapOnPDSTAppIcon()
        {
            Thread.Sleep(3000);
            launcher.TapOnPDAST_App(1);
        }

        [Then(@"From MoreOptions user tap on logout")]
        public void ThenFromMoreOptionsUserTapOnLogout()
        {
            launcher = new LauncherScreen();
            launcher.UserLogOutfromLauncher();
        }

    }
}
