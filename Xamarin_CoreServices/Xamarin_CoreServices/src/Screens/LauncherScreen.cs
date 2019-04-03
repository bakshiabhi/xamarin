using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin_CoreServices.Screens
{
    class LauncherScreen : BasePage
    {
        readonly Platform platform;

        
        readonly Query AppIcon;
        readonly Query MoreOptions;
        readonly Query LogOut;
        Query PdstApp(int index) => c =>c.Id("LauncherApp_Icon").Index(index);

        protected override PlatformQuery Trait => new PlatformQuery
        {

        };

        public LauncherScreen()
        {
            AppIcon=c => c.Id("LauncherApp_Icon");
            MoreOptions = c => c.Marked("More options");
            LogOut = c => c.Text("Log Out");
        }

        
        public void WaitforLauncherPage()
        {
            app.WaitForElement(AppIcon);
      //    app.WaitForElement(c => c.Id("LauncherApp_Icon"),"Did not see AppIcon", new TimeSpan(0, 0, 0, 40, 0));
        }

        public void TapOnPDAST_App(int index)
        {
         //   app.Tap(c => c.XPath("//android.support.v7.widget.RecyclerView/android.widget.LinearLayout[@index='0']"));
            app.Tap(PdstApp(index));
        }

        public void UserLogOutfromLauncher()
        {
            app.Tap(MoreOptions);
            app.Tap(LogOut);
        }
    }
}
