using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.Api.Entities
{
    public class Users
    {
        public int UserId {get; set;};
        public string Username {get; set;};
        public string Email {get; set;};
        public string PasswordHash {get; set;};
    }
}