using System.Linq;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("api/simple")]
    public class SimpleController : ApiController
    {
        [Route("")]
        public string Get()
        {
            return "Hello World";
        }
    }
}