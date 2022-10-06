using Lottery.Gamming.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Lottery.Gamming.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LotteryGammingController : ControllerBase
{
    private readonly ILogger<LotteryGammingController> _logger;
    private readonly IDrawMegaSenaGames _drawMegaSenaGames;
    private readonly IDrawLotoFacilGames _drawLotoFacilGames;

    public LotteryGammingController(ILogger<LotteryGammingController> logger, IDrawMegaSenaGames drawMegaSenaGames, IDrawLotoFacilGames drawLotoFacilGames)
    {
        _logger = logger;
        _drawMegaSenaGames = drawMegaSenaGames;
        _drawLotoFacilGames = drawLotoFacilGames;
    }

    [HttpGet("/lotofacil/{quantity:int}")]
    public ActionResult<object> drawLotofacilGames(int quantity)
    {
        _logger.LogInformation($"Generating {quantity} loto facil games");

        if (quantity > 0)
            return Ok(_drawLotoFacilGames.Execute(quantity));

        return BadRequest();
    }

    [HttpGet("/megasena/{quantity:int}")]
    public ActionResult<object> drawMegasSenaGames(int quantity)
    {
        _logger.LogInformation($"Generating {quantity} mega sena games");

        if (quantity > 0)
            return Ok(_drawMegaSenaGames.Execute(quantity));

        return BadRequest();
    }
}
