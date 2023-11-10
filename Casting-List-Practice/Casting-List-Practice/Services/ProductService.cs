using Casting_List_Practice.Data;
using Casting_List_Practice.Models;
using Casting_List_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }

        public List<Product> GetByDescending()
        {
            return AppDbContext.Products().OrderByDescending(m => m.Price).ToList();
        }

        public Product GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(m => m.Id == id);
        }
    }
}
