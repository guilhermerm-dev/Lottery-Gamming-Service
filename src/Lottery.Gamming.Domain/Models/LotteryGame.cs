namespace Lottery.Gamming.Domain.Models;

public abstract class LotteryGame
{
    protected LotteryGame()
    {
        _random = new Random();
        Numbers = new List<int>();
    }

    protected readonly int _initialNumber = 1;
    protected abstract int FinalNumber {get; set;}
    protected abstract int QuantityOfNumbers {get; set;}
    protected readonly Random _random;
    public List<int> Numbers { get; }
    public virtual void DrawGame()
    {
        for (int i = 0; i < QuantityOfNumbers; i++)
        {
            int number = _random.Next(_initialNumber, FinalNumber);
            if (Numbers.Contains(number))
            {
                while (Numbers.Contains(number))
                {
                    number = _random.Next(_initialNumber, FinalNumber);
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