using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using APIApps.Models;
using APIApps.Services;
namespace APIApps.Controllers
{
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class CategoryOASController : ControllerBase
    {
        IDbAccessService<Category, int> catDbAccess;
        public CategoryOASController(IDbAccessService<Category, int> catDbAccess)
        {
            this.catDbAccess = catDbAccess;
        }
        
        [HttpGet("/getcategories")]
        public async Task<IEnumerable<Category>> Get()
        {
            var result = await catDbAccess.GetAsync();
            return result;
        }

        [HttpPost("/createcategory")]
        public async Task<Category> Post(Category category)
        {
            var result = await catDbAccess.CreateAsync(category);
            return result;
        }
    }
}
