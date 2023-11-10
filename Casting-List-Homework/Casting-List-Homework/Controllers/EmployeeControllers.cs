using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_List_Homework.Controllers
{
    public class EmployeeControllers
    {
        private readonly EmployeeService _service;

        public EmployeeControllers()
        {
            _service = new EmployeeService();
        }


        public void FilterEmployee()
        {
            
            DateTime startAge = new DateTime(1990, 01, 01);
            DateTime endAge = new DateTime(2000, 01, 01);

            var datas = _service.FilterEmployee(startAge, endAge);

            Console.WriteLine(datas.Length);
        }
    }
}
