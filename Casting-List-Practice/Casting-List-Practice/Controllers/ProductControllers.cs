using Casting_List_Practice.Services;
using Casting_List_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice.Controllers
{
    internal class ProductControllers
    {
        private readonly IProductService _service;

        public ProductControllers()
        {
            _service = new ProductService();
        }

        public void GetAll()
        {
            var datas = _service.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + "  " + item.Price);
            }
        }


        public void GetById()
        {
            var data =  _service.GetById(2);

            Console.WriteLine(data.Name + "  " + data.Price);
        }


        public void Sort()
        {
            var datas = _service.GetByDescending();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + "  " + item.Price);
            }
        }
    }
}
