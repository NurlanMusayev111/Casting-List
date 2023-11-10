using Casting_List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice.Data
{
    internal static class AppDbContext
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Iphone",
                    Price = 3000
                },

                new Product()
                {
                    Id = 2,
                    Name = "Samsung",
                    Price = 2200
                },

                new Product()
                {
                    Id = 3,
                    Name = "Nokia",
                    Price = 300
                }
            };
        }
    }
}
