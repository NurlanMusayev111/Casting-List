using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice
{
    internal class LessThanZeroException : Exception
    {

        public LessThanZeroException() : this("Menfi ededin faktoriali ola bilmez!")
        {
            
        }

        public LessThanZeroException(string msj) : base(msj) 
        {
            
        }
    }
}
