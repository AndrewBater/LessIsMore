using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Less.Models
{
    public class ChallengeViewModel
    {
        public List<ChallengeModel> Challenges { get; set; }
    }

    public class ChallengeModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}