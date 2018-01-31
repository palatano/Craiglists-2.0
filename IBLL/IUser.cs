using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IUser
    {
        /* CRUD operations */
        void Post(User user);
        void Delete(int id);
        void Put(User user);
        List<User> Get();
        User Get(int id);
    }
}
