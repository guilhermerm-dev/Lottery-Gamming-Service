namespace Lottery.Gamming.Domain.Models;

public class LotteryGame
{
    public LotteryGame(int finalNumber, int quantityOfNumbers)
    {
        _finalNumber = finalNumber;
        _quantityOfNumbers = quantityOfNumbers;
        _random = new Random();
        Numbers = new List<int>();
    }

    protected readonly int _initialNumber = 1;
    protected int _finalNumber;
    protected int _quantityOfNumbers;
    protected readonly Random _random;
    public List<int> Numbers { get; }
    public virtual void DrawGame()
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