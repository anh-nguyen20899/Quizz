using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.Api.Entities
{
    public class Quizzes
    {
        public int QuizzId {get; set;};
        public string Title {get; set;};
        public string Description {get; set;};
        public int CreatedBy {get; set;};
    }
}