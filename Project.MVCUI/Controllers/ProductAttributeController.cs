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
    public class ProductAttributeController : Controller
    {
        PARepository _paRep;
        EARepository _eaRep;
        ProductRepository _pRep;
        public ProductAttributeController()
        {
            _paRep = new PARepository();
            _eaRep = new EARepository();
            _pRep = new ProductRepository();
        }

        public ActionResult ProductAttributeAdd(int id)
        {

            PAVM pavm = new PAVM
            {
                EntityAttributes = _eaRep.GetActives(),
                Product = _pRep.Find(id)

            };

            return View(pavm);
        }


        [HttpPost]

        public ActionResult ProductAttributeAdd(Product product,FormCollection collection)
        {
            foreach (string element in collection.GetValues("checkbox"))
            {
                int id = Convert.ToInt32(element);
                ProductAttribute pa = new ProductAttribute();
                pa.ProductID = product.ID;
                pa.AttributeID = id;
                _paRep.Add(pa);
            }

            return RedirectToAction("ProductDetail", new { id = product.ID });
        }
















        // GET: ProductAttribute
        public ActionResult ProductDetail(int id)
        {
            PAVM pavm = new PAVM
            {
               
                Product = _pRep.Find(id)

            };
            return View(pavm);
        }


        [HttpPost]
        public ActionResult ProductDetail(int id,FormCollection collection)
        {
            List<ProductAttribute> currentData = _paRep.Where(x=>x.ProductID == id);
            int indexer = 0;

            foreach (ProductAttribute element in currentData)
            {
                element.Value = collection.GetValues("valueName")[indexer];
                indexer++;
                _paRep.Update(element);
            }

            return RedirectToAction("ProductPage", new { id = id });
        }

        public ActionResult ProductPage(int id)
        {

            PAVM pavm = new PAVM
            {
                Product = _pRep.Find(id),
                ProductAttributes = _paRep.Where(x=>x.ProductID == id)
            };

            return View(pavm);

        }
    }
}