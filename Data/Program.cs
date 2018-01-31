using BL;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DALContext())
            {

                ctx.Users.Add(new User()
                {
                    Name = "John",
                    Phone = "123-132-1232",
                    Email = "test@gmail.com",
                    BirthDate = DateTime.Today,
                    JoinDate = DateTime.Today,
                    Id = 1
                });
                ctx.SaveChanges();
                Console.ReadKey();
            }
        }
    }
}
