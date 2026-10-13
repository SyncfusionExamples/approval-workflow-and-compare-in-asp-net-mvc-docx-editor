using DocumentEditorSample.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Syncfusion.Licensing;

namespace DocumentEditorSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NxYtGyMROh0gHDMgDk1jWU9FaFxFVmFJfFVrRGNEfF5gdVBMYVlbRXFUQF1hT35adUViXH5bc3dVRmBaWkdz");
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
