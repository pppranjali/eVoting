using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Code.Models
{
    public class InfoDBContext :DbContext
    {
#pragma warning disable CS8618 // Non-nullable property 'Persons' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public InfoDBContext()
#pragma warning restore CS8618 // Non-nullable property 'Persons' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        {
        }
        //entity mapping with table
        public DbSet<Person> Persons { get;set; }
        public DbSet<Staff> Staffs { get;set; }
        public DbSet<Doctor> Doctors { get;set; }
        public DbSet<Nurse> Nurses { get;set; }
        public DbSet<WardBoy> Wardboys { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI;MultipleActiveResultSets=true"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var doc = new Doctor[]
            {
                new Doctor(){StaffId =1 ,Specialiazation="Heart",Name="Suresh",Salary=9000},
                new Doctor(){StaffId =2,Specialiazation="Cancer",Name="Om",Salary=90}
            };
            var nur = new Nurse[]
            {
                 new Nurse(){StaffId =3,RoomAllocated=201,Salary=988,Name="deepika"},
                new Nurse(){StaffId =4,RoomAllocated=403,Salary=8766,Name="Alia"}
            };
            var Wardboy = new WardBoy[]
            {  
                new WardBoy(){StaffId =5,floor=201,Salary=455,Name="Shree"},
                new WardBoy(){StaffId =6,floor=403,Salary=974,Name="Rakesh"}
            };

            var StaffList = doc.Cast<Staff>().Union(nur).Union(Wardboy).ToList();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasData(doc);
            modelBuilder.Entity<Nurse>().HasData(nur);
            modelBuilder.Entity<WardBoy>().HasData(Wardboy);
        }
    }
}
