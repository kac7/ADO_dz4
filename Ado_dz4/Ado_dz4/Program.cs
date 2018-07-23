using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_dz4
{
    class Program
    {
        //1) Выбрать людей, старших 25 лет.
        //2) Выбрать людей, проживающих не в Киеве.
        //3) Выбрать имена людей, проживающих в Киеве.
        //4) Выбрать людей старших 35 лет с именем Sergey.
        //5) Выбрать людей, проживающих в Москве.
        static void Main(string[] args)
        {
            
            List<Person> person = new List<Person>
            {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
            new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
            };

            //1
            Console.WriteLine("Выбрать людей, старших 25 лет.");
            var result = person.Where(p => p.Age > 25);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Age}, {item.City}" );
            }
            Console.WriteLine();
            //2
            Console.WriteLine("Выбрать людей, проживающих не в Киеве.");
            result = person.Where(p => p.City != "Kyiv");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Age}, {item.City}");
            }
            Console.WriteLine();
            //3
            Console.WriteLine("Выбрать имена людей, проживающих в Киеве.");
            var result1 = person.Where(p => p.City == "Kyiv").Select(p => p.Name);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //4
            Console.WriteLine("Выбрать людей старших 35 лет с именем Sergey.");
            result = person.Where(p => p.Name == "Sergey" && p.Age > 35);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Age}, {item.City}");
            }
            Console.WriteLine();
            //5
            Console.WriteLine("Выбрать людей, проживающих в Москве.");
            result = person.Where(p => p.City == "Moscow");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Age}, {item.City}");
            }
            Console.WriteLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
