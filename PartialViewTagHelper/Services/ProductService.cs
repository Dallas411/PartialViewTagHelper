using PartialViewTagHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewTagHelper.Services
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            return new List<Product>
                       {
                           new Product(id:1, name: "Remote Car", price:9.99m, department:"Toys"),
                           new Product(id:2, name: "Boll Pen", price:2.99m, department:"Stationary"),
                           new Product(id:3, name: "Teddy Bear", price:6.99m, department:"Toys"),
                           new Product(id:4, name: "Tennis Boll", price:6.99m, department:"Toys"),
                           new Product(id:5, name: "Super Man", price:6.99m, department:"Toys"),
                           new Product(id:6, name: "Bikes", price:4.99m, department:"Toys"),
                           new Product(id:7, name: "Books", price:7.99m, department:"Stationary"),
                           new Product(id:8, name: "Mobiles", price:5.99m, department:"Toys"),
                           new Product(id:9, name: "Laptops", price:15.99m, department:"Toys"),
                           new Product(id:10, name: "Note Books", price:2.99m, department:"Stationary")
                       };
        }
    }
}
