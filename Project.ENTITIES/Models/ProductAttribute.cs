using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductAttribute:BaseEntity
    {
        public int ProductID { get; set; }
        public int AttributeID { get; set; }
        public string Value { get; set; }


        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual EntityAttribute Attribute { get; set; }

    }
}
