using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Models;
using Evoting_Application.Service;
namespace Evoting_Application.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin

        CandidateDataAccess candidatedata;
        RegisterDataAccess registerdata;
        VoterDataAccess voterdata;
        AdminServiceData adminServiceData;
        public AdminController(AdminServiceData adminServiceData, CandidateDataAccess candidatedata,
        RegisterDataAccess registerdata,VoterDataAccess voterdata)
        {
            this.candidatedata = candidatedata;
            this.registerdata = registerdata;
             this.voterdata = voterdata;
            this.adminServiceData = adminServiceData;
        }
        public ActionResult AdminAccount()
        {
            return View();
        }
        public ActionResult VoterDocument()
        {
            var votersToApprove = voterdata.VoterforApproval();
            if (votersToApprove.Count() == 0)
            {
                return RedirectToAction("NopendingApproval");
            }
            return View(votersToApprove);
        }
        public ActionResult CandidateDocument()
        {
                var result = candidatedata.CandidateforApproval();
                if(result.Count()==0)
                {
                  return RedirectToAction("NopendingApproval");
                }
                return View(result);
        }
        public ActionResult ApproveCandidate(int id)
        {
            candidatedata.ApprovedCandidate(id);
            return RedirectToAction("CandidateDocument");
        }
        public ActionResult DenyCandidate(int id)
        {
            candidatedata.DenyCandidate(id);
            return RedirectToAction("CandidateDocument");

        }
        public ActionResult ApproveVoter(int id)
        {
            voterdata.ApprovedVoter(id);
            return RedirectToAction("VoterDocument");

        }
        public ActionResult DenyVoter(int id)
        {
            voterdata.DenyVoter(id);
            return RedirectToAction("VoterDocument");

        }
        public ActionResult CandidateList()
        {
            var candidatelist = adminServiceData.CandidateDetailsAdmin();
            return View(candidatelist);
        }
        public ActionResult VoterList()
        {
            var voterlist = voterdata.GetAllVoters();
            return View(voterlist);
        }
        public ActionResult SearchVoter(string VoterName)
        {
            var search_result=voterdata.SearchVoter(VoterName);
            if (search_result.Count()==0)
            {
                return RedirectToAction("NoSearch");
            }
            return View(search_result);
        }
        public ActionResult SearchCandidate(string CandidateName)
        {
            var search_result = candidatedata.SearchCandidate(CandidateName);
            if (search_result.Count() == 0)
            {
                return RedirectToAction("NoSearch");
            }
            return View(search_result);
        }
        public ActionResult ViewDocumentAdmin(Document document)
        {
            return View(document);
        }
        public ActionResult EditCandidate(int Voterid)
        {
            var specificCandidate = candidatedata.GetById(Voterid);
            return View(specificCandidate);
        }
        [HttpPost]
        public ActionResult EditCandidate(int Voterid, Candidate candidate)
        {
            try
            {
                var result =  candidatedata.UpdateCandidate(Voterid, candidate);
                return RedirectToAction("CandidateList", result);
            }
            catch 
            {
                return View("Error");
            }
        }
        public ActionResult EditVoter(int Voterid)
        {
            try
            {
                var specificVoter = registerdata.GetIdAdmin(Voterid);
                return View(specificVoter);
            }
            catch
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditVoter(int Voterid, Registration registration)
        {
            try
            {
                var result = registerdata.UpdateVoterByAdmin(Voterid, registration);
                return RedirectToAction("VoterList", result);
            }
            catch 
            {
                return View("Error");
            }
        }
        public ActionResult DeclareResult()
        {
            return View();
        }
        public ActionResult Date(DateTime date)
        {
            try
            {
                if (date == DateTime.Today)
                {
                    TempData["Date"] = "declare";
                    TempData.Keep();
                }
                return RedirectToAction("AdminAccount");
            }
            catch
            {
                return View("Error");
            }

        }
        public ActionResult NopendingApproval()
        {
            return View();
        }
        public ActionResult NoSearch()
        {
            return View();
        }
    }

}