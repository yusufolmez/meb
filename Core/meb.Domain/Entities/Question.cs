using meb.Domain.Entities.Common;
using meb.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meb.Domain.Entities
{
    public class Question : BaseEntity
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; } = null!;
        public QuestionDificultyLevel DificultyLevel { get; set; }
        public bool isPublished { get; set; } = false;
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
