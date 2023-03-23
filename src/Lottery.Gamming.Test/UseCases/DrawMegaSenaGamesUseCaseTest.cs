using System.Collections.Generic;
using System.Linq;
using Lottery.Gamming.Domain.Models;

using Lottery.Gamming.Domain.UseCases;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Lottery.Gamming.Test.UseCases;

[TestClass]
public class DrawMegaSenaGamesUseCaseTest
{
    private static readonly int _quantityOfNumbers = 6;
    private readonly IDrawMegaSenaGames _drawMegaSenaGamesUseCase;

    public DrawMegaSenaGamesUseCaseTest()
    {
        Mock<ILogger<DrawMegaSenaGames>> mockLogger = new Mock<ILogger<DrawMegaSenaGames>>();
        _drawMegaSenaGamesUseCase = new DrawMegaSenaGames(mockLogger.Object);
    }


    [TestMethod]
    public void ShouldGenerateThreeGames()
    {
        int quantity = 3;
        List<LotteryGame> megaSenaGames = _drawMegaSenaGamesUseCase.Execute(quantity);
        megaSenaGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(3, megaSenaGames.Count);
    }

    [TestMethod]
    public void ShouldGenerateTwoGames()
    {
        int quantity = 2;
        List<LotteryGame> megaSenaGames = _drawMegaSenaGamesUseCase.Execute(quantity);
        megaSenaGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(2, megaSenaGames.Count);
    }

    [TestMethod]
    public void ShouldGenerateOneGames()
    {
        int quantity = 1;
        List<LotteryGame> megaSenaGames = _drawMegaSenaGamesUseCase.Execute(quantity);
        megaSenaGames.ForEach(game => Assert.AreEqual(_quantityOfNumbers, game.Numbers.Count));
        Assert.AreEqual(1, megaSenaGames.Count);
    }

    [TestMethod]
    public void ShouldNotContainSameNumbers()
    {
        int quantity = 1;
        List<LotteryGame> megaSenaGames = _drawMegaSenaGamesUseCase.Execute(quantity);
        Assert.AreEqual(false, megaSenaGames.Exists(game => HasDuplicates(game.Numbers)));
    }

    private bool HasDuplicates(List<int> numbers)
    {
        return numbers.Distinct().Count() != numbers.Count;
    }

}