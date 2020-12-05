﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    interface IPie
    {
        public IEnumerator<Pie> AllPies { get;}
        public IEnumerable<Pie> PiesOfTheWeek { get;}
        Pie GetPieById(int pieId);
    }
}
