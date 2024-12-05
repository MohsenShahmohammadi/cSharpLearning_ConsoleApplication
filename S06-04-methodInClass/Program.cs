Person person= new Person();
person.Print("mohammad");
person.Print("Ali", "1245544");



class Person
{
    public int Id;
    public string FirstName;
    public string LastName;
    public string NationalCode;

    //public void Print(string name) => Console.WriteLine(name);

    public void Print(string name,string nationalCode = "")
    {
        if (nationalCode == "")
        {
            Console.WriteLine(name);
        }
        else
        {
            Console.WriteLine("Name: "+name+" nationalCode: "+nationalCode);
        }
    }


    string getPersonCode(string Id)
    {
        /*******  search ****/
        var nationalCode = "00007666548";
        Print("Ali");
        return nationalCode;
    }
}