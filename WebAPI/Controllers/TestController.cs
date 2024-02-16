using WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("badrequest")]
        public Task GetBadRequest()
        {
            throw new BadRequestException("Trying to throw a Bad Request Exception");
        }

        [HttpGet]
        [Route("authentication")]
        public Task GetAuthentication()
        {
            throw new AuthenticationException("Trying to throw a Authentication Exception");
        }

        [HttpGet]
        [Route("notfound")]
        public Task GetNotFound()
        {
            throw new NotFoundException("Trying to throw a NotFound Exception");
        }

        [HttpGet]
        [Route("internalserver")]
        public Task GetInternalServer()
        {
            throw new Exception("Trying to throw a Internal Server Exception");
        }
    }
}
