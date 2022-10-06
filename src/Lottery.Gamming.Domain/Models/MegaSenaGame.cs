namespace Lottery.Gamming.Domain.Models;

public class MegaSenaGame : Game
{
    public MegaSenaGame(int finalNumber, int quantityOfNumbers)
    {
        _finalNumber = finalNumber;
        _quantityOfNumbers = quantityOfNumbers;
        Numbers = new List<int>();
    }

    public override List<int> Numbers { get; protected set; }
}