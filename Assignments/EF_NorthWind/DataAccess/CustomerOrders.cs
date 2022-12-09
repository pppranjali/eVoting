using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_NorthWind.Models1;

namespace EF_NorthWind.DataAccess
{
    public class CustomerOrders
    {
        NorthwindContext _context;
        public CustomerOrders()
        {
            _context= new NorthwindContext();
        }

        public void CustomerTotalOrders()
        {
            var custtotalorder = from ord in _context.Orders
                                 join cust in _context.Customers
                                 on ord.CustomerId equals cust.CustomerId
                                 group cust by cust.ContactName into custorddept
                                 select new
                                 {
                                     CustName = custorddept.Key,
                                     totalOrd = custorddept.Count()
                                 };

            foreach (var cust in custtotalorder)
            {
                Console.WriteLine($"Customer Name: {cust.CustName}     Total number of orders: {cust.totalOrd}");
            }
        }
        public void CustomerOrderDetails()
        {
            var custtotalorderdet = (from ord in _context.Orders
                                 join cust in _context.Customers
                                 on ord.CustomerId equals cust.CustomerId
                                 join orddet in _context.OrderDetails
                                 on ord.OrderId equals orddet.OrderId
                                 select new 
                                 {
                                     CustName = cust.ContactName,
                                     OrdId = ord.OrderId,
                                     ProductId=orddet.ProductId,
                                     Price=orddet.UnitPrice,
                                     Discount=orddet.Discount,
                                     Quantity=orddet.Quantity,
                                     DateofOrder=ord.OrderDate,
                                     CustomerId=cust.CustomerId

                                 }).ToList();

            foreach (var cust in custtotalorderdet)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Customer Name: {cust.CustName}");
                Console.WriteLine($"OrderID: {cust.OrdId}");
                Console.WriteLine($"Customer Id: {cust.CustomerId}");
                Console.WriteLine($"Product Id: {cust.ProductId}");
                Console.WriteLine($"Prize:  {cust.Price}");
                Console.WriteLine($"Quantity: {cust.Quantity}");
                Console.WriteLine($"Discount: {cust.Discount}");
                Console.WriteLine($"Date Of Order: {cust.DateofOrder}");
                Console.WriteLine("--------------------------------------------------");
                
            }
        }

        public void EachOrderDetail()
        {
            var custprizedet = (from ord in _context.Orders
                                     join cust in _context.Customers
                                     on ord.CustomerId equals cust.CustomerId
                                     join orddet in _context.OrderDetails
                                     on ord.OrderId equals orddet.OrderId
                                     //group orddet by new { cust.ContactName,ord.OrderId} into prizedetails
                                     select new
                                     {
                                         //CustName = prizedetails.Key.ContactName,
                                         //OrderId = prizedetails.Key.OrderId,
                                         //prize = prizedetails
                                         CustName = cust.ContactName,
                                         OrdId = ord.OrderId,
                                         Price = orddet.UnitPrice,
                                         CustomerId = cust.CustomerId

                                     }).ToList();

            foreach (var cust in custprizedet)
            {
                //Console.WriteLine("-------------------------------------------------");

                //Console.WriteLine($"Customer Name: {cust.CustName}");
                //Console.WriteLine($"OrderID: {cust.OrderId}");
                //foreach(var v in cust.prize)
                //Console.WriteLine($"Prize:  {v.UnitPrice}");

                //Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Customer Name: {cust.CustName}");
                Console.WriteLine($"OrderID: {cust.OrdId}");
                Console.WriteLine($"Customer Id: {cust.CustomerId}");
                Console.WriteLine($"Price:  {cust.Price}");

            }

        }
    }
}
