using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class ListPiesViewModel
    {
        public IEnumerable<Pie> AllPies { get; set; }
        public int  AvailableCakes { get; set; }
        public String CurrentCategory { get; set; }
    }
}
