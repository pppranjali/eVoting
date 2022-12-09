using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Evoting_Application.Models;

namespace Evoting_Application.Service
{
    public class VoterDataAccess
    {
        EvotingApplicationEntities context = new EvotingApplicationEntities();
        DocumentDataAccess DocumentDataAccess = new DocumentDataAccess();

        public IEnumerable<CandidateDetail> CandidateList(int id)
        {
            if (id != 0)
            { 
                List<CandidateDetail> candidateDetails = new List<CandidateDetail>();
                var voter = context.Registrations.Find(id);
                string location= voter.Location;
                //var candidatelistReg = context.Registrations.Where(r => r.Location == location && r.RoleID==2).ToList();
                var candidates = (from reg in context.Registrations
                                 join candidate in context.Candidates on reg.VoterId equals candidate.VoterId
                                 where reg.Location == location && reg.RoleID==2
                                 select new CandidateDetail
                                 {
                                    VoterID=reg.VoterId,
                                    Location= reg.Location,
                                    Name = reg.Name,
                                    RepresentingParty= candidate.RepresentingParty,
                                    VoteNumber=candidate.VoteNumber
                                 }).ToList();
               
                return candidates;
            }
            else
            {
                return null;
            }
        }
        public void UpdateVoterRoleID(int? id)
        {
            if (id != 0)
            {
                var voter = context.Registrations.Find(id);
                voter.RoleID = 2;
                context.SaveChanges();
            }
        }
        //CREATE VOTER COLUMN IN VOTER TABLE
        public void UpdateVoter(int id)
        {
            Voter newvoter = new Voter();
            context.Voters.Add(newvoter);
            newvoter.VoterId = id;
            context.SaveChanges();
        }
        //Once voter submits the documents update his/her request status
        public void UpdateVoterRequestStatus(int? voterid)
        {
            var voter = context.Voters.Where(v => v.VoterId == voterid).FirstOrDefault();
            voter.RequestStatus = true;
            context.SaveChanges();
        }

        public void VotingStatus(int id)
        {
            var response=context.Voters.Where(m=>m.VoterId==id);
            Voter currentvoter= response.FirstOrDefault();
            currentvoter.HasVoted=true;
            context.SaveChanges();
        }
        public IEnumerable<Voter> VoterforApproval()
        {
            var result = context.Voters.Where(m => m.RequestStatus == true && m.Approval == false);
            return (result);
        }
        public void ApprovedVoter(int id)
        {
            var result = context.Voters.ToList().Where(m => m.VoterId == id);
            Voter response = result.FirstOrDefault();
            if (response != null)
            {
                response.RequestStatus = false;
                response.Approval = true;
                context.SaveChanges();
            }
        }
        public void DenyVoter(int id)
        {
            var result = context.Voters.ToList().Where(m => m.VoterId == id);
            Voter response = result.FirstOrDefault();
            if (response != null)
            {
                response.RequestStatus = false;
                response.Approval = false;
                context.SaveChanges();
            }
        }
        public bool IsVoterApproved(int voterId)
        {
            var voterstatus=context.Voters.Where(m=>m.VoterId==voterId).FirstOrDefault();
            if (voterstatus.Approval == true)
                return true;
            return false;
        }

        public IEnumerable<Registration> GetAllVoters()
        {
            var voterlist = context.Registrations.ToList();
            return voterlist;
        }
        public IEnumerable<Registration> SearchVoter(string name)
        {
            var nameSearch = (from voter in context.Registrations
                              where voter.Name == name
                              select voter).ToList();
            return nameSearch;
        }
        public bool VoterstatusDenied(int? voterid)
        {
            bool document=DocumentDataAccess.AlreadySubmitted(voterid);
            var voter=context.Voters.Where(m => m.VoterId == voterid).FirstOrDefault();
            if (voter.Approval == false && voter.RequestStatus == false && document == true)
            {
                return true;
            }
            return false;
        }
        public bool HasAlreadyVoted(int voterid)
        {
            var voter=context.Voters.Where(m => m.VoterId == voterid).FirstOrDefault();
            if(voter.HasVoted==true)
            {
                return true;
            }
            return false;
        }
    }
}