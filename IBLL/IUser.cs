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
        void Add(User user);
        void Remove(int id);
        void Update(User user);
        List<User> GetUsers();
        User GetUserById(int id);
    }
}
