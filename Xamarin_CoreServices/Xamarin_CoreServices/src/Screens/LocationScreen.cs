using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin_CoreServices.Screens
{
    class LocationScreen : BasePage
    {

        readonly Query LocationSelection;
        readonly Query ContinueButton;
        readonly Query LocationDrop;
        Query LocationDropDown(int index) => c => c.Id("text1").Index(index);
        readonly Query LocationIcon;

        Platform platform;

        protected override PlatformQuery Trait => new PlatformQuery
        {

        };


        
        public  LocationScreen()
        {
            LocationSelection = c => c.Id("Location_LocationsSpinner");
            ContinueButton = c => c.Id("Location_ContinueButton");
            LocationIcon = c => c.Id("Location_MarkerImage");

        }

        public void WaitForLocationIcon()
        {
            app.WaitForElement(LocationIcon);
        }

        public void SelectLocationByIndex(int index)
        {
            app.Tap(LocationSelection);
            app.Tap(LocationDropDown(index));
        }

        public void TapOnContinueButton()
        {
            app.Tap(ContinueButton);
        }

        public void VerifyContinueButtonIsDisabled()
        {
            var elementEnabled = app.Query(ContinueButton).FirstOrDefault().Enabled;
            NUnit.Framework.Assert.AreEqual(false, elementEnabled);

            if (!(app.Query(ContinueButton).First().Enabled == false))
                Assert.Pass();
            
        }

        public void SelectLocationByText(string arg)
        {
            app.Query(c => c.Id("").Text(arg));
        }
              
    }
}
