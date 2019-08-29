using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMangement.Models
{
    public class EFOrderRepository : OrderRepository
    {
        private ApplicationDbContext context;

        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Order> Order => context.Order;


        public void SaveOrder(Order order)
        {
           
            if (order.OrderID != 0)
            {
                Order dbEntry = context.Order.FirstOrDefault(p => p.OrderID == order.OrderID);
                context.Order.Add(order);


            }
            context.SaveChanges();
        }
       


    }
}
