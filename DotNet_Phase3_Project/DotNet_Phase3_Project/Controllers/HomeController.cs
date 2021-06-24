using DotNet_Phase3_Project.Models;
using DotNet_Phase3_Project.Services;
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
        IRepo<Product> _repo;
        public HomeController()
        {
            _product = new List<Product>();
            _repo = new MockProductRepo();
        }
        public ActionResult Index()
        {
    
            return View(_repo.GetAll());
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