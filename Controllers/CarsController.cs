using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers {
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _allCategory = iCarsCat;
        }

        public ViewResult List() {
            ViewBag.Title = "Auto page";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCatogory = "Auto";

            return View(obj);
        }
    }
}
