using APIApps.Models;
using APIApps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApps.Controllers
{
    //ControllerBase class is the super base class for API 

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IDbAccessService<Category, int> catService;
        /// <summary>
        /// Inject the Service Dependency
        /// </summary>
        public CategoryController(IDbAccessService<Category, int> serv)
        {
            catService = serv;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await catService.GetAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Category cat)
        {
            var result = await catService.CreateAsync(cat);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Category cat)
        {
            var result = await catService.UpdateAsync(id, cat);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await catService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
