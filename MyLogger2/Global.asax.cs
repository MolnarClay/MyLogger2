using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyLogger2.Models;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace MyLogger2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            LoggingUtility.LogInfoEvent("App Start");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureDependcies();
        }


        private void ConfigureDependcies()
        {
            var container = new Container();

            container.Register<ILogger,FakeLogger>(Lifestyle.Transient);
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }


    }
}
