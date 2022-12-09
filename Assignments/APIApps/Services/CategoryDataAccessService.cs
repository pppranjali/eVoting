using APIApps.Models;
using Microsoft.EntityFrameworkCore;

namespace APIApps.Services
{
    public class CategoryDataAccessService : IDbAccessService<Category, int>
    {
        eShoppingCodiContext context;
        public CategoryDataAccessService(eShoppingCodiContext context)
        {
            this.context = context;
        }

        async Task<IEnumerable<Category>> IDbAccessService<Category, int>.GetAsync()
        {
            return await context.Categories.ToListAsync();
        }
        
        async Task<Category> IDbAccessService<Category, int>.GetAsync(int id)
        {
            var rec = await context.Categories.FindAsync(id);
            if (rec != null)
            {
                return rec;
            }
            else
            {
                Console.WriteLine("No such record found!");
                return null;
            }
        }
        async Task<Category> IDbAccessService<Category, int>.CreateAsync(Category entity)
        {
            try
            {
                var res = await context.Categories.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No new record created");
                throw ex;
            }
        }

        async Task<Category> IDbAccessService<Category, int>.UpdateAsync(int id, Category entity)
        {
            var rec = await context.Categories.FindAsync(id);
            if (rec != null)
            {

                rec.CategoryId = entity.CategoryId;
                rec.CategoryName = entity.CategoryName;
                rec.BasePrice = entity.BasePrice;
                int result = await context.SaveChangesAsync();
                if (result > 0)
                    return rec;
                else
                {
                    Console.WriteLine("Record not updated");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Record not found to be updated");
                return null;
            }
        }

        async Task<bool> IDbAccessService<Category, int>.DeleteAsync(int id)
        {
            var rec = await context.Categories.FindAsync(id);
            if (rec != null)
            {
                context.Categories.Remove(rec);
                int result = await context.SaveChangesAsync();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                Console.WriteLine("No record found to delete");
                return false;
            }
        }
    }
}
