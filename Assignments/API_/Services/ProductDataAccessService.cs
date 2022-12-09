using Microsoft.EntityFrameworkCore;
using API_.Models;

namespace API_.Services
{
    public class ProductDataAccessService:IDbAccessService<Product,int>
    {
        NorthwindContext _context;
        public ProductDataAccessService(NorthwindContext context)
        {
            _context = context;
        }
        async Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync()
        {
            return await _context.Products.ToListAsync();
        }
        async Task<Product> IDbAccessService<Product, int>.GetAsync(int id)
        {
            var record = await _context.Products.FindAsync(id);
            if (record != null)
            {
                return record;
            }
            else
            {
                Console.WriteLine("No such record found!");
                return null;
            }
        }
    }
}
