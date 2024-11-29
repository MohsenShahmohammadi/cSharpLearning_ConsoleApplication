Console.WriteLine("Hi, welcome to calculator Application");
Console.WriteLine("please Enter First Number?");
var A = Console.ReadLine();
float numberA = 0;
if (!string.IsNullOrEmpty(A))
{
    numberA = float.Parse(A);
}
else
{
    Console.WriteLine("Input Number is wrong, please try again!");
    Environment.Exit(0);
}

var B = Console.ReadLine();
float numberB = 0;
if (!string.IsNullOrEmpty(B))
{
    numberB = float.Parse(B);
}
else
{
    Console.WriteLine("Input Number is wrong, please try again!");
    Environment.Exit(0);
}



Console.WriteLine("Press [A] for sum");
Console.WriteLine("Press [S] for Subtraction");
Console.WriteLine("Press [M] for Multipliction");
var operation = Console.ReadLine();

float result = 0;

if (operation?.ToUpper() == "A")
{
    result = numberA + numberB;
    Console.WriteLine(numberA.ToString() + " + " + numberB.ToString() + " = " + result.ToString());
}
else if (operation?.ToUpper() == "S")
{
    result = numberA - numberB;
    Console.WriteLine(numberA.ToString() + " - " + numberB.ToString() + " = " + result.ToString());
}
else if (operation?.ToUpper() == "M")
{
    result = numberA * numberB;
    Console.WriteLine(numberA.ToString() + " * " + numberB.ToString() + " = " + result.ToString());
}
else
{
    Console.WriteLine("Input letter is wrong, please try again!");
}


