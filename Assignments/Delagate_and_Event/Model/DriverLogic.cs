using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_and_Event.Entity;

namespace Delegate_and_Event.Model
{
    
    public class DriverLogic : StaffLogic, IDbOperations<Driver, int>
    {
        List<Driver> Drivers = new List<Driver>();
#pragma warning disable CS8618 // Non-nullable event 'StaffCreated' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
        public event NotificationEventHandler StaffCreated;
#pragma warning restore CS8618 // Non-nullable event 'StaffCreated' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
#pragma warning disable CS8618 // Non-nullable event 'StaffDeleted' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
        public event NotificationEventHandler StaffDeleted;
#pragma warning restore CS8618 // Non-nullable event 'StaffDeleted' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
#pragma warning disable CS8618 // Non-nullable event 'StaffUpdated' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
        public event NotificationEventHandler StaffUpdated;
#pragma warning restore CS8618 // Non-nullable event 'StaffUpdated' must contain a non-null value when exiting constructor. Consider declaring the event as nullable.
        List<Driver> IDbOperations<Driver, int>.Create(Driver entity)
        {
            Drivers.Add(entity);
            StaffCreated();
            return Drivers;
        }
        List<Driver> IDbOperations<Driver, int>.Delete(int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Driver searchDriver = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            foreach (var item in Drivers)
            {
                if (item.StaffId == id)
                {
                    searchDriver = item;
                    break;
                }
            }
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Driver>.Remove(Driver item)'.
            Drivers.Remove(searchDriver);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Driver>.Remove(Driver item)'.
            StaffDeleted();
            return Drivers;
        }
        Driver IDbOperations<Driver, int>.Get(int id)
        {
            int flag = 0;
            foreach (var item in Drivers)
            {
                if (item.StaffId == id)
                {
                    flag = 1;
                    return item;
                }
            }
            if (flag == 0)
                Console.WriteLine("Id record not found");
            return new Driver();
        }
        List<Driver> IDbOperations<Driver, int>.GetAll()
        {
            return Drivers;
        }
        List<Driver> IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            int flag = 0;
            foreach (var item in Drivers)
            {
                if (item.StaffId == id)
                {
                    String ContinueExecution = "c";
                    flag = 1;
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. To Update Email");
                        Console.WriteLine("3. To Update Contact");
                        Console.WriteLine("4. To Update Education");
                        Console.WriteLine("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upname = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.StaffName = upname;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 2:
                                Console.WriteLine("Enter Email:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upemail = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Email = upemail;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 3:
                                Console.WriteLine("Enter Contact:");
                                int upcontact = Convert.ToInt32(Console.ReadLine());
                                item.ContactNo = upcontact;
                                break;   
                        }
                        StaffUpdated();
                        Console.WriteLine("To continue with next updation press c : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        ContinueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    } while (ContinueExecution == "c");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No record found");
            }
            return Drivers;
        }
        public long GrossSalary(Driver d)
        {
            long gross = d.BasicPay * (500*d.VehicleType);
            return gross;
        }
        public decimal Tax1(Driver d)
        {
            decimal tax = (18 / Convert.ToDecimal(100)) * d.BasicPay;
            return tax; 
        }
        public decimal HospitalShare(Driver d)
        {
            decimal hospitalShare = (2 / Convert.ToDecimal(100)) * d.BasicPay;
            return hospitalShare;
        }
    }

}
