using Lottery.Gamming.Domain.Models;

namespace Lottery.Gamming.Domain.UseCases;

public interface IDrawLotoFacilGames
{
    public List<Game> Execute(int quantity);
}
