//var customer = new Person();

//Console.WriteLine("My id is: "+customer.id);
//Console.WriteLine("My id firstname: " + customer.firstName);

//customer.firstName = "Ali";
//customer.lastName = "rezaee";
//Console.WriteLine("My id firstname: " + customer.firstName);

var student = new Person("Ali", "Rezaee");
Console.WriteLine(student.FirstName);
Console.WriteLine(student.LastName);
Console.WriteLine(student.FullName);


class Person
{
    public int Id;
    public string FirstName;
    public string LastName;
    public string NationalCode;
    public string FullName;

    public Person(string fname,string lname)
    {
        FirstName = fname;
        LastName = lname;
        FullName=fname+" "+ lname;
    }
}