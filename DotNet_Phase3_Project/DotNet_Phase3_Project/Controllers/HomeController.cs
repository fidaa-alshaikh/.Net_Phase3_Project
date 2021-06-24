using DotNet_Phase3_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_Phase3_Project.Controllers
{
    public class HomeController : Controller
    {

        List<Product> _product;
        public HomeController()
        {
            _product = new List<Product>();
            _product.Add(new Product()
            {
                ProductID = 0,
                Name = "Microsoft servise pro",
                Category = "LabTop",
                Price = 2000,
                Image = "https://res.cloudinary.com/dxfq3iotg/image/upload/v1562074043/234.png",
                Description = "Microsoft servise pro drgkm kfgk "
            });
            _product.Add(new Product()
            {
                ProductID = 1,
                Name = "Tosheba",
                Category = "LabTop",
                Price = 2000,
                Image = "https://res.cloudinary.com/dxfq3iotg/image/upload/v1562074043/234.png",
                Description = "vise pro drgkm kfgk "
            });
        }
        public ActionResult Index()
        {
    
            return View(_product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}