//for (int i = 0; i <= 1000; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//    if (i > 200)
//    {
//        break;
//    }
//}


//int number = 100;
//for (int i = 10; i < number; i++)
//{
//    number += 1;
//    Console.WriteLine(number);
//}

int num = 0;
do
{
    Console.WriteLine("please enter a number lorger than 100 or type 'stop' for end app");
    var data = Console.ReadLine();

    if (data == "stop")
    {
        break;
    }
    if (!isNumberCheck(data))
    {
        continue;
    }
    num = int.Parse(data);
} while (num < 100);

Console.WriteLine("Finish Application");

bool isNumberCheck(string dataMethod)
{
    return dataMethod.All(Char.IsDigit);
}