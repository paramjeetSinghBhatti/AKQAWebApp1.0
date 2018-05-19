using AKQACodingTestApp.Models;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AKQAWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            //registering the depency here.
            container.RegisterType<INumberToWord, NumberToWord>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}