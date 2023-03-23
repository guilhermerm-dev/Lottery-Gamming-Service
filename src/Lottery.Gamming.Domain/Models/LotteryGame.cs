namespace Lottery.Gamming.Domain.Models;

public abstract class LotteryGame
{
  private const int _initialNumber = 1;
  protected readonly Random _random;

  protected LotteryGame()
  {
    _random = new Random();
    Numbers = new List<int>();
  }

  public List<int> Numbers { get; }
  protected abstract int FinalNumber { get; set; }
  protected abstract int QuantityOfNumbers { get; set; }
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