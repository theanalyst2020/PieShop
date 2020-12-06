using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

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
            //   ViewBag.availableCakes = "There are 50 options available";
            //  return View(PieInstance.AllPies);
            ListPiesViewModel listPiesViewModel = new ListPiesViewModel();
            listPiesViewModel.AllPies = PieInstance.AllPies;
            listPiesViewModel.CurrentCategory = "cupcakes";
            listPiesViewModel.AvailableCakes = 6;
            return View(listPiesViewModel);
        }


    }
}
