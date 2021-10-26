using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class EAVM
    {
        public EntityAttribute EntityAttribute { get; set; }
        public List<EntityAttribute> EntityAttributes { get; set; }
    }
}