using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{

    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    #region

    [HttpGet("Addition/{firstNumber}/{secondNumber}")]
    public ActionResult Addition(string firstNumber, string secondNumber)
    {
        return BadRequest("Invalid Input");
    }

    #endregion
}