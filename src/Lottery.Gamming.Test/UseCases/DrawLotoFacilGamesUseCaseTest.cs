using System.Collections.Generic;
using System.Linq;
using Lottery.Gamming.Domain.Models;

using Lottery.Gamming.Domain.UseCases;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Lottery.Gamming.Test.UseCases;

[TestClass]
public class DrawLotoFacilGamesUseCaseTest
{
    private static readonly int _quantityOfNumbers = 15;
    private readonly IDrawLotoFacilGames _drawLotoFacilGamesUseCase;

    public DrawLotoFacilGamesUseCaseTest()
    {
        Mock<ILogger<DrawLotoFacilGames>> mockLogger = new Mock<ILogger<DrawLotoFacilGames>>();
        _drawLotoFacilGamesUseCase = new DrawLotoFacilGames(mockLogger.Object);
    }


    [TestMethod]
    public void ShouldGenerateThreeGames()
    {
        int quantity = 3;
        List<Game> lotoFacilGames = _drawLotoFacilGamesUseCase.Execute(quantity);
        lotoFacilGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(3, lotoFacilGames.Count);
    }

    [TestMethod]
    public void ShouldGenerateTwoGames()
    {
        int quantity = 2;
        List<Game> lotoFacilGames = _drawLotoFacilGamesUseCase.Execute(quantity);
        lotoFacilGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(2, lotoFacilGames.Count);
    }

    [TestMethod]
    public void ShouldGenerateOneGames()
    {
        int quantity = 1;
        List<Game> lotoFacilGames = _drawLotoFacilGamesUseCase.Execute(quantity);
        lotoFacilGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(1, lotoFacilGames.Count);
    }

    [TestMethod]
    public void ShouldNotContainSameNumbers()
    {
        int quantity = 1;
        List<Game> lotoFacilGames = _drawLotoFacilGamesUseCase.Execute(quantity);
        Assert.AreEqual(false, lotoFacilGames.Exists(game => HasDuplicates(game.Numbers)));
    }

    private bool HasDuplicates(List<int> numbers)
    {
        return numbers.Distinct().Count() != numbers.Count;
    }

}