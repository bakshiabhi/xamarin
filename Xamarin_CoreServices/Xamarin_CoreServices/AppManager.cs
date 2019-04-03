using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace Xamarin_CoreServices
{
    static class AppManager
    {
        const string ApkPath = "C:/Users/Ramana.Sadaneni/Downloads/com.royalmail.sso.apk";
        const string AppPath = "../../../Binaries/TaskyiOS.app";
        const string IpaBundleId = "com.xamarin.samples.taskytouch";

        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        public static void StartApp()
        {
 
                app = ConfigureApp
                    .Android
                    .DeviceSerial("16018522500959")
                    // Used to run a .apk file:
                    .ApkFile(ApkPath)
                    .StartApp();
            }

        }
    }
