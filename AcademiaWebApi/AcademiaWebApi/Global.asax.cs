using AcademiaWebApi.App_Start;
using AcademiaWebApi.Common.Mappers;
using AcademiaWebApi.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AcademiaWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            new AutoMapperConfigurator().Configure(
               WebContainerManager.GetAll<IAutoMapperTypeConfigurator>());
        }
    }
}
