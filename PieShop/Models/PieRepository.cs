using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPie
    {
        public IEnumerator<Pie> AllPies =>  new List<Pie> { 
            new Pie{},
            new Pie{},
            new Pie{},
            new Pie{}
        }

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
