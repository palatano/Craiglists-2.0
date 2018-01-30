using Demo.Model;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class UserManager : IUser
    {
        DALContext ctx = new DALContext();

        public void Add(User user)
        {
            ctx.Users.Add(user);
        }

        public User GetUserById(int id)
        {
            return ctx.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return ctx.Users.ToList();
        }

        public void Remove(int id)
        {
            var usr = ctx.Users.Find(id);
            ctx.Users.Remove(usr);
            ctx.SaveChanges();
        }

        public void Update(User user)
        {
            var usr = ctx.Users.Find(user.Id);
            usr.Name = user.Name;
            usr.Phone = user.Phone;
            usr.BirthDate = user.BirthDate;
            usr.Email = user.Email;
            ctx.SaveChanges();
        }
    }
}
