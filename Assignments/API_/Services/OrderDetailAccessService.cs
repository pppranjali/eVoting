using Microsoft.EntityFrameworkCore;
using API_.Models;

namespace API_.Services
{
    public class OrderDetailAccessService:IDbAccessService<OrderDetail,int>
    {
        NorthwindContext _context;
        public OrderDetailAccessService(NorthwindContext context)
        {
            _context = context;
        }
        async Task<IEnumerable<OrderDetail>> IDbAccessService<OrderDetail, int>.GetAsync()
        {
            return await _context.OrderDetails.ToListAsync();
        }
        async Task<OrderDetail> IDbAccessService<OrderDetail, int>.GetAsync(int id)
        {
            var record = await _context.OrderDetails.FindAsync(id);
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
