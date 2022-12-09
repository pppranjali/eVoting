using API_.Models;
using Microsoft.EntityFrameworkCore;
namespace API_.Services
{
    public class OrderAccessService:IDbAccessService<Order,int>
    {
        NorthwindContext _context;
        public OrderAccessService(NorthwindContext context)
        {
            _context = context;
        }
        async Task<IEnumerable<Order>> IDbAccessService<Order, int>.GetAsync()
        {
            return await _context.Orders.ToListAsync();
        }
        async Task<Order> IDbAccessService<Order, int>.GetAsync(int id)
        {
            var record = await _context.Orders.FindAsync(id);
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
