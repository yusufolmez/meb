using meb.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meb.Domain.Entities
{
    public class QuestionPack: BaseEntity // test
    {
        public string PackName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool isPublished { get; set; } = false;
    }
}
