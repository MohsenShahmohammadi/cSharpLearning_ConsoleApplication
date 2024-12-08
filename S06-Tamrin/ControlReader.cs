
namespace S06_Tamrin;

public static class ControlReader
{
    public static int ReadInteger(string message)
    {
        int resultl;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out resultl));

        return resultl;
    }
}
