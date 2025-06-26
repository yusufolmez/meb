using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace meb.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string NameSurname { get; set; }
        public decimal balance { get; set; } = 0m;
        public string ProfilePicURL { get; set; }
        public ICollection<Subject> Subjects { get; set; }

    }
}
