using System.Collections.Generic;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("api")]
    public class DataController : ApiController
    {
        [Route("")]
        public string Get()
        {
            return "Hello World";
        }
    }
}