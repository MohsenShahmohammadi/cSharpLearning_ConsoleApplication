using static S06_Tamrin.ResultStatus;

namespace S06_Tamrin;

public class Guessing
{
    private readonly Card _card;
    private const int InitialTried = 3;
    public Guessing(Card card)
    {
        _card = card;
    }

    public ResaultCode Play()
    {
        var resault = _card.setNumber();
        var remainCounter = InitialTried;
        Console.WriteLine("I have 10 card, I selected one cart between in there.");
        Console.WriteLine($"You can wrong for {InitialTried} time.");
        while (remainCounter > 0)
        {
            var input = ControlReader.ReadInteger("Enter a Number");
            if (input == resault)
            {
                return ResaultCode.Win;
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }

            remainCounter--;
        }
        return ResaultCode.Loss;
    }
}
