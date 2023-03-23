namespace Lottery.Gamming.Domain.Models;

public class MegaSenaGame : LotteryGame
{
  private const int _finalNumber = 60;
  private const int _quantityOfNumbers = 6;
  public MegaSenaGame()
  {
    FinalNumber = _finalNumber;
    QuantityOfNumbers = _quantityOfNumbers;
  }
  protected override int FinalNumber { get; set; }
  protected override int QuantityOfNumbers { get; set; }
}