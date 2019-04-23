using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UsersContext())
            {
                context.Users.Add(new User
                {
                    Login = "superadmin",
                    Password = "123456"
                });
                context.SaveChanges();
            }
        }
    }
}
