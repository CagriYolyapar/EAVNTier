using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository _pRep;

        public ProductController()
        {
            _pRep = new ProductRepository();
        }
        // GET: Product
        public ActionResult ProductList()
        {
            ProductVM pvm = new ProductVM
            {
                Products = _pRep.GetActives()
            };
            return View(pvm);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _pRep.Add(product);
            return RedirectToAction("ProductList");
        }



    }
}