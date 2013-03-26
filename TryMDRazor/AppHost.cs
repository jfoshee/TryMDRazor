using System.Reflection;
using ServiceStack.WebHost.Endpoints;

namespace TryMDRazor
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Web Services", Assembly.GetExecutingAssembly())
        {
        }

        public override void Configure(Funq.Container container)
        {
        }
    }
}
