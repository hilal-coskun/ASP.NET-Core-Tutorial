using Core.Entites.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModels
{
    public class CartLine:IDomainModel//Sepet elemanı detayı
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
