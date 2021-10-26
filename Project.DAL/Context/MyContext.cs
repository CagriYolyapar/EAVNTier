using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new EntityAttributeMap());
            modelBuilder.Configurations.Add(new ProductAttributeMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<EntityAttribute> Attributes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
    }
}
