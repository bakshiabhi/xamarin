using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin_CoreServices.Pages
{
    class LauncherScreen : BasePage
    {
        readonly Platform platform;

        
        readonly Query AppIcon;
        Query pdstApp(int index) => c =>c.Id("LauncherApp_Icon").Index(index);

        protected override PlatformQuery Trait => new PlatformQuery
        {

        };

        public LauncherScreen()
        {
            AppIcon=c => c.Id("LauncherApp_Icon");
           
        }

        
        public void WaitforLauncherPage()
        {
            app.WaitForElement(AppIcon);
        }
        public void TapOnPDAST_App(int index)
        {
         //   app.Tap(c => c.XPath("//android.support.v7.widget.RecyclerView/android.widget.LinearLayout[@index='0']"));
            app.Tap(pdstApp(index));
        }
    }
}
