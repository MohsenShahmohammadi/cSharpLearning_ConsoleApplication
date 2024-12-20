Person person = new Person();
//person.Id = 1;
//person.FirstName = "Ali";
//person.LastName = "Mohammadi";

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "reza";
customer.LastName = "rezaee";
customer.CustomerCode = "123";

person = customer;
Console.WriteLine(person.FirstName + " " + person.LastName + " ");

int num10 = 4;
Console.WriteLine((Season)(num10 % 4));

Employee employee = new Employee();
Supplier supplier = new Supplier();

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CustomerCode { get; set; }
}
class Employee : Person
{
    public DateTime StartDate { get; set; }
    public DateTime FinishDate { get; set; }
}
class Supplier : Person
{
    public string ManagerName { get; set; }
}

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter,
}