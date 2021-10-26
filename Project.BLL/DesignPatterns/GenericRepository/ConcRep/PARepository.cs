using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class PARepository : BaseRepository<ProductAttribute>
    {
        public override void Update(ProductAttribute item)
        {
            ProductAttribute guncellenecek = FirstOrDefault(x => x.ProductID == item.ProductID && x.AttributeID == item.AttributeID);
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            _db.Entry(guncellenecek).CurrentValues.SetValues(item);
            Save();
        }
    }
}
