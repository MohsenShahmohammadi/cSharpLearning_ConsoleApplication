
namespace S06_Tamrin;

public class Card
{
    private readonly Random _random;
    public Card(Random random)
    {
        _random = random;
    }
    public int setNumber()
    {
        return _random.Next(1, 11);
    }
}
