using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.ModelBinding;
using Api.Models;

namespace Api.Controllers
{
    [RoutePrefix("api/complex")]
    public class ComplexController : ApiController
    {
        [Route("postList")]
        public IHttpActionResult PostList([FromBody] List<int> values)
        {
            if (values == null || values.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [Route("postComplex")]
        public IHttpActionResult PostComplex([FromBody] MyModel model)
        {
            if (model == null) 
            {
                return BadRequest("model missing");
            }

            if (model.values == null || model.values.Count == 0)
            {
                return BadRequest("values missing");
            }

            if (string.IsNullOrEmpty(model.name))
            {
                return BadRequest("name is missing");
            }

            return Ok();
        }

    }
}