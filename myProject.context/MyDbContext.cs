using Microsoft.EntityFrameworkCore;
using MyProject.Repositoties;
using MyProject.Repositoties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.context
{
    public class MyDbContext:DbContext
    {
        DbSet<Role> Role { get; set; }
        DbSet<claim> claim { get; set; }
        DbSet<Permission> Permission { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)=>  options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDBName;Trusted_Connection=True;");

       

        

    }
}
