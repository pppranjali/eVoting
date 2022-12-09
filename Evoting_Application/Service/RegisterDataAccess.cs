using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Evoting_Application.Models;

namespace Evoting_Application.Service
{
    public class RegisterDataAccess
    {
        EvotingApplicationEntities context = new EvotingApplicationEntities();
        public Registration GetIdAdmin(int id)
        {
            var result = context.Registrations.Find(id);
            return result;
        }
       //edit by admin
        public  Registration UpdateVoterByAdmin(int id, Registration registration)
        {
            var record = context.Registrations.Find(id);
            if (record != null)
            {
                record.Name = registration.Name;
                record.MobileNumber = registration.MobileNumber;
                record.Location = registration.Location;
                record.Address = registration.Address;
                record.Gender = registration.Gender;
                context.SaveChanges();
                return record;
            }
            else
            {
                return null;
            }
        }
        public bool CandidateAgeValidate(Registration registration)
        {
            var CandidateAge = (from register in context.Registrations
                               where register.VoterId == registration.VoterId
                               select register).FirstOrDefault();
            var today = DateTime.Today;
            var age = today.Year - CandidateAge.Birthdate.Year;
            if(age >=25)
            {
                return true;
            }
            return false;

        }
        public bool IsAdmin(int voterid)
        {
            var Isadmin = context.Registrations.Where(registration => registration.VoterId == voterid && registration.RoleID == 3).FirstOrDefault();
            if(Isadmin == null)
            {
                return false;
            }
            return true;
        }
        public async Task<IEnumerable<Registration>> GetAsync()
        {
            return await context.Registrations.ToListAsync();
        }
        public async Task<Registration> Update(int id, Registration registration)
        {
            var record = await context.Registrations.FindAsync(id);
            if (record != null)
            {
                record.Name = registration.Name;
                record.MobileNumber = registration.MobileNumber;
                await context.SaveChangesAsync();
                return record;
            }
            else
            {
                return null;
            }
        }
        public async Task<Registration> GetIdAsync(int id)
        {
            var result = await context.Registrations.FindAsync(id);
            return result;
        }

    }
}
