using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysqlEFwithEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();
            //插入一行值
            var aa = context.Users.ToList();

            context.Users.Add(new aia_area()
            {
                CreatedTime = DateTime.Now,
                Id = 1233,
                Information = "test",
                Name = "name",
                UperId = Guid.NewGuid()
            });

            context.SaveChanges();
        }
    }
}
