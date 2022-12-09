using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_Project1.Database_DB;

namespace HM_Project1
{
    public class Search
    {
        public void searchstaffName(string s0)
        {

            Console.WriteLine("Performing operation Using Staff Name");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var d in Database_HM.GlobalStaffStore)
            {
                if (d.Value.StaffName == s0)
                {

                    Console.WriteLine($"-----------------------------------------------------------------");
                    Console.WriteLine($"Staff ID : {d.Value.StaffId}");
                    Console.WriteLine($"Staff Name:{d.Value.StaffName}");
                    Console.WriteLine($"Staff Email :{d.Value.Email}");
                    Console.WriteLine($"Staff Education: {d.Value.Education}");
                    Console.WriteLine($"Staff Category: {d.Value.Category}");
                    if (d.Value.Category == "Doctor")
                    {
                        var a = (Doctor)d.Value;
                        Console.WriteLine($"Fees:{a.Fees}");
                        Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                    }
                    if (d.Value.Category == "Nurse")
                    {
                        var nur = (Nurse)d.Value;
                        Console.WriteLine($"Experience: {nur.Experience}");
                        Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                    }
                    if (d.Value.Category == "Technician")
                    {
                        var tech = (Technician)d.Value;
                        Console.WriteLine($"Overtime: {tech}");
                    }
                    Console.WriteLine($"-----------------------------------------------------------------");
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public void searchstaffDepartment(string s1)
        {
            Console.WriteLine("Performing operation Using Departmnent Name");
            foreach (var d in Database_HM.DepartmentStore)
            {
                if (d.Value.DeptName == s1)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }
                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public void searchstaffLocation(string s2)
        {
            Console.WriteLine("Performing operation Using Location");
            foreach (var d in Database_DB.Database_HM.DepartmentStore)
            {
                if (d.Value.Location == s2)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_DB.Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }
                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public void searchstaffDepartmentLocation(string s1, string s2)
        {
            Console.WriteLine("Performing operation using department and location");
            foreach (var d in Database_DB.Database_HM.DepartmentStore)
            {
                if (d.Value.DeptName == s1 && d.Value.Location == s2)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_DB.Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }

                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public void searchstaffDepartmentStaffName(string s1, string s0)
        {
            Console.WriteLine("Performing operation using department and staff name");
            foreach (var d in Database_HM.DepartmentStore)
            {
                if (d.Value.DeptName == s1)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id && s.Value.StaffName == s0)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }
                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public void searchstaffLocationStaffName(string s2, string s0)
        {
            Console.WriteLine("Performing operation using location and staff name");
            foreach (var d in Database_HM.DepartmentStore)
            {
                if (d.Value.Location == s2)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id && s.Value.StaffName == s0)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }

                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public void SearchAll(string s2, string s1, string s0)
        {
            Console.WriteLine("Performing operation using all the three parameters");
            foreach (var d in Database_HM.DepartmentStore)
            {
                if (d.Value.Location == s2)
                {
                    int id = d.Key;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s in Database_HM.GlobalStaffStore)
                    {
                        if (s.Value.StaffId == id && s.Value.StaffName == s0)
                        {
                            Console.WriteLine($"-----------------------------------------------------------------");
                            Console.WriteLine($"Staff ID : {s.Value.StaffId}");
                            Console.WriteLine($"Staff Name:{s.Value.StaffName}");
                            Console.WriteLine($"Staff Email :{s.Value.Email}");
                            Console.WriteLine($"Staff Education: {s.Value.Education}");
                            Console.WriteLine($"Staff Category: {s.Value.Category}");
                            if (s.Value.Category == "Doctor")
                            {
                                var a = (Doctor)s.Value;

                                Console.WriteLine($"Fees:{a.Fees}");
                                Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");

                            }
                            if (s.Value.Category == "Nurse")
                            {
                                var nur = (Nurse)s.Value;
                                Console.WriteLine($"Experience: {nur.Experience}");
                                Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                            }
                            if (s.Value.Category == "Technician")
                            {
                                var tech = (Technician)s.Value;
                                Console.WriteLine($"Overtime: {tech}");
                            }

                            Console.WriteLine($"-----------------------------------------------------------------");
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
    }
}




