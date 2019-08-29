using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMangement.Models
{
    public interface OrderRepository
    {
        IEnumerable<Order> Order { get; }

        void SaveOrder(Order order);
    }
}
