using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evoting_Application.Models;
namespace Evoting_Application.Service
{
    public class AdminServiceData
    {
        EvotingApplicationEntities context = new EvotingApplicationEntities();
        public IEnumerable<CandidateDetailsListForAdmin_Result> CandidateDetailsAdmin()
        {
            var candidatedetail=context.CandidateDetailsListForAdmin();
            return candidatedetail;
        }
    }
}