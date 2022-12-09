using Microsoft.AspNetCore.Mvc;
using Coditas.Ecom.DataAccess;
using Coditas.Ecom.Entities;
using Coditas.Ecom.Repositories;

namespace MVC_Apps.Controllers
{
    public class CategoryController : Controller
    {
        IDbRepository<Category, int> CatRespo;
        public CategoryController(IDbRepository<Category, int> catRespo)
        {
            this.CatRespo = catRespo;
        }

        public async Task<IActionResult> Index()
        {
                var records = await CatRespo.GetAsync();
                // THis will return an Index.cshtml View from
                // Category Sub-Folder of the Views folder
                // and pass the records (Categories) to it
                return View(records);
        }
        public async Task<IActionResult> Create()
        {
            var category = new Category();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                var respose = await CatRespo.CreateAsync(category);
                if (category.BasePrice < 0)
                    throw new Exception("DO NOT ENTER NEGATIVE VALUE FOR BASE PRICE");
                // Return to Index Action Method in Same
                // Controller
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }
        public async Task<IActionResult> Edit(int id)
        {
            var record = await CatRespo.GetAsync(id);
            return View(record);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            try
            {
                var result = await CatRespo.UpdateAsync(id, category);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            var record = await CatRespo.GetAsync(id);
            return View(record);
        }
       
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await CatRespo.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
