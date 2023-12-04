using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JenkinDemoProject.Models;
namespace JenkinDemoProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductModel model = new ProductModel();
            model.ProductId = 100;
            model.ProductName = "ABC";
            return View();
        }
    }
}