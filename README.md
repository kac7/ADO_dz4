<h2>Тема: Введение в LINQ</h2>
Есть коллекция пользовательских объектов типа Person.<br>
public class Person<br>
{<br>
public string Name { get; set; }<br>
public int Age { get; set; }<br>
public string City { get; set; }<br>
}<br>
List<Person> person = new List<Person>()<br>
{<br>
new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },<br>
new Person(){ Name = "Liza", Age = 18, City = "Moscow" },<br>
new Person(){ Name = "Oleg", Age = 15, City = "London" },<br>
new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },<br>
new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }<br>
};<br>
1) Выбрать людей, старших 25 лет.<br>
2) Выбрать людей, проживающих не в Киеве.<br>
3) Выбрать имена людей, проживающих в Киеве.<br>
4) Выбрать людей старших 35 лет с именем Sergey.<br>
5) Выбрать людей, проживающих в Москве.<br>


<h2>Тема: Операторы LINQ</h2>
class Employee<br>
{<br>
public int Id { get; set; }<br>
public string FirstName { get; set; }<br>
public string LastName { get; set; }<br>
public int Age { get; set; }<br>
public int DepId { get; set; }<br>
}<br>
class Department<br>
{<br>
public int Id { get; set; }<br>
public string Country { get; set; }<br>
public string City { get; set; }<br>
}<br>
class Program<br>
{<br>
static void Main()<br>
{<br>
List<Department> departments = new List<Department>()<br>
{<br>
new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },<br>
new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },<br>
new Department(){ Id = 3, Country = "France", City = "Paris" },<br>
new Department(){ Id = 4, Country = "Russia", City = "Moscow" }<br>
};<br>
List<Employee> employees = new List<Employee>()<br>
{<br>
new Employee()<br>
{ Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },<br>
new Employee()<br>
{ Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },<br>
new Employee()<br>
{ Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },<br>
new Employee()<br>
{ Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },<br>
new Employee()<br>
{ Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },<br>
new Employee()<br>
{ Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },<br>
new Employee()<br>
{ Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 }<br>
};
}
}
1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.<br>
2) Вывести список стран без повторений.<br>
3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.<br>
4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года<br>

<h2>Тема: Операторы LINQ</h2>
class Employee<br>
{<br>
public int Id { get; set; }<br>
public string FirstName { get; set; }<br>
public string LastName { get; set; }<br>
public int Age { get; set; }<br>
public int DepId { get; set; }<br>
}<br>
class Department<br>
{<br>
public int Id { get; set; }<br>
public string Country { get; set; }<br>
public string City { get; set; }<br>
}<br>
class Program<br>
{<br>
static void Main()<br>
{<br>
List<Department> departments = new List<Department>()<br>
{<br>
new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },<br>
new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },<br>
new Department(){ Id = 3, Country = "France", City = "Paris" },<br>
new Department(){ Id = 4, Country = "Russia", City = "Moscow" }<br>
};<br>
List<Employee> employees = new List<Employee>()<br>
{<br>
new Employee() {Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2},<br>
new Employee() {Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1},<br>
new Employee() {Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3},<br>
new Employee() {Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2},<br>
new Employee() {Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4},<br>
new Employee() {Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2},<br>
new Employee() {Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4}<br>
};
}
}<br>
1) Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине. Выполнить запрос немедленно.<br>
2) Отсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName, LastName, Age. <br>
Выполнить запрос немедленно.<br>
3) Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке.<br>