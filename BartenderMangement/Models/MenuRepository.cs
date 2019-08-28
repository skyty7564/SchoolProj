using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMangement.Models
{
    public interface MenuRepository
    {
        IEnumerable<Drink> Drink { get; }

        
    }
}
