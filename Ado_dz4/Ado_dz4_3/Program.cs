using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_dz4_3
{
    class Program
    {
        //1) Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине.
        //Выполнить запрос немедленно.
        //2) Отсортировать сотрудников по возрастам, по убыванию.Вывести Id, FirstName, LastName, Age. 
        //Выполнить запрос немедленно.
        //3) Сгруппировать студентов по возрасту.Вывести возраст и сколько раз он встречается в списке.
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2},
                new Employee(){Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1},
                new Employee(){Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3},
                new Employee(){Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2},
                new Employee(){Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4},
                new Employee(){Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2},
                new Employee(){Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4}
            };

            //1
            Console.WriteLine("Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине.Выполнить запрос немедленно.");
            
            //var result = employees.Join(
            //                            departments,
            //                            emp => emp.DepId,
            //                            dep => dep.Id,
            //                            (emp, dep) => new {
            //                                fName = emp.FirstName,
            //                                lName = emp.LastName,
            //                                country = dep.Country
            //                            }).Where(e => e.country == "Ukraine").OrderBy(e => e.fName);

            var result = from emp in employees
                         join dep in departments on emp.DepId equals dep.Id
                         where dep.Country == "Ukraine" 
                         orderby emp.FirstName
                         select new
                         {
                             fName = emp.FirstName,
                             lName = emp.LastName,
                             country = dep.Country
                         };


            foreach (var item in result)
            {
                Console.WriteLine($"{item.fName} {item.lName}, {item.country}");
            }
            Console.WriteLine();

            //2
            Console.WriteLine("Отсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName, LastName, Age.");
            
            //var result2 = employees.OrderByDescending(e => e.Age);
            var result2 = from emp in employees
                          orderby emp.Age descending
                          select emp;

            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Id}. {item.FirstName} {item.LastName} - {item.Age}");
            }
            Console.WriteLine();

            //3
            Console.WriteLine("Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке.");
            var result3 = employees.GroupBy(e => e.Age);
            foreach (var item in result3)
            {
                Console.WriteLine($"Age: {item.Key} - {item.Count()}");
            }
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }
    }
    class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
