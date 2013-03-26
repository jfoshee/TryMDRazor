using System;
using System.Web;

namespace TryMDRazor
{
    public class Global : HttpApplication
    {
        protected void Application_Start(Object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}
