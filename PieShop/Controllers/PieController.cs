using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPie PieInstance;
        private readonly ICategory CategoryInstance;
        public PieController(IPie PieRepository, ICategory CategoryRepository)
        {
            PieInstance = PieRepository;
            CategoryInstance = CategoryRepository;
        }

        public ViewResult ListPies()
        {
                return View(PieInstance.AllPies);
         }


    }
}
