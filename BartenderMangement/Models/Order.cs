using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMangement.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string DrinkName { get; set; }

        public TimeSpan Time {get; set;}
        
        public string DrinkModification { get; set; }

        public string FinishCheck { get; set; }

    }
}
