Person person = new Person("Ali", "Rezaee");


class Person
{
    public int Id;
    public string FirstName;
    public string LastName;
    public string NationalCode;
    private string FullName;

    public Person()
    {
        FullName = FirstName + " " + LastName;
    }

    public Person(string firstName, string lastName)
    {
        FullName = firstName + " " + lastName;
        Console.WriteLine("FullName= " + FullName);
    }

    public Person (string firsname,string lastname,string nationalCode)
    {
        Console.WriteLine("National code is:" + nationalCode);
    }
   
}

namespace Service
{
    class PersonService
    {
        public void Print(string name) => Console.WriteLine(name);


        string getPersonCode(string Id)
        {
            /*******  search ****/
            var nationalCode = "00007666548";
            Print("Ali");
            return nationalCode;
        }
    }
}