public class Animal
{
    public int Id { get; }
    public string Name { get; }
    public int AvrageLive { get; }
    private DateTime createDate = DateTime.Now;

    public Animal(int id, string name, int aveg)
    {
        Id = id;
        Name = name;
        AvrageLive = aveg;
    }

    public void FullDescription()
    {
        Console.WriteLine($"{Name} usually live about {AvrageLive} month(s)");
    }
    public virtual void MakeSound() {
        Console.WriteLine("Make Sound");
    }

}

public class Dog : Animal
{
    public Dog(int id, string name, int aveg) : base(id, name, aveg)
    {
    }

    public override sealed void MakeSound()
    {
        Console.WriteLine("vagh vagh");
    }
}

public class Shitzo : Dog
{
    public Shitzo(int id, string name, int aveg) : base(id, name, aveg)
    {
    }
}

public class Bird : Animal
{
    public Bird(int id, string name, int aveg) : base(id, name, aveg)
    {
    }

    public override void MakeSound()
    {
        base.MakeSound();
    }
}

