using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegate_and_Event.Entity
{
    public class Staff
    {
        static public int DocID;
        static public int NurseID;
        static public int DriverID;
        public int StaffId { get; set; }

        public int BasicPay { get; set; }
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
        public string Email { get; set; } = String.Empty;

        private int _ContactNo;
        public int ContactNo
        {
            get { return _ContactNo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please do not enter negative value!!");
                    Console.WriteLine("Reenter the correct values: ");
                }
                else
                {
                    _ContactNo = value;
                }
            }
        }
#pragma warning disable CS8618 // Non-nullable field '_Education' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        private string _Education;
#pragma warning restore CS8618 // Non-nullable field '_Education' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string Education
        {
            get { return _Education; }
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
                            Console.WriteLine("Do not enter special characters for Education!!");
                            count = 1;
                            break;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Enter the Education : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        value = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                        _Education = value;
#pragma warning restore CS8601 // Possible null reference assignment.
                        count = 0;
                        break;
                    }
                    else
                    {
                        _Education = value;
                        flag = false;
                    }
                }
            }
        }
    }
}
