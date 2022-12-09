using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evoting_Application.Models;
namespace Evoting_Application.Service
{
    public class CandidateDataAccess
    {
        EvotingApplicationEntities context = new EvotingApplicationEntities();

        public void Create(Candidate candidate)
        {
            if (candidate.VoterId != 0)
            {
                context.Candidates.Add(candidate);
                var result = context.SaveChanges();
                if (result > 0)
                {
                     //Registration table making changes
                    var candidateindb = context.Candidates.Where(m => m.VoterId == candidate.VoterId);
                    Candidate response = candidateindb.FirstOrDefault();
                    if (response != null)
                    {
                        response.RequestStatus = candidate.RequestStatus;
                        response.Approval = candidate.Approval;
                        context.SaveChanges();
                    }
                }
            }
        }
        public Candidate GetById(int id)
        {
            var result = context.Candidates.ToList().Where(m => m.VoterId == id);
            Candidate response = result.FirstOrDefault();
            return response;
        }
        //after approval we are storing the candidate in database
        public Candidate UpdateCandidate(int Voterid,Candidate candidate)//here
        {
            var record = context.Candidates.Where(v=>v.VoterId==Voterid).FirstOrDefault();
            if (record != null)
            {
                record.RepresentingParty = candidate.RepresentingParty;
                record.RequestStatus = candidate.RequestStatus;
                record.Approval = candidate.Approval;
                context.SaveChanges();
                return record;
            }
            else
            {
                return null;
            }
        }
       
        public IEnumerable<Candidate> CandidateforApproval()
        {
            var result = context.Candidates.Where(m => m.RequestStatus == true && m.Approval == false);
            return (result);
        }
        public void ApprovedCandidate(int id)
        {
            //to update in registeration table the roleID
            var registrationtable = context.Registrations.Find(id);
            registrationtable.RoleID = 2;
            context.SaveChanges();

            var result = context.Candidates.ToList().Where(m => m.VoterId == id);
            Candidate response = result.FirstOrDefault();
            if (response != null)
            {
                response.RequestStatus = false;
                response.Approval = true;
                context.SaveChanges();
                //here add code that after candidate is approved add him in results table
                Result newcandidate = new Result();
                context.Results.Add(newcandidate);
                newcandidate.VoteNumber = response.VoteNumber;
                context.SaveChanges();
            }
        }
        public void DenyCandidate(int id)
        {
            var result = context.Candidates.ToList().Where(m => m.VoterId == id);
            Candidate response = result.FirstOrDefault();
            if (response != null)
            {
                response.RequestStatus = false;
                response.Approval = false;
                context.SaveChanges();
            }
        }
        public IEnumerable<Candidate> GetAllCandidates()
        {
            var candidatelist=context.Candidates.ToList();
            return candidatelist;
        }

        public IEnumerable<CandidateDetail> SearchCandidate(string name)
        {
            var nameSearch = (from voter in context.Registrations join 
                              candidate in context.Candidates on voter.VoterId equals candidate.VoterId
                              where voter.Name == name
                              select new CandidateDetail
                              {
                                  Name = voter.Name,
                                  VoterID= voter.VoterId,
                                  Location= voter.Location,
                                  VoteNumber=candidate.VoteNumber,
                                  RepresentingParty=candidate.RepresentingParty

                              }).ToList();
            return nameSearch;
        }
        public bool AlreadyAppliedCandidate(int id)
        {
            var alreadyapplied=context.Candidates.Any(m => m.VoterId == id);
            if(alreadyapplied)
            {
                return true;
            }
            return false;
        }
    }
}