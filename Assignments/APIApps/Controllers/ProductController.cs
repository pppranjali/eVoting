using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIApps.Services;
using APIApps.Models;

namespace APIApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IDbAccessService<Product, int> prodService;
        /// <summary>
        /// Inject the Service Dependency
        /// </summary>
        public ProductController(IDbAccessService<Product, int> serv)
        {
            prodService = serv;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await prodService.GetAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product prod)
        {
            var result = await prodService.CreateAsync(prod);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Product prod)
        {
            var result = await prodService.UpdateAsync(id, prod);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await prodService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
