Console.WriteLine("How much do you read book per day?");
Console.WriteLine("Press [A] for less than 1 hour.");
Console.WriteLine("Press [B] for betweeb 1 and 2 hours.");
Console.WriteLine("Press [C] for betweeb 2 and 4 hours.");
Console.WriteLine("Press [D] for betweeb 4 and 6 hours.");
Console.WriteLine("Press [E] for upper than 6 hours.");

var result = Console.ReadLine();

switch (result.ToUpper())
{
    case "A":
        Console.WriteLine("Hello");
        notificationPrint("less than 1 hour");
        break;
    case "B":
        notificationPrint("betweeb 1 and 2 hours");
        break;
    case "C":
        notificationPrint("betweeb 2 and 4 hours");
        break;
    case "D":
        notificationPrint("betweeb 4 and 6 hours");
        break;
    case "E":
        notificationPrint("upper than 6 hours");
        break;
    default:
        Console.WriteLine("your input key is wrong!...");
        break;
}


void notificationPrint(string message)
{
    Console.WriteLine("thanks for answer my question. you read " + message + " evry day.");
}