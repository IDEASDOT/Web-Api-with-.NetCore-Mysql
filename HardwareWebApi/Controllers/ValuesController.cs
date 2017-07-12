using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareWebApi.Connector;
using HardwareWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HardwareWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            Conn mysqlGet = new Conn();
            return mysqlGet.UserList();
        }




        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
