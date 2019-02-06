using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestfullApp.Dal.Model
{
    public class Context : DbContext
    {
        public DbSet<User> user { get; set; }

        public Context()
            : base("name=DefaultConnection")
        {

        }
    }
}
