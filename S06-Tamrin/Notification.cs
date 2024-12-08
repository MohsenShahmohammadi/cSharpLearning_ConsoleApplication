
using static S06_Tamrin.ResultStatus;

namespace S06_Tamrin;

public static class Notification
{
    public static void PrintNotification(ResaultCode status)
    {
        if (status == ResaultCode.Win)
        {
            Console.WriteLine("You Win!");
        }
        else
        {
            Console.WriteLine("You Loss.");
        }
    }
}
