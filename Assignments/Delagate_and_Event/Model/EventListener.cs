using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_and_Event.Model;
using Delegate_and_Event.Entity;

namespace Delegate_and_Event
{
    public class EventListener
    {
        //public delegate void NotificationEventHandler();

        private IDbOperations<Doctor, int> doc;
        private IDbOperations<Nurse, int> nurse;
        private IDbOperations<Driver, int> driver;



#pragma warning disable CS8618 // Non-nullable field 'driver' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'doc' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public EventListener(IDbOperations<Nurse, int> nurse)
#pragma warning restore CS8618 // Non-nullable field 'doc' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'driver' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            this.nurse = nurse;
            nurse.StaffCreated += _StaffCreated;
            nurse.StaffUpdated += _StaffUpdated;
            nurse.StaffDeleted += _StaffDeleted;
        
        }
#pragma warning disable CS8618 // Non-nullable field 'doc' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'nurse' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public EventListener(IDbOperations<Driver, int> driver)
#pragma warning restore CS8618 // Non-nullable field 'nurse' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'doc' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            this.driver = driver;
            driver.StaffCreated += _StaffCreated;
            driver.StaffUpdated += _StaffUpdated;
            driver.StaffDeleted += _StaffDeleted;

        }
#pragma warning disable CS8618 // Non-nullable field 'driver' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'nurse' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public EventListener(IDbOperations<Doctor, int> doc)
#pragma warning restore CS8618 // Non-nullable field 'nurse' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'driver' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            this.doc = doc;
            doc.StaffCreated += _StaffCreated;
            doc.StaffUpdated += _StaffUpdated;
            doc.StaffDeleted += _StaffDeleted;

        }
        private void _StaffCreated()
        {
            Console.WriteLine($"Staff Created notification");
        }

        private void _StaffUpdated()
        {
            Console.WriteLine($"Staff Updated notification");
        }

        private void _StaffDeleted()
        {
            Console.WriteLine($"Staff Deleted notification");
        }
    }
        
}
