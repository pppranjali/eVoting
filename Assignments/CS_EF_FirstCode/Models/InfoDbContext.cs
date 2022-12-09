using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CS_EF_FirstCode.Models
{
    public class InfoDbContext:DbContext
    {
        public InfoDbContext()
        {

        }

        //mapping
        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<WardBoy> Wardboy1 { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                       // One Product HAs One Category
                       // One-to-one Relationship
                       .HasOne<Department>(p => p.department)
                       // One Category HAs Multiple Products
                       // One-To-any Relationshs
                       .WithMany(c => c.Employees)
                       .HasForeignKey(c => c.DepartmentID);

            modelBuilder.Entity<Project>().HasKey(p => p.ProjectId);
            modelBuilder.Entity<Project>().Property(p => p.ProjectName).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Project>().Property(p => p.CustomerName).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Project>().Property(p => p.ManagerName).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Project>().Property(p => p.Technology).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Project>().Property(p => p.TeamSize).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.StartDate).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.EndDate).IsRequired();

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
            

            modelBuilder.Entity<Doctor>().HasData(doc);
            modelBuilder.Entity<Nurse>().HasData(nur);
            modelBuilder.Entity<WardBoy>().HasData(Wardboy);

            base.OnModelCreating(modelBuilder);
        }
    }
}
