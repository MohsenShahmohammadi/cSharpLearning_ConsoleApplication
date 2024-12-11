Employee emp = new Employee();
emp.FirstName = "Reza";

Customer customer = new Customer();
customer.CustomerCode = 123;

Person person = new Person();
person.Id = 1;
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Employee:Person
{
    public int EMPCode { get; set; }
    public DateTime StartWorkDate { get; set; }
}

public class Customer : Person
{
    public int CustomerCode { get; set; }
    public float MaxLimit { get; set; }
}