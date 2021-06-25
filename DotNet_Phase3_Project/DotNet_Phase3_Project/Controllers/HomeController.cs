using DotNet_Phase3_Project.Models;
using DotNet_Phase3_Project.Services;
using DotNet_Phase3_Project.ViewModels;
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
        IRepo<Product> _ProductRepo;
        public HomeController()
        {
            _product = new List<Product>();
            _ProductRepo = new MockProductRepo();
        }
        // view homepage
        public ActionResult Index()
        {
    
            return View(_ProductRepo.GetAll());
        }

        // View add product page
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        // add route
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                Product item = new Product()
                {
                    ProductID = _ProductRepo.GetAll().Max(m => m.ProductID) + 1,
                    Category = product.Category,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    Description = product.Description

                };
                _ProductRepo.Add(item);
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
 
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

        public ActionResult Details(int id)
        {
            Product product = _ProductRepo.Get(id);
            Console.WriteLine(product);
            return View(product);
        }
        public ActionResult Order(int? id)
        {
            if(id!=null && id >= 0)
            {
                OrderViewModel model = new OrderViewModel()
                {
                    ProducttoOrder = _ProductRepo.Get((int)id),
                    OrderDetails = new Order()
                    {
                        ProductID = (int)id
                    }
                };
                return View(model);
            }
            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your SignIn page.";

            return View();
        }
    }
}