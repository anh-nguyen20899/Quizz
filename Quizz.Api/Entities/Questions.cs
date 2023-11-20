using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.Api.Entities
{
    public class Questions
    {
        public int QuestionId {get; set;};
        public int QuizzId {get; set;};
        public string Content {get; set;};
        public int CorrectAnswerId {get; set;};
    }
}