using AspnetAjaxDemo.Models;
using System;
using System.Data.Entity;
using AspnetAjaxDemo.Contexts;
using System.Linq;

namespace AspnetAjaxDemo.Contexts
{
    public class SchoolDb : DbContext
    {        
        public SchoolDb()
            : base("name=SchoolDb")
        {
            Database.SetInitializer(new SchoolDbInitialiser<SchoolDb>());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
}