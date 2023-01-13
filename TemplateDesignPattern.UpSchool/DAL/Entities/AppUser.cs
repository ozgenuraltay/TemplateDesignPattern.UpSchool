using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateDesignPattern.UpSchool.DAL.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Score { get; set; }

    }
}
