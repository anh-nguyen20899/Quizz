using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.Api.Entities
{
    public class Answers
    {
        public int AnswerId {get; set;};
        public int QuestionId {get; set;};
        public string Content {get; set;};

    }
}