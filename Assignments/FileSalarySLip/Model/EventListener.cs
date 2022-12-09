//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FileSalarySLip.Model;
//using FileSalarySLip.Entity;

//namespace FileSalarySLip
//{
//    public class EventListener
//    {
//        //public delegate void NotificationEventHandler();

//        private IDbOperations<Doctor, int> doc;
//        private IDbOperations<Nurse, int> nurse;
//        private IDbOperations<Driver, int> driver;



//        public EventListener(IDbOperations<Nurse, int> nurse)
//        {
//            this.nurse = nurse;
//            nurse.StaffCreated += _StaffCreated;
//            nurse.StaffUpdated += _StaffUpdated;
//            nurse.StaffDeleted += _StaffDeleted;
        
//        }
//        public EventListener(IDbOperations<Driver, int> driver)
//        {
//            this.driver = driver;
//            driver.StaffCreated += _StaffCreated;
//            driver.StaffUpdated += _StaffUpdated;
//            driver.StaffDeleted += _StaffDeleted;

//        }
//        public EventListener(IDbOperations<Doctor, int> doc)
//        {
//            this.doc = doc;
//            doc.StaffCreated += _StaffCreated;
//            doc.StaffUpdated += _StaffUpdated;
//            doc.StaffDeleted += _StaffDeleted;

//        }
//        private void _StaffCreated()
//        {
//            Console.WriteLine($"Staff Created notification");
//        }

//        private void _StaffUpdated()
//        {
//            Console.WriteLine($"Staff Updated notification");
//        }

//        private void _StaffDeleted()
//        {
//            Console.WriteLine($"Staff Deleted notification");
//        }
//    }
        
//}
