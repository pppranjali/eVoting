using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coditas.Ecom.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Coditas.Ecom.Entities;
namespace Coditas.Ecom.Repositories
{
    public class ProductRepository : IDbRepository<Product, int>
    {
        eShoppingCodiContext context;
        public ProductRepository(eShoppingCodiContext context)
        {
            this.context = context;
        }
        async Task<IEnumerable<Product>> IDbRepository<Product, int>.GetAsync()
        {
            return await context.Products.ToListAsync();
        }

        async Task<Product> IDbRepository<Product, int>.GetAsync(int id)
        {
            var rec = await context.Products.FindAsync(id);
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
        async Task<Product> IDbRepository<Product, int>.CreateAsync(Product entity)
        {
            try
            {
                var res = await context.Products.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No new record created");
                throw ex;
            }
        }
        async Task<Product> IDbRepository<Product, int>.UpdateAsync(int id, Product entity)
        {
            var rec = await context.Products.FindAsync(id);
            if (rec != null)
            {

                rec.ProductId = entity.ProductId;
                rec.ProductName = entity.ProductName;
                rec.Description = entity.Description;
                rec.Price = entity.Price;
                rec.CategoryId = entity.CategoryId;

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
        async Task<Product> IDbRepository<Product, int>.DeleteAsync(int id)
        {
            try
            {
                var record = await context.Products.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Product Id {id} is Missing");
                context.Products.Remove(record);
                await context.SaveChangesAsync();
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
