//Animal animal=new Animal();
Dog dog = new Dog(1,"Shitzo",50);
dog.FullDescription();
dog.MakeSound();

public abstract class Animal
{
    public int Id { get; }
    public string Name { get; }
    public int AvrageLive { get; }
    private DateTime createDate=DateTime.Now;

    public Animal(int id,string name,int aveg)
    {
        Id = id;
        Name = name;
        AvrageLive = aveg;
    }

    public void FullDescription()
    {
        Console.WriteLine($"{Name} usually live about {AvrageLive} month(s)");
    }
    public abstract void MakeSound();

}

public class Dog : Animal
{
    public Dog(int id, string name, int aveg) : base(id, name, aveg)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("vagh vagh");
    }
}

