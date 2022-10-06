namespace Lottery.Gamming.Domain.Models;

public class LotoFacilGame : Game
{
    public LotoFacilGame(int finalNumber, int quantityOfNumbers)
    {
        _finalNumber = finalNumber;
        _quantityOfNumbers = quantityOfNumbers;
        Numbers = new List<int>();
    }

    public override List<int> Numbers { get; protected set; }

}