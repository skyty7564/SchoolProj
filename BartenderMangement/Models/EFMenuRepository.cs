using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMangement.Models
{
    public class EFMenuRepository  : MenuRepository
    {
        private ApplicationDbContext context;

        public EFMenuRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Drink> Drink => context.Drink;


    }
}
