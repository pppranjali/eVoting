using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evoting_Application.Models;
using System.Web.Security;


namespace Evoting_Application.Service
{
    public class ResultServiceAcces
    {
        EvotingApplicationEntities context =new EvotingApplicationEntities();
        VoterDataAccess voterDataAccess = new VoterDataAccess();
       
        public bool Vote(int votenumber,int voterId)
        {
            bool voterstatus = voterDataAccess.IsVoterApproved(voterId);
            bool voterAlreadyVoted = voterDataAccess.HasAlreadyVoted(voterId);
            if (voterstatus && !voterAlreadyVoted)
            {
                var candiate = context.Results.Where(m => m.VoteNumber == votenumber).ToList();
                Result result = candiate.FirstOrDefault();
                result.NumberOfVotes = result.NumberOfVotes + 1;
                context.SaveChanges();
                voterDataAccess.VotingStatus(voterId);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int result(int voterID)
        {
            Dictionary<int,int>numberOfVotes=new Dictionary<int,int>();
            List<int> voteNumber = new List<int>();
            var locationOfVoter= context.Registrations.Find(voterID);
            string location=locationOfVoter.Location;
            var locationBasedCandidates = context.Registrations.Where(m => m.Location==location && m.RoleID==2).ToList();
            if (locationBasedCandidates.Any())
            {
                foreach (var candidate in locationBasedCandidates)
                {
                    var VoteNumber = context.Candidates.Where(m => m.VoterId == candidate.VoterId).ToList();
                    int voteno = VoteNumber.FirstOrDefault().VoteNumber;
                    voteNumber.Add(voteno);
                }
                foreach (var votenumber in voteNumber)
                {
                    var value = context.Results.Where(m => m.VoteNumber == votenumber).ToList();
                    int valueofnumberofvotes = value.FirstOrDefault().NumberOfVotes;
                    numberOfVotes.Add(votenumber, valueofnumberofvotes);

                }
                var maxValueKey = numberOfVotes.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                return maxValueKey;
            }
            return 0;

        }
        public WinnerCandidateDetail WinnerCandidateDetail(int VoteNumber)
        {
            var winnerCandidateDetails = (from winningcandidate in context.Results
                                         join
                                         candidate in context.Candidates on winningcandidate.VoteNumber equals candidate.VoteNumber
                                         join
                                         register in context.Registrations on candidate.VoterId equals register.VoterId
                                         where candidate.VoteNumber == VoteNumber
                                         select new WinnerCandidateDetail
                                         {
                                            VoteNumber = VoteNumber,
                                            location = register.Location,
                                            VoterId = register.VoterId,
                                            VoterCount = winningcandidate.NumberOfVotes,
                                            CandidateName = register.Name
                                         }).FirstOrDefault();

            return winnerCandidateDetails;
        }
       

    }
}