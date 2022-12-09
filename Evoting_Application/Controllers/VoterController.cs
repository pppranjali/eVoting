using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Models;
using Evoting_Application.Service;

namespace Evoting_Application.Controllers
{
    [Authorize]
    public class VoterController : Controller
    {
      
        VoterDataAccess votingdata ;
        RegisterDataAccess dataAccess;

        public VoterController(VoterDataAccess votingdata ,RegisterDataAccess dataAccess)
        {
             this.votingdata = votingdata;
             this.dataAccess = dataAccess;
        }
        // GET: Voter
        public ActionResult Document(Registration register)
        {

            return RedirectToAction("Create", "Document", register);
        }

        public ActionResult ListOfCandidates(Registration register)
        {
            bool validatedVoter = votingdata.IsVoterApproved(register.VoterId);
            bool HasAlreadyVoted = votingdata.HasAlreadyVoted(register.VoterId);
            if (validatedVoter)
            {
                if (!HasAlreadyVoted)
                {
                    var listofcandidates = votingdata.CandidateList(register.VoterId);
                    return View(listofcandidates);
                }
                else
                {
                    return RedirectToAction("AlreadyVoted");
                }
            }
            int voterid = register.VoterId;
            if (votingdata.VoterstatusDenied(voterid))
            {
                return RedirectToAction("NotApprovedVoter");
            }
            return RedirectToAction("VoterStatus");

        }

        public ActionResult VoterStatus()
        {

            return View();
        }
        public ActionResult NotApprovedVoter()
        {
            return View();
        }
        public ActionResult AlreadyVoted()
        {
            return View();
        }
        public async Task<ActionResult> AccountDetails(int id)
        {
            var result = await dataAccess.GetIdAsync(id);
            return View(result);
        }
        public async Task<ActionResult> EditAccountDetails(int id)
        {
            var record = await dataAccess.GetIdAsync(id);
            return View(record);
        }
        [HttpPost]
       
        public ActionResult EditAccountDetails(int id, Registration registration)
        {
            try
            {
                var result = dataAccess.Update(id, registration);
                return RedirectToAction("Account", result);
            }
            catch 
            {
               return View("Error");
            }
        }
        
        public async Task<ActionResult> Account(Registration registration)
        {

                if ((Session["VoterID"]) != null)
                {

                    int id = Convert.ToInt32(Session["VoterId"]);
                    var result = await dataAccess.GetIdAsync(id);
                    if (result.RoleID == 3)
                    {
                        return RedirectToAction("AdminAccount", "Admin");
                    }
                    return View(result);
                }
                else
                {
                    return RedirectToAction("login", "Login");
                }
        }   
       
    }
}