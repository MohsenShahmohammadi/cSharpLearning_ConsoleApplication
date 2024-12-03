
using Domain.General;

var student = new Person("Ali", "Rezaee");
Console.WriteLine(student.FullName);



namespace Domain.General
{
    class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string NationalCode;
        public string FullName;

        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
            FullName = fname + " " + lname;
        }
    }
}