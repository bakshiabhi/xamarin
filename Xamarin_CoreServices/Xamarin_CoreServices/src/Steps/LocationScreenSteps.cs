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
    class LocationScreenSteps
    {
        readonly IApp app;
        readonly Platform platform;

        public LocationScreenSteps()
        {

        }

        LocationScreen location;

        [When(@"The user continue to Location screen")]
        public void WhenTheUserContinueToLocationScreen()
        {
            location = new LocationScreen();
            location.WaitForLocationIcon();
        }

        [When(@"The user verify continue button is disabled")]
        public void WhenTheUserVerifyContinueButtonIsDisabled()
        {
            location = new LocationScreen();
            location.VerifyContinueButtonIsDisabled();
        }

        [When(@"The user selects the location")]
        public void WhenTheUserSelectsTheLocation()
        {
            location = new LocationScreen();
            location.SelectLocationByIndex(0);
            location.TapOnContinueButton();
        }


    }
}
