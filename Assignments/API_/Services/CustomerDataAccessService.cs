using Microsoft.EntityFrameworkCore;
using API_.Models;

namespace API_.Services
{
    public class CustomerDataAccessService:IDbAccessService<Customer,int>
    {
        NorthwindContext _context;
        public CustomerDataAccessService(NorthwindContext context)
        {
            _context = context;
        }
        async Task<IEnumerable<Customer>> IDbAccessService<Customer, int>.GetAsync()
        {
            return await _context.Customers.ToListAsync();
        }
        async Task<Customer> IDbAccessService<Customer, int>.GetAsync(int id)
        {
            var record = await _context.Customers.FindAsync(id);
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
