using Lottery.Gamming.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Lottery.Gamming.Domain.UseCases;

public class DrawMegaSenaGames : IDrawMegaSenaGames
{
    private readonly ILogger<DrawMegaSenaGames> _logger;

    public DrawMegaSenaGames(ILogger<DrawMegaSenaGames> logger)
    {
        _logger = logger;
    }

    public List<LotteryGame> Execute(int quantity)
    {
        List<LotteryGame> games = new List<LotteryGame>();
        for (int i = 0; i < quantity; i++)
        {
            MegaSenaGame megaSenaGame = new MegaSenaGame();
            megaSenaGame.DrawGame();
            games.Add(megaSenaGame);
        }
        _logger.LogInformation($"Successfully generate {quantity} mega sena games!");
        return games;
    }
}