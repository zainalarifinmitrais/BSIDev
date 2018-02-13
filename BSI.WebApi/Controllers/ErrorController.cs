using BSI.WebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BSI.WebApi.Controllers
{
    public class ErrorController : ApiController
    {
        private readonly ILoggingService loggingService;

        public ErrorController(ILoggingService loggingService)
        {
            this.loggingService = loggingService;
        }

        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions]
        public IHttpActionResult NotFound(string path)
        {
            // log error to Elmah
            this.loggingService.Log(new HttpException(404, "404 Not Found: /" + path));
            // return 404
            return NotFound();
        }
    }
}
