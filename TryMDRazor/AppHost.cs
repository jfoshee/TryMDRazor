using System.Reflection;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.Logging;
using ServiceStack.Logging.Support.Logging;
using ServiceStack.Razor;

namespace TryMDRazor
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Web Services", Assembly.GetExecutingAssembly())
        {
        }

        public override void Configure(Funq.Container container)
        {
            LogManager.LogFactory = new ConsoleLogFactory();
            Plugins.Add(new RazorFormat());
        }
    }
}
