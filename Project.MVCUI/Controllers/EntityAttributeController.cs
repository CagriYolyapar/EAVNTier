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
    public class EntityAttributeController : Controller
    {
        EARepository _eaRep;

        public EntityAttributeController()
        {
            _eaRep = new EARepository();
        }
        // GET: EntityAttribute
        public ActionResult EntityAttributeList()
        {
            EAVM eavm = new EAVM
            {
                EntityAttributes = _eaRep.GetActives()
            };
            return View(eavm);
        }

        public ActionResult AddEntityAttribute()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEntityAttribute(EntityAttribute entityAttribute)
        {
            _eaRep.Add(entityAttribute);
            return RedirectToAction("EntityAttributeList");
        }
    }
}