using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetCOBOLChangAPI.Controllers
{
    public class BuildController : ApiController
    {
        // GET: api/Build
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Build/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Build
        public IHttpActionResult Post()
        {
            return Ok(new {username="hoge", text = "hoge" });
        }

        // PUT: api/Build/5
        public IHttpActionResult Put()
        {
            return Ok(new { username = "hoge", text = "hoge" });
        }

        // DELETE: api/Build/5
        public void Delete(int id)
        {
        }
    }
}
