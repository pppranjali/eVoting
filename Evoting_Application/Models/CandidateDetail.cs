using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Evoting_Application.Models
{
    public class CandidateDetail
    {
        public int VoterID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [Display(Name ="Representing Party")]
        public string RepresentingParty { get; set; }
        [Display(Name = "Vote Number")]

        public int VoteNumber { get; set; }    

    }
}