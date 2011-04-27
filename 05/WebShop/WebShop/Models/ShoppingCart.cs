using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Linq;

namespace WebShop.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        private readonly IList<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public static ShoppingCart Current
        {
            get
            {
                var cart = HttpContext.Current.Session["Cart"] as ShoppingCart;
                if (null == cart)
                {
                    cart = new ShoppingCart();
                    HttpContext.Current.Session["Cart"] = cart;
                }
                return cart;
            }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ClearCart()
        {
            _products.Clear();
        }

        public decimal Total { get { return _products.Sum(p => p.Price); } }
    }
}