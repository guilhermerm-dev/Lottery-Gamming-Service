using Lottery.Gamming.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Lottery.Gamming.Domain.UseCases;

public class DrawMegaSenaGames : IDrawMegaSenaGames
{
    private static readonly int _finalNumber = 60;
    private static readonly int _quantityOfNumbers = 6;
    private readonly ILogger<DrawMegaSenaGames> _logger;

    public DrawMegaSenaGames(ILogger<DrawMegaSenaGames> logger)
    {
        _logger = logger;
    }

    public List<Game> Execute(int quantity)
    {
        List<Game> games = new List<Game>();
        for (int i = 0; i < quantity; i++)
        {
            MegaSenaGame megaSenaGame = new MegaSenaGame(_finalNumber, _quantityOfNumbers);
            megaSenaGame.DrawGames();
            games.Add(megaSenaGame);
        }
        _logger.LogInformation($"Successfully generate {quantity} mega sena games!");
        return games;
    }
}