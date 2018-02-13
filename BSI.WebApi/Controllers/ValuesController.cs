using BSI.WebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BSI.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ILoggingService loggingService;

        public ValuesController(ILoggingService loggingService)
        {
            this.loggingService = loggingService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            try
            {
                var Id = id;
            }
            catch(Exception ex)
            {
                this.loggingService.Log(ex);
            }

            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [Route("ExNull")]
        public async Task<IHttpActionResult> GetExceptionNull()
        {
            System.ArgumentNullException nullEx = new System.ArgumentNullException("testfield", "testing field gak boleh null");
            this.loggingService.Log(nullEx);

            return Ok();
        }
    }
}
