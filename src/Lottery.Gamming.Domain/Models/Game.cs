namespace Lottery.Gamming.Domain.Models;

public abstract class Game
{
    protected Game()
    {
        _random = new Random();
    }

    protected int _initialNumber = 1;
    protected int _finalNumber;
    protected int _quantityOfNumbers;
    protected readonly Random _random;
    public abstract List<int> Numbers { get; protected set; }
    public virtual void DrawGames()
    {
        for (int i = 0; i < _quantityOfNumbers; i++)
        {
            int number = _random.Next(_initialNumber, _finalNumber);
            if (Numbers.Contains(number))
            {
                while (Numbers.Contains(number))
                {
                    number = _random.Next(_initialNumber, _finalNumber);
                }

                Numbers.Add(number);
            }
            else
            {
                Numbers.Add(number);
            }
        }
    }
}