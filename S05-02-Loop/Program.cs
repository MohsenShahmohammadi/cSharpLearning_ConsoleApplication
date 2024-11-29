Console.WriteLine("please enter current level?");
var a = Console.ReadLine();
int level = int.Parse(a);
int number = 0;

while (level < 20)
{
    level += 1;
    number++;
    Console.WriteLine("Next level is," + level.ToString());
}
Console.WriteLine("You have " + number.ToString() + " for complete course");