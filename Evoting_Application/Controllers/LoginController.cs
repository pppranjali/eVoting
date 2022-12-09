using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Models;
using System.Web.Security;
using Evoting_Application.Service;
namespace Evoting_Application.Controllers
{
   
    public class LoginController : Controller
    {
        // GET: Login
        EvotingApplicationEntities db;
        VoterDataAccess voterDataAccess;
        public LoginController(VoterDataAccess voterDataAccess)
        {
            db = new EvotingApplicationEntities();
            this.voterDataAccess = voterDataAccess;
        }
       
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(Registration registration)
        {
            try
            {
                var Isuser = (from user in db.Registrations
                              where user.Username == registration.Username && user.Password == registration.Password
                              select user).FirstOrDefault();


                var admin = (from user in db.Registrations
                             where user.Username == registration.Username && user.Password == registration.Password
                             && user.RoleID == 3
                             select user).ToList();
                FormsAuthentication.SetAuthCookie(registration.Username, false);

                if (Isuser != null && admin.Count == 0)
                {

                    ViewBag.Name = registration.Username;
                    Session["VoterID"] = Isuser.VoterId;

                    return RedirectToAction("Account", "Voter");
                }
                else if (admin.Count > 0 && Isuser != null)
                {
                    Session["VoterID"] = Isuser.VoterId;

                    return RedirectToAction("AdminAccount", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or Password");
                    ViewBag.u = "Invalid Username or Password";
                    return View();
                }
            }
            catch
            {
                return View("Error");
            }
        }
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(Registration registration)
        {
            try
            {
                var Isuser = (from user in db.Registrations
                              where user.Username == registration.Username
                              select user).ToList();
                var today = DateTime.Today;
                if (!Request.Form["birthdate"].Any())
                {
                    ViewBag.UnderAge = "This field is required";
                    return View();
                }

                DateTime BirthDate = DateTime.Parse(Request.Form["birthdate"]);
                registration.Birthdate = BirthDate;
                var age = today.Year - BirthDate.Year;

                if (Isuser.Count > 0)
                {
                    ViewBag.Notification = "This username is not available";
                    return View();
                }
                else if (age < 18)
                {
                    ViewBag.UnderAge = "User is under age. User need to be 18 years old for applying for voting process";
                    return View();
                }

                else
                {
                    db.Registrations.Add(registration);
                    db.SaveChanges();
                    TempData["Message"] = "User Registered successfully";
                    Session["VoterID"] = registration.VoterId;
                    voterDataAccess.UpdateVoter(registration.VoterId);
                    return RedirectToAction("login");

                }
            }
            catch
            {
                return View("Error");
            }
        }
        public ActionResult logout()
        {
            try
            {
               Session.Clear();
                FormsAuthentication.SignOut();
                return RedirectToAction("login");
            }
            catch
            {
               return RedirectToAction("Error");
            }
        }
       
    }
}