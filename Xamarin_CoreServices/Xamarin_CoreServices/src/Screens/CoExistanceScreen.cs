using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Xamarin_CoreServices.Screens
{
    

  
    class CoExistanceScreen
    {
        static IApp app;
        private readonly string Activity = "md5f98083069ecbb5bb4b8e5195588163a4.ManifestActivity";
        public void SwitchToRonApp()
        {
            app = ConfigureApp
                .Android
                .ApkFile("C:\\Users\\Ramana.Sadaneni\\Downloads\\Projects\\com.royalmail.lat.apk")
           //     .InstalledApp("com.royalmail.lat")
                .LaunchableActivity(Activity)
                .StartApp();
            app.Back();
        }

        
        public void UserSwitchBackToSsoApp()
        {
            app = ConfigureApp
                .Android
                .InstalledApp("com.royalmail.sso")
                .LaunchableActivity("md55e31543db72af994c3d81a4d6451f4ad.MainActivity")
                .StartApp();
        }

    }
}
