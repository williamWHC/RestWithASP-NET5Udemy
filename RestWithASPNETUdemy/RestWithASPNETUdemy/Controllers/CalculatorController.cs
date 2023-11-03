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

    [HttpGet("sun/{firstNumber}/{secondNumber}")]
    public ActionResult Get(string firstNumber, string secondNumber)
    {
        if (IsNumber(firstNumber) && IsNumber(secondNumber))
        {
            decimal sun = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sun.ToString());
        }

        return BadRequest("Invalid Input");
    }
    private bool IsNumber(string strNumber)
    {
        double number;

        bool IsNumber = double.TryParse(
            strNumber, 
            System.Globalization.NumberStyles.Any, 
            System.Globalization.NumberFormatInfo.InvariantInfo, 
            out number);

        return IsNumber; 
    }

    private decimal ConvertToDecimal(string srtNumber)
    {
        decimal numberValue;
        if (decimal.TryParse(srtNumber, out numberValue))
        {
            return numberValue;
        }
        return 0;

    }

}