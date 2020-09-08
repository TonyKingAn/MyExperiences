using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysqlEFwithEntity
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")//web.config中connectionstring的名字
        {
        }

        public DbSet<aia_area> Users { get; set; }
    }
}