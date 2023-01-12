using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateDesignPattern.UpSchool.DAL.Entities;

namespace TemplateDesignPattern.UpSchool.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8GBIAO0U\\SQLEXPRESS;Database=DbTemplate;integrated security=true");
        }
    }
}
