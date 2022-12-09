using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic_Class
{
    /// <summary>
    /// Pure ENtity Class or DTO or VO
    /// </summary>
    public class Staff
    {
        // Private Data Members 
       
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
            {
                if (value < 0 )
                {
                    Console.WriteLine("Please do not enter negative value!!");
                    Console.WriteLine("Reenter the correct values: ");
                }
                else
                {
                    _StaffId = value;
                }
            }
        }
#pragma warning disable CS8618 // Non-nullable field '_StaffName' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _StaffName;
#pragma warning restore CS8618 // Non-nullable field '_StaffName' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string StaffName
        {
            get { return _StaffName; }
            set
            {
                string special = "!#$%&/()=?»«@£§€{}.-;'<>_,";
                bool flag = true;
                int count = 0;
                while (flag)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (special.Contains(value[i]))
                        {
                            Console.WriteLine("Do not enter special characters for name!!");
                            count = 1;
                            break;
                        }
                    }

                    if (count == 1)
                    {
                        Console.WriteLine("Enter the Name : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        value = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                        _StaffName = value;
#pragma warning restore CS8601 // Possible null reference assignment.
                        count = 0;
                        break;
                    }
                    else
                    {
                        _StaffName = value;
                        flag = false;
                    }
                }
            }

        }
#pragma warning disable CS8618 // Non-nullable field '_Email' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _Email;
#pragma warning restore CS8618 // Non-nullable field '_Email' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string Email
        {

            get { return _Email; }
            set {
                _Email = value;
            }

        }
#pragma warning disable CS8618 // Non-nullable field '_DeptName' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _DeptName;
#pragma warning restore CS8618 // Non-nullable field '_DeptName' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string DeptName
        {
            get { return _DeptName; }
            set
            {
                string[] dept1 = { "Heart", "Cancer","Eye","Blood Bank","Organs","Pathology","Orthopeic","Dental","Radiology"};
                int inlist = 0;
                while (inlist == 0)
                {
                    foreach (string dept in dept1)
                    {
                        if (value == dept)
                        {
                            inlist = 1;
                        }
                    }
                    if (inlist == 1)
                    {
#pragma warning disable CS8601 // Possible null reference assignment.
                        _DeptName = value;
#pragma warning restore CS8601 // Possible null reference assignment.
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid department: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        value = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                        inlist = 0;
                    }
                }
            }
        }
#pragma warning disable CS8618 // Non-nullable field '_Gender' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _Gender;
#pragma warning restore CS8618 // Non-nullable field '_Gender' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string Gender
        {
            get { return _Gender; }
            set
            {
                int gen = 0;
                while (gen == 0)
                {
                    if (value == "Male" || value == "Female")
                    {
                        _Gender = value;
                        gen = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid gender:: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        value = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                        gen=0;
                    }
                }
            }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                //_DateOfBirth = value;
                int age = 0;
                DateTime now =  DateTime.Now;
                int a = now.Year - value.Year;
                while(age == 0)
                {

                    if (a > 27)
                    {
                        _DateOfBirth = value;
                        age = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid age:: ");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
                        value = DateTime.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
                        a=now.Year - value.Year;
                        age = 0;
                    }
                }
            }
        }
#pragma warning disable CS8618 // Non-nullable field '_StaffCategory' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _StaffCategory;
#pragma warning restore CS8618 // Non-nullable field '_StaffCategory' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string StaffCategory
        {
            get { return _StaffCategory; }

            set {
#pragma warning disable CS0219 // The variable 'flag' is assigned but its value is never used
                int flag = 0;
#pragma warning restore CS0219 // The variable 'flag' is assigned but its value is never used
                int inlist = 0;
                string[] category1 = { "Doctor", "Nurse", "Wardnboy", "Brother", "Technician" };
                {
                    while (inlist == 0)
                    {
                        foreach (string cat in category1)
                        {
                            if (value == cat)
                            {
                                inlist = 1;
                            }
                        }
                        if (inlist == 1)
                        {
#pragma warning disable CS8601 // Possible null reference assignment.
                            _StaffCategory = value;
#pragma warning restore CS8601 // Possible null reference assignment.
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Enter valid category: ");
                            Console.WriteLine("ReEnter correct category::");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                            value = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                            inlist = 0;
                        }
                    }
                } 
            }
        }
#pragma warning disable CS8618 // Non-nullable field '_Education' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _Education;
#pragma warning restore CS8618 // Non-nullable field '_Education' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string Education
        {
            get { return _Education; }
            set { _Education = value; }
        }
        private int _ContactNo;
        public int ContatNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }
    }

}