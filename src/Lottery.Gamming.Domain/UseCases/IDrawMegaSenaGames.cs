using Lottery.Gamming.Domain.Models;

namespace Lottery.Gamming.Domain.UseCases;

public interface IDrawMegaSenaGames
{
    public List<Game> Execute(int quantity);
}
