//Animal animal = new Animal()
//{
//    Id = 1,
//    Name="Dog",
//    AvrageLive=60
//};
//animal.FullDescription();

Animal animal2 = new Animal(1, "Dog", 60);

Dog dog = new Dog(2, "Shitzo", 80);
dog.FullDescription();
dog.testMethod();


public class Animal
{
    public int Id { get; }
    public string Name { get; }
    public int AvrageLive { get; }
    private DateTime createDate;
    public Animal(int id,string name,int avgLive)
    {
        Id = id;
        Name = name;
        AvrageLive= avgLive;
        createDate = DateTime.Now;
    }

    public void FullDescription()
    {
        Console.WriteLine($"{Name} usually live about {AvrageLive} month(s)");
    }
    private void showInfo()
    {
        Console.WriteLine($"Name: {Name} create Date: {createDate}");
    }
    protected void MakeSound(string message)
    {
        Console.WriteLine(message);
    }
}

public class Dog : Animal
{
    public Dog(int id, string name, int avgLive) : base(id, name, avgLive)
    {
    }
    public void testMethod()
    {
        MakeSound("dog pars");
    }

}

public class Snake : Animal
{
    public Snake(int id, string name, int avgLive) : base(id, name, avgLive)
    {
    }
    void testSnake()
    {
        MakeSound("snake ssssss");
    }

}