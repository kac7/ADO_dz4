using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_dz4_2
{
    class Program
    {
        //1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.
        //2) Вывести список стран без повторений.
        //3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.
        //4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года
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
                new Employee() { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 },
                //добавил студента из Киева, возраст которого превышает 23 года 
                //т.к. ни один студент не попадал в этот диапазон
                new Employee() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 2 }
            };
            //1
            Console.WriteLine("Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.");
            var result = employees.Join(departments,
                                        em => em.DepId,
                                        dep => dep.Id,
                                        (em, dep) => new {
                                            employeeFirstName = em.FirstName,
                                            employeeLastName = em.LastName,
                                            depCountry = dep.Country,
                                            depCity = dep.City}).Where(p=>p.depCountry == "Ukraine" && p.depCity != "Donetsk");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.employeeFirstName} {item.employeeLastName}, {item.depCountry} {item.depCity}");
            }
            Console.WriteLine();

            //2
            Console.WriteLine("Вывести список стран без повторений.");
            var result2 = departments.Select(d => d.Country).Distinct();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //3
            Console.WriteLine("Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.");
            var result3 = employees.Where(e => e.Age > 25).Take(3);
            foreach (var item in result3)
            {
                Console.WriteLine($"{item.Id}, {item.FirstName} {item.LastName}, {item.Age}");
            }
            Console.WriteLine();
            //4
            Console.WriteLine("Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года");
            var result4 = employees.Join(departments,
                                         emp => emp.DepId,
                                         dep => dep.Id,
                                         (emp, dep) => new
                                         {
                                             fName = emp.FirstName,
                                             lName = emp.LastName,
                                             age = emp.Age,
                                             city = dep.City
                                         }).Where(e => e.city == "Kyiv" && e.age > 23);

            foreach (var item in result4)
            {
                Console.WriteLine($"{item.fName} {item.lName} - {item.age}, {item.city}");
            }
            Console.WriteLine();
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
