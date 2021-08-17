using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            throw new NotImplementedException();
        }

        public List<CartLine> List(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
