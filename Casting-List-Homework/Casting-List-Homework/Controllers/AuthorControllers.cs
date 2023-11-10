using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Homework.Controllers
{
    public class AuthorControllers
    {
        private readonly AuthorService _authorService;

        public AuthorControllers()
        {
            _authorService = new AuthorService();
        }


        public void GetByAge()
        {   
            var datas = _authorService.GetByAge(40);

            foreach (var data in datas)
            {  
                 Console.WriteLine($"{data.Name} - {data.Surname}");   
            }
        }
    }
}
