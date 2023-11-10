using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext
    {
       public List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author
                {
                    Id = 1,
                    Age = 39,
                    Name = "Test1",
                    Surname = "txt1"
                },

                 new Author
                {
                    Id = 2,
                    Age = 49,
                    Name = "Test2",
                    Surname = "txt2"
                },

                  new Author
                {
                    Id = 3,
                    Age = 42,
                    Name = "Test3",
                    Surname = "txt3"
                }
            };
        }


       public List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "Nurlan",
                    Surname = "Musayev",
                    Salary = 4500,
                    Birthday = new(1998,07,21)
                },

                 new Employee
                {
                    Id = 2,
                    Name = "Nermin",
                    Surname = "Musayeva",
                    Salary = 3800,
                    Birthday = new(1994,06,12)
                },

                  new Employee
                {
                    Id = 3,
                    Name = "Gunel",
                    Surname = "Musayeva",
                    Salary = 1999,
                    Birthday = new(1992,02,23)
                }
            };
        }
    }
}
