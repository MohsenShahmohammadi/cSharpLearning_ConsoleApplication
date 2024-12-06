Person person = new Person("Ali", "Rezaee") {
    Firstname = "Reza",
    Lastname="Moradi"
};

Person person2 = new Person()
{
    Firstname = "Mohammad",
    Lastname = "Hamidi"
};
Console.WriteLine(person.Fullname);

Console.WriteLine(person.Desc);

class Person
{
    public Guid id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; init; }
    public string Fullname { get; private set; }
    private DateTime createDate { get; set; }
    public int age { get; }

    public string Desc => "Your Fullname is: " + Firstname + " " + Lastname;

    public Person()
    {
        Fullname = Firstname + " " + Lastname;
    }
    public Person(string fname,string lname)
    {
        Firstname = fname; 
        Lastname = lname;
        Fullname = Firstname + " " + Lastname;
    }
}