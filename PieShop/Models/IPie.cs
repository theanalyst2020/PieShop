﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
   public interface IPie
    {
        IEnumerable<Pie> AllPies { get;}
        IEnumerable<Pie> PiesOfTheWeek { get;}
        Pie GetPieById(int pieId);
    }
}
