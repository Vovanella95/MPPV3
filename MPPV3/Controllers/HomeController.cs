using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MPPV3.Models;

namespace MPPV3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BelpostContext a = new BelpostContext();

        

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Calculate(OrderModel order)
        {
            return View(order);
        }

        public static string Answer(int a, int price)
        {
            return a <= 0 ? "Error, mass undetected" : "Your price is " + price.ToString()+"$";
        }

        public static IEnumerable<Product> GetProductList()
        {
            return (new BelpostContext()).Products;
        }

        public static IEnumerable<Country> GetCountryList()
        {
            return (new BelpostContext()).Countries;
        }

        public static Product FindProduct(OrderModel order)
        {
            return (new BelpostContext()).Products.First(w=>w.Name==order.product);
        }

        public static Country FindCountry(OrderModel order)
        {
            return (new BelpostContext()).Countries.First(w=>w.Name==order.country);
        }




    }
}