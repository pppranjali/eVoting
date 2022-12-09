using Microsoft.AspNetCore.Mvc;
using Coditas.Ecom.Repositories;
using Coditas.Ecom.DataAccess;
using Coditas.Ecom.Entities;
namespace MVC_Apps.Controllers
{
    public class ProductController : Controller
    {
        IDbRepository<Product, int> prod;
        public ProductController(IDbRepository<Product,int> prod)
        {
            this.prod = prod;
        }
        public async Task<IActionResult> Index()
        {
            //try
            //{
                var records = await prod.GetAsync();
                return View(records);
            //}
            //catch(Exception ex)
            //{
            //    throw ;
            //}
        }
        
    }
}
