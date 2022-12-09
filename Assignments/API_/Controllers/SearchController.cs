using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_.Services;
using API_.Models;
namespace API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        IDbAccessService<Customer, int> custService;
        IDbAccessService<Product, int> prodService;
        IDbAccessService<Order, int> ordService;
        IDbAccessService<OrderDetail, int> orddetService;
        
        public SearchController(IDbAccessService<Customer, int> service, IDbAccessService<Product, int> service1, IDbAccessService<Order, int> service2, IDbAccessService<OrderDetail, int> service3)
        {
            custService = service;
            prodService = service1;
            ordService = service2;
            orddetService = service3;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await custService.GetAsync();
            var ordersdetails = await orddetService.GetAsync();
            var products = await prodService.GetAsync();
            var orders = await ordService.GetAsync();

            var result = from cust in customers
                         join ord in orders on cust.CustomerId equals ord.CustomerId
                         join orddet in ordersdetails on ord.OrderId equals orddet.OrderId
                         join prod in products on orddet.ProductId equals prod.ProductId
                         where prod.ProductName=="Chai" || prod.ProductName== "Ikura" || prod.ProductName== "Pavlova"
                         select new
                         {
                             cust.ContactName,
                             cust.CustomerId,
                             ord.OrderId
                         };
                         
            return Ok(result);
        }
        //public async Task<IActionResult> Query3()
        //{
        //    var customers = await custService.GetAsync();
        //    var ordersdetails = await orddetService.GetAsync();
        //    var products = await prodService.GetAsync();
        //    var orders = await ordService.GetAsync();

        //    var result = from cust in customers
        //                 join ord in orders on cust.CustomerId equals ord.CustomerId
        //                 join orddet in ordersdetails on ord.OrderId equals orddet.OrderId
        //                 join prod in products on orddet.ProductId equals prod.ProductId
        //                 group by 
        //                 select new
        //                 {
                             
        //                 }.ToList();

        //    return Ok(result);
        //}
    }
}