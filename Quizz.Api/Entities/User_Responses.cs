using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.Api.Entities
{
    public class User_Responses
    {
        public int ResponseId {get; set;};
        public int UserId {get; set;};
        public int QuestionId {get; set;};
        public int AnswerId {get; set;};
        public DateTime TimeStamp {get; set;};
    }
}