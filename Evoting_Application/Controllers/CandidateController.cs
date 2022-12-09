using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Models;
using Evoting_Application.Service;

namespace Evoting_Application.Controllers
{
    [Authorize]  
    public class CandidateController : Controller
    {
        // GET: Candidate
        CandidateDataAccess dataAccess;
        VoterDataAccess voterDataAccess;
        RegisterDataAccess registerDataAccess;
        public CandidateController(CandidateDataAccess dataAccess,
        VoterDataAccess voterDataAccess, RegisterDataAccess registerDataAccess)
        {
           this.dataAccess = dataAccess;
           this.voterDataAccess = voterDataAccess;
           this.registerDataAccess = registerDataAccess;
        }
        public ActionResult Create(Registration register)
        {
            try
            {
                bool IsCandidateAgeValid = registerDataAccess.CandidateAgeValidate(register);
                bool IsCandidateValidVoter = voterDataAccess.IsVoterApproved(register.VoterId);
                if (IsCandidateValidVoter)
                {
                    if (IsCandidateAgeValid)
                    {
                        var candidatedetail = dataAccess.GetById(register.VoterId);
                        if (candidatedetail != null)
                        {
                            if (candidatedetail.Approval == false && candidatedetail.RequestStatus == true)
                            {
                                return RedirectToAction("UnderProcess");
                            }
                            else if (candidatedetail.Approval == true && candidatedetail.RequestStatus == false)
                            {
                                voterDataAccess.UpdateVoterRoleID(candidatedetail.VoterId);
                                return RedirectToAction("CandidateApprovedUpdate");
                            }
                        }
                        var candidate = new Candidate();
                        ViewBag.VoterId = register.VoterId;
                        return View(candidate);
                    }
                }
                else
                {
                    return RedirectToAction("NotValidateVoter");
                }
                ViewBag.VoterId = register.VoterId;
                return View();
            }
            catch
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Create(Candidate candidate)
        {
            try
            {
                ViewBag.VoterId = Convert.ToInt32(Session["VoterID"]);
                int id = Convert.ToInt32(Session["VoterID"]);
                bool HaveAlreadyapplied = dataAccess.AlreadyAppliedCandidate(id);
                if (candidate.RepresentingParty == " " || candidate.RepresentingParty == null)
                {
                    var nullcandidate = new Candidate();
                    ViewBag.Message = "Please select a representing party";
                    return View(nullcandidate);
                }
                if (!HaveAlreadyapplied)
                {
                    if (candidate.Approval == false && candidate.RequestStatus == false && candidate.RepresentingParty != null)
                    {
                        candidate.RequestStatus = true;
                        candidate.Approval = false;
                        dataAccess.Create(candidate);

                        return RedirectToAction("UnderProcess");
                    }
                }
                else
                {
                    return View("AlreadyApplied");
                }
                return RedirectToAction("Account", "Voter");
            }
            catch
            {
                return View("Error");
            }
           
        }
        public ActionResult UnderProcess()
        {
            return View();
        }
        public ActionResult CandidateApprovedUpdate()
        {
            return View();
        }
        public ActionResult NotValidateVoter()
        {
            return View();
        }
        public ActionResult AlreadyApplied()
        {
            return View();
        }

    }
}