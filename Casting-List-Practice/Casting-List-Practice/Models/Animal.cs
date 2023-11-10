using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice.Models
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
