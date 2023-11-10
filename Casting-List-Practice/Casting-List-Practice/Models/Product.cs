using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice.Models
{
    internal class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
