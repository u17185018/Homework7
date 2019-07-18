using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework7.Controllers
{
    public class ShopController : Controller
    {


        //List<ViewModels.ShopItemViewModel> shop = new List<ViewModels.ShopItemViewModel>(); 
        public static  ViewModels.ShopViewModel Shop = new ViewModels.ShopViewModel();
        // GET: Shop
        public ActionResult Index()
        {
         
            return View(Shop);
        }
        public ActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItem(string fName,string fDescription,double fPrice,int fQuantity)
        {

            ViewModels.ShopItemViewModel item = new ViewModels.ShopItemViewModel(fName,fDescription,fPrice,fQuantity);
            Shop.AddItem(item);
            return View("Index",Shop);
        }
    }
}