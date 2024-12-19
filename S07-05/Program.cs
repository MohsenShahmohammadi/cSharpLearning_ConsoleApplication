class BaseClase
{
    public int Id { get; }
    public DateTime CreateDate { get; }
    public BaseClase(int id,DateTime createDate)
    {
        Id = id;
        CreateDate = createDate;
    }
}
class Person:BaseClase
{
    public PersonType Type { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string FullName { get; }
    public Person(int id, DateTime createDate, PersonType type,string fName, string lName,string fullName=""):base(id,createDate)
    {
        Type= type;
        FirstName= fName;
        LastName= lName;
        FullName= type == 0 ? fName + ' ' + lName : fullName;
    }
}


class Address:BaseClase
{
    public Address(int id, DateTime createDate) : base(id, createDate)
    {
    }

    public string Titel { get;}
    public string PostalCode { get; }

}

class Customer : Person
{
    public Customer(int id, DateTime createDate, PersonType type, string fName, string lName, string fullName = "") : base(id, createDate, type, fName, lName, fullName)
    {
    }
}

enum PersonType
{
    person=0,
    company=1
}