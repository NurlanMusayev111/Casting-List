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
    public class EmployeeService : IEmployeeService
    {

        private readonly AppDbContext _datas;

        public EmployeeService()
        {
            _datas = new AppDbContext();
        }
        public Employee[] FilterEmployee(DateTime start, DateTime end)
        {
            var result = _datas.Employees().Where(m => m.Birthday >start && m.Birthday <end && m.Salary > 2000).ToArray();
            
            return result;
        }
    }
}
