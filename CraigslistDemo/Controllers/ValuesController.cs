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
    public class UsersController : ApiController
    {
        static DALContext ctx = new DALContext();
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
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]User user)
        {
            var usr = ctx.Users.Find(id);
            usr.Name = user.Name;
            usr.Phone = user.Phone;
            usr.Email = user.Email;
            usr.BirthDate = user.BirthDate;
            ctx.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var usr = ctx.Users.Find(id);
            ctx.Users.Remove(usr);
            ctx.SaveChanges();
        }
    }
}
