using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Evoting_Application.Models;
using Evoting_Application.Service;
using System.Threading.Tasks;

namespace Evoting_Application.Controllers
{
    [Authorize]
    public class DocumentController : Controller
    {
        // GET: Document
        DocumentDataAccess dataAccess;
        VoterDataAccess voterDataAccess ;
        RegisterDataAccess registerDataAccess ;
        DocumentDataAccess documentDataAccess ;
        public DocumentController(DocumentDataAccess dataAccess, VoterDataAccess voterDataAccess,
        RegisterDataAccess registerDataAccess,DocumentDataAccess documentDataAccess)
        {
            this.dataAccess = dataAccess;
            this.voterDataAccess = voterDataAccess;
            this.registerDataAccess =registerDataAccess;
            this.documentDataAccess =documentDataAccess;
        }
        public ActionResult DocumentStatus()
        {
            return View();
        }
        
        public ActionResult ViewDocument(int? Voterid)
        {
            try
            {
                if (documentDataAccess.AlreadySubmitted(Voterid))
                {
                    if (Voterid == null)
                    {
                        Voterid = Convert.ToInt32(Session["VoterID"]);
                       
                    }
                    var response = dataAccess.GetId(Voterid);
                    int Isadminid = Convert.ToInt32(Session["VoterID"]);
                    
                    bool Isadmin = registerDataAccess.IsAdmin(Isadminid);
                    //checking whether voter or admin is logged in
                    if (Isadmin)
                    {
                        Session["IsAdmin"] = 1;
                       
                    }
                    else
                    {
                        Session["IsAdmin"] = 0;
                     
                    }
                    return View(response);
                }
                return View();
            }
            catch
            {
                return View("Error");
            }

        }
        public ActionResult AlreadySubmittedDocument()
        {
            return View();
        }
        public async Task<ActionResult> Create(Registration register)
        {
            try
            {
                bool HaveAlreadySubmitted = dataAccess.AlreadySubmitted(register.VoterId);
                if (HaveAlreadySubmitted == false)
                {
                    var document = new Document();
                    ViewBag.VoterId = register.VoterId;
                    ViewBag.RoleID = register.RoleID;
                    return View(document);
                }
                else return RedirectToAction("AlreadySubmittedDocument");
            }
            catch
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Create(Document document)
        {
            try
            {
                bool HaveAlreadySubmitted = dataAccess.AlreadySubmitted(document.VoterId);
                if (HaveAlreadySubmitted)
                {
                    return RedirectToAction("AlreadySubmittedDocument");
                }
                if (document.Aadhar == null || document.Pan == null)
                {
                    ViewBag.Message = "Please upload an image";

                    return View();
                }
                string path = Server.MapPath("~/Scripts/Images/Aadhar/");
                string relpath = "~/Scripts/Images/Aadhar/";
                string extension = Path.GetExtension(document.Aadhar.FileName);
                string fileName = $"AADHAR-{document.VoterId.ToString()}-{document.RoleID.ToString()}{extension}";
                string fullpathDb = Path.Combine(relpath, fileName);
                string fullpathlocal = Path.Combine(path, fileName);

                document.Aadhar.SaveAs(fullpathlocal);
                document.DocumentPath = fullpathDb;

                dataAccess.Create(document);

                path = Server.MapPath("~/Scripts/Images/Pan/");
                relpath = "~/Scripts/Images/Pan/";
                extension = Path.GetExtension(document.Pan.FileName);
                fileName = $"PAN-{document.VoterId.ToString()}-{document.RoleID.ToString()}{extension}";
                fullpathDb = Path.Combine(relpath, fileName);
                fullpathlocal = Path.Combine(path, fileName);

                document.Pan.SaveAs(fullpathlocal);
                document.DocumentPath = fullpathDb;

                dataAccess.Create(document);
                voterDataAccess.UpdateVoterRequestStatus(document.VoterId);

                return RedirectToAction("DocumentStatus");
            }
            catch
            {
                return View("Error");

            }
        }

    }
}