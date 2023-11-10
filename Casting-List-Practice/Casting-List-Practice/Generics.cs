using Casting_List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Practice
{
    internal class Generics<T> where T : BaseEntity
    {
        private  T[] _list;

        public Generics()
        {
            _list = new T[0];
        }


        public T[] Add(T item)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = item;
            return _list;
        }

        public T[] ShowAll()
        {
            return _list;
        }

        public T[] GetById(int id)
        {
            var search = _list.Where(m => m.Id == id).ToArray();
            return search;
        }


        public void delete(int id)
        {

            _list = _list.Where(x => x.Id != id).ToArray();

        }
    }
}
