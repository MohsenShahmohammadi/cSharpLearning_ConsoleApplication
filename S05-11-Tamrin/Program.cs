Console.WriteLine("Hello");
Console.WriteLine("Welcome to Task Management Application");
Console.WriteLine(" ");

List<string> list = new List<string>();
List<string> doList = new List<string>();

var exit = "";
do
{
    Console.WriteLine("[A]dd task");
    Console.WriteLine("[D]o task");
    Console.WriteLine("[S]ee remain task");
    Console.WriteLine("[R]emove task");
    Console.WriteLine("[e]xit");
    var choose = Console.ReadLine();
    switch (choose?.ToUpper())
    {
        case "A":
            Console.WriteLine("Please Enter Your Task or Pless [B]ack to menu");
            var result = false;
            var existData = false;
            do
            {
                result = addData();
            } while (!result);
            break;
        case "D":
            existData = getData();
            if (existData)
            {
                Console.WriteLine("Please Enter Your completed Task or Pless [B]ack to menu");
                do
                {
                    result = doData();
                } while (!result);
            }

            break;
        case "S":
            existData = getData();
            if (existData)
            {
                Console.WriteLine($"You have {list.Count} task(s)");
            }
            break;
        case "R":
            existData = getData();
            if (existData)
            {
                Console.WriteLine("Please Enter Your remove Task or Pless [B]ack to menu");
                do
                {
                    result = removeData();
                } while (!result);
            }
            break;
        case "E":
            Console.WriteLine("Goodby");
            exit = "E";
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Command letter");
            break;
    }
} while (exit == "");

bool addData()
{
    var data = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(data))
    {
        if (data.ToUpper() == "B")
        {
            return true;
        }
        if (!list.Contains(data))
        {
            list.Add(data);
            return true;
        }
        else
        {
            Console.WriteLine("This task already exist, please insert new task");
        }

    }
    else
    {
        Console.WriteLine("Please add a valid task");
    }
    return false;
}

bool getData()
{
    if (list.Count != 0)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {list[i]}");
        }
        return true;
    }
    else
    {
        Console.WriteLine("No ant task in teh list");
        return false;
    }
}

bool doData()
{
    var value = Console.ReadLine();
    if (value?.ToUpper() == "B")
    {
        return true;
    }
    if (string.IsNullOrWhiteSpace(value) || !isSelectedDigit(value))
    {
        Console.WriteLine("Please Enter a valid Row number");
        return false;
    }
    int number = int.Parse(value);
    if (list.Count > number - 1)
    {
        doList.Add(list[number - 1]);
        list.RemoveAt(number - 1);
        return true;
    }
    else
    {
        Console.WriteLine("Please Enter a valid Row number");
        return false;
    }
}

bool removeData()
{
    var value = Console.ReadLine();
    if (value?.ToUpper() == "B")
    {
        return true;
    }
    if (string.IsNullOrWhiteSpace(value) || !isSelectedDigit(value))
    {
        Console.WriteLine("Please Enter a valid Row number");
        return false;
    }
    int number = int.Parse(value);
    if (list.Count > number - 1)
    {
        list.RemoveAt(number - 1);
        return true;
    }
    else
    {
        Console.WriteLine("Please Enter a valid Row number");
        return false;
    }
}
bool isSelectedDigit(string num)
{
    return num.All(Char.IsDigit);
}