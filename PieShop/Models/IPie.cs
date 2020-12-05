using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    interface IPie
    {
        IEnumerable<Pie> AllPies { get;}
        IEnumerable<Pie> PiesOfTheWeek { get;}
        Pie GetPieById(int pieId);
    }
}
