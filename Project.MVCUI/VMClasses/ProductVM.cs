using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

    }
}