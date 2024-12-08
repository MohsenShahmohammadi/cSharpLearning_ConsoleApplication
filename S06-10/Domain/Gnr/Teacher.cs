
namespace Domain.Gnr;

public class Teacher
{
    public int Id { get;  }
    public string Name { get;  }
    public DateTime StartWork { get; }
    public Teacher(int id, string name, DateTime startWork)
    {
        Id = id;
        Name = name;
        StartWork = startWork;
    }
}
