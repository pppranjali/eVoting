using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Evoting_Application.Models;
namespace Evoting_Application.Service
{
    public class DocumentDataAccess
    {
        EvotingApplicationEntities context = new EvotingApplicationEntities();
        
        public IEnumerable<Document> GetId(int? id)
        {
            var result =  context.Documents.ToList().Where(m => m.VoterId == id);
            return result;
        }
        
        public Document Create(Document document)
        {
            var result = context.Documents.Add(document);
            context.SaveChanges();
            return result;
        }
        public bool AlreadySubmitted(int? voterId)
        {
            var IsExist = context.Documents.Where(m => m.VoterId == voterId).ToList();
            if(IsExist.Count>0)
                return true;
            return false;
        }
    }
}