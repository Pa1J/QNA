using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QnA.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public DateTime VotedOn { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}