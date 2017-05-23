using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AspNetWebApiDemo
{
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Called when the first resource (such as a page) in an ASP.NET application is requested. 
        /// The Application_Start method is called only one time during the life cycle of an application. 
        /// You can use this method to perform startup tasks such as loading data into the cache and initializing static values.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/ms178473(v=vs.100)"/>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
