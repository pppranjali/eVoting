using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Service;

namespace Evoting_Application.Controllers
{
    [Authorize]
    public class ResultController : Controller
    {
        // GET: Result
        ResultServiceAcces resultServiceAccess ;
        VoterDataAccess votertServiceAccess ;
        public ResultController(ResultServiceAcces resultServiceAccess,
        VoterDataAccess votertServiceAccess)
        {
         this.resultServiceAccess = resultServiceAccess;
         this.votertServiceAccess = votertServiceAccess;  
        }
        public ActionResult Vote(int id)
        {
            try
            {
                int voterId = Convert.ToInt32(Session["VoterId"]);
                bool HaveAlreadyVoted = votertServiceAccess.HasAlreadyVoted(voterId);
                if (HaveAlreadyVoted)
                {
                    return RedirectToAction("AlreadyVoted", "Voter");
                }

                bool status = resultServiceAccess.Vote(id, voterId);

                if (status)
                {
                    return View();
                }

                return RedirectToAction("InvalidVoter");
            }
            catch
            {
                return View("Error");
            }
            
        }
        public ActionResult Result(int id)
        {
            try
            {
                if (TempData["Date"] != null)
                {
                    TempData.Keep();
                    int VoteNumber = resultServiceAccess.result(id);
                    if (VoteNumber > 0)
                    {
                        var winner = resultServiceAccess.WinnerCandidateDetail(VoteNumber);
                        return View(winner);
                    }
                }
                return View();
            }
            catch
            {
                return View("Error");
            }
        }
        public ActionResult InvalidVoter()
        {
            return View();
        }

    }
}