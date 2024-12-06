//Calculator.desc();

//static class Calculator
//{
//    public static void desc()
//    {
//        Console.WriteLine("test");
//    }
//    public static void add(int numA, int numB)
//    {
//        Console.WriteLine($"{numA} + {numB} = {numA + numB}");
//    }
//     static void subtraction(int numA, int numB)
//    {
//        Console.WriteLine($"{numA} - {numB} = {numA - numB}");
//    }
//    static void multiPliction(int numA, int numB)
//    {
//        Console.WriteLine($"{numA} * {numB} = {numA + numB}");
//    }
//}

class Setting
{
    public static string Name { get; set; }
    public string Description { get; set; }
    public string SMSProviderToken { get; set; }
    public static int CountOfViewer { get; set; }
    public Setting(string name, string desc, string token)
    {
        Name = name;
        Description = desc;
        SMSProviderToken = token;
        CountOfViewer++;
    }
    static void getWebsiteInfo()
    {
        var result = "";
        Console.WriteLine("Your Website's info is: " + result);
    }
}