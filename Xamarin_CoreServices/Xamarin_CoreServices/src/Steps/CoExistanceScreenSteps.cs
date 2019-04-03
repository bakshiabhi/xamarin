using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin_CoreServices.Screens;

namespace Xamarin_CoreServices.Steps
{
    [Binding]
    class CoExistanceScreenSteps
    {
        readonly IApp app;
        readonly Platform platform;

        CoExistanceScreen co;

        public CoExistanceScreenSteps()
        {

        }

        [Then(@"The user switch to RON App")]
        public void ThenTheUserSwitchToRONApp()
        {
            co = new CoExistanceScreen();
            co.SwitchToRonApp();
        }

        [Then(@"The user switch back to Sso App")]
        public void ThenTheUserSwitchBackToSsoApp()
        {
            co.UserSwitchBackToSsoApp();
        }

    }
}
