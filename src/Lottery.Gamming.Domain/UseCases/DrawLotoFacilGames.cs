using Lottery.Gamming.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Lottery.Gamming.Domain.UseCases;

public class DrawLotoFacilGames : IDrawLotoFacilGames
{
    private static readonly int _finalNumber = 25;
    private static readonly int _quantityOfNumbers = 15;

    private readonly ILogger<DrawLotoFacilGames> _logger;

    public DrawLotoFacilGames(ILogger<DrawLotoFacilGames> logger)
    {
        _logger = logger;
    }

    public List<Game> Execute(int quantity)
    {
        List<Game> games = new List<Game>();
        for (int i = 0; i < quantity; i++)
        {
            LotoFacilGame lotoFacilGame = new LotoFacilGame(_finalNumber, _quantityOfNumbers);
            lotoFacilGame.DrawGames();
            games.Add(lotoFacilGame);
        }
        _logger.LogInformation($"Successfully generate {quantity} loto facil games!");
        return games;
    }
}