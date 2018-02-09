using BussinessLogic.Interfaces;
using System.Linq;
using System.Web.Http;

namespace ResourceServer.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/accounts")]
    public class UserController : ApiController
    {
        private readonly IUserService _service;

        public UserController()
        {
        }

        public UserController(IUserService service)
        {
            this._service = service;
        }

        
        [Route("users")]
        public IHttpActionResult GetUsers()
        {            
            return Ok(_service.GetAll().ToList());
        }
    }
}
