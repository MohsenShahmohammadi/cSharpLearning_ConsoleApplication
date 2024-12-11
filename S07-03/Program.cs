Dog dog = new Dog(1, "shetzo", 80);
//dog.MakeSound();
dog.FullDescription();
Console.WriteLine(dog.Name);

//Snake snake = new Snake(2, "Boa", 60);
//snake.MakeSound();

public class Animal
{
    public int Id { get; }
    public virtual string Name { get; }
    public int AvrageLive { get; }
    private DateTime createDate;
    public Animal(int id, string name, int avgLive)
    {
        Id = id;
        Name = name;
        AvrageLive = avgLive;
        createDate = DateTime.Now;
    }

    public void FullDescription()
    {
        Console.WriteLine($"{Name} usually live about {AvrageLive} month(s)");
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("An Animal sound");
    }
}

public class Dog : Animal
{
    public override string Name
    {
        get
        {
            return base.Name + " the dog";
        }
    }
    public Dog(int id, string name, int avgLive) : base(id, name, avgLive)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("Vagh vagh");
    }

}

public class Snake : Animal
{
    public Snake(int id, string name, int avgLive) : base(id, name, avgLive)
    {
    }

}