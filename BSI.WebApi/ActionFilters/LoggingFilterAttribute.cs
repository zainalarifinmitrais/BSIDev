using BSI.WebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Tracing;

namespace BSI.WebApi.ActionFilters
{
    // Action filter will be responsible for handling all the incoming requests to our APIs and logging them using NLogger class. 
    // We have "OnActionExecuting" method that is implicitly called if we mark our controllers or global application to use that particular filter.
    // So each time any action of any controller will be hit, our "OnActionExecuting" method will execute to log the request.
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext filterContext)
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(ITraceWriter), new NLogger());
            var trace = GlobalConfiguration.Configuration.Services.GetTraceWriter();
            trace.Info(filterContext.Request, "Controller : " + filterContext.ControllerContext.ControllerDescriptor.ControllerType.FullName + 
                Environment.NewLine + "Action : " + filterContext.ActionDescriptor.ActionName, "JSON", filterContext.ActionArguments);
        }
    }
}