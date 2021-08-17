﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartService _cartService;
        ICartSessionHelper _cartSessionHelper;
        IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);
            //helper kyullanarak session daki sepeti çekiyoruz
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart, product);
            //sepeti session a ekleriz
            _cartSessionHelper.SetCart("cart", cart);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);
            //helper kyullanarak session daki sepeti çekiyoruz
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFromCart(cart, productId);
            //sepeti session a ekleriz
            _cartSessionHelper.SetCart("cart",cart);
            return RedirectToAction("Index", "Product");
        }
    }
}
