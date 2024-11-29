float total = 0;
int number = 0;

do
{
    Console.WriteLine("please enter your score");
    var a = Console.ReadLine();
    total += float.Parse(a);
    number++;
    Console.WriteLine("total score is " + total.ToString() + " now.");
} while (total < 1000);

float avg = total / number;
Console.WriteLine("Your avg is " + avg.ToString());
if (avg < 500)
{
    Console.WriteLine("Not Passed");
}
else
{
    Console.WriteLine("Passed");
}