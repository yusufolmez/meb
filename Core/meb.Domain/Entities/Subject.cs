using meb.Domain.Entities.Common;
using meb.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meb.Domain.Entities
{
    public class Subject : BaseEntity // dersler
    {
        public string UserId { get; set; }
        public AppUser? User { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
