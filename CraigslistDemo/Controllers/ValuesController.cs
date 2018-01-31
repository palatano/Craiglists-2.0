using BL;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CraigslistDemo.Controllers
{
    public class ValuesController : ApiController
    {
        DALContext ctx = new DALContext();
        // GET api/values
        public IEnumerable<User> Get()
        {
            return ctx.Users.ToList();
        }

        // GET api/values/5
        public User Get(int id)
        {
            return ctx.Users.Find(id);
        }

        // POST api/values
        public void Post([FromBody]User user)
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
    }
}
