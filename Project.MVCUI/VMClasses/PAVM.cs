﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class PAVM
    {
        public Product Product { get; set; }
        public List<EntityAttribute> EntityAttributes { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }

    }
}