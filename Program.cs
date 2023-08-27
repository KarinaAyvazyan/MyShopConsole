using System;
using MyShop;
using MyShop.Entities;

namespace MyShopConsole;


    internal class Program
    {
    static void Main(string[] args)
    {

        ShopDataContext context = new();
        Product product = new()
        {
           
            Discount = 1,
            CategoryId = 1,
            Name = "Test",
            Description = "Test smth",
            VendorId = 1,
  
        };


        context.Products.Add(product);

        var result = context.SaveChanges();


    }  
}
    
