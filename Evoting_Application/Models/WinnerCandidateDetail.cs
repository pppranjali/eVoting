using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Evoting_Application.Models
{
    public class WinnerCandidateDetail
    {
        public int VoterId { get; set; }
        [Display(Name ="Candidate Name")]
        public string CandidateName { get; set; }
        public int VoterCount { get; set; }
        public int VoteNumber { get; set; }
        public string location { get; set; }
    }
}