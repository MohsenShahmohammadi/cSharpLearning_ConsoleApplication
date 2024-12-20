//int num=10;
//string title;
//Guid id;
//Person newPerson = new Person();

//Console.WriteLine("Message");

//Console.WriteLine(num is string);

Person person=new Person();
person.Id = 1;
person.Name = "Test";

Console.WriteLine(person is Customer);

Customer customer = new Customer();
person = customer;
Console.WriteLine(person is Customer);

Console.WriteLine(customer is Person);

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Customer : Person
{
    public string CustomerCode { get; set; }
}