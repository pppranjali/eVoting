using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIApps.Models;
using APIApps.Services;

namespace APIApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        IDbAccessService<Category, int> catService;
        IDbAccessService<Product, int> prodService;

        public SearchController(IDbAccessService<Category, int> service, IDbAccessService<Product, int> service1)
        {
            catService = service;
            prodService = service1;
        }
        [HttpGet]
        public async Task<IActionResult> Search(string categoryName,string prodName)
        {

            var proddata = await prodService.GetAsync();
            var catdata = await  catService.GetAsync();

            var andresult = (from categ in catdata
                             join prod in proddata on categ.CategoryId equals prod.CategoryId
                             where categ.CategoryName == categoryName && prod.ProductName == prodName
                             select new
                             {
                                 categ.CategoryName,
                                 prod.ProductName,
                                 prod.ProductId,
                                 prod.ProductUniqueId,
                                 categ.BasePrice,
                                 categ.CategoryId
                             }).ToList();


            var orcatresult = from categ in catdata
                           join prod in proddata on categ.CategoryId equals prod.CategoryId
                           where categ.CategoryName == categoryName
                           select prod;

            var orprodresult = from categ in catdata
                              join prod in proddata on categ.CategoryId equals prod.CategoryId
                              where prod.ProductName == prodName
                              select categ;

            var catresult = from categ in catdata
                            where categ.CategoryName == categoryName
                            select categ;

            var prodresult = from prod in proddata
                            where prod.ProductName == prodName
                            select prod;
            
            if (categoryName == "null")
                return Ok(prodresult);
            if(prodName == "null")
                return Ok(catresult);
            if(categoryName != "null" && prodName!="null")
            {
                return Ok(andresult);
            }
            return Ok();
        }
    }
}
