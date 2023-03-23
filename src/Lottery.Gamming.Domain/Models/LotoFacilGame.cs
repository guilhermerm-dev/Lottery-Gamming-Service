namespace Lottery.Gamming.Domain.Models;

public class LotoFacilGame : LotteryGame
{
  private const int _finalNumber = 25;
  private const int _quantityOfNumbers = 15;
  public LotoFacilGame()
  {
    FinalNumber = _finalNumber;
    QuantityOfNumbers = _quantityOfNumbers;
  }

  protected override int FinalNumber { get; set; }
  protected override int QuantityOfNumbers { get; set; }
}