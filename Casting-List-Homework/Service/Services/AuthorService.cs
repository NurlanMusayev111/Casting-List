using Domain.Data;
using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly AppDbContext _datas;

        public AuthorService()
        {
            _datas = new AppDbContext();
        }
        public Author[] GetByAge(int age)
        {
            var datas = _datas.Authors().Where(m => m.Age > age).ToArray();

            return datas;
        }
    }
}
