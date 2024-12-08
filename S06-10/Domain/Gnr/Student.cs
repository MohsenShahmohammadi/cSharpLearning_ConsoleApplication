
namespace Domain.Gnr;

public class Student
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public Student(int id,string fname,string lname)
    {
        Id = id;
        FirstName = fname;
        LastName = lname;
    }
}
