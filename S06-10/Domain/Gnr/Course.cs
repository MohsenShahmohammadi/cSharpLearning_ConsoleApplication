
namespace Domain.Gnr;

public class Course
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }

    public Course(int id,string name,string descr)
    {
        Id = id;
        Name = name;
        Description = descr;
    }
}
