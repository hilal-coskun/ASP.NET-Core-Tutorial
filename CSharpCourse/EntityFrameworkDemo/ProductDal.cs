using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())//Dispose
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())//Dispose
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);//ontext üxerinden abone ol product için
                entity.State = EntityState.Added;//Durumu güncelledi diyre işaretlemek
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())//Dispose
            {
                var entity = context.Entry(product);//ontext üxerinden abone ol product için
                entity.State = EntityState.Modified;//Durumu güncelledi diyre işaretlemek
                context.SaveChanges();

            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())//Dispose
            {
                var entity = context.Entry(product);//ontext üxerinden abone ol product için
                entity.State = EntityState.Deleted;//Durumu güncelledi diyre işaretlemek
                context.SaveChanges();

            }
        }
    }
}
