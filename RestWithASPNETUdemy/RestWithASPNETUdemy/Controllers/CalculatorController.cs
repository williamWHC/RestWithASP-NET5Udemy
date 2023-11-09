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

    [HttpGet("sun/{firstNumber}/{secondNumber}")]
    public ActionResult Addition(string firstNumber, string secondNumber)
    {
        if (IsNumber(firstNumber) && IsNumber(secondNumber))
        {
            decimal sun = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sun.ToString());
        }

        return BadRequest("Invalid Input");
    }
   
    [HttpGet("sun/{firstNumber}/{secondNumber}")]
    public ActionResult Subtraction(string firstNumber, string secondNumber)
    {
        if (IsNumber(firstNumber) && IsNumber(secondNumber))
        {
            decimal sun = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
            return Ok(sun.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sun/{firstNumber}/{secondNumber}")]
    public ActionResult Multiplication(string firstNumber, string secondNumber)
    {
        if (IsNumber(firstNumber) && IsNumber(secondNumber))
        {
            decimal sun = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
            return Ok(sun.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sun/{firstNumber}/{secondNumber}")]
    public ActionResult Division(string firstNumber, string secondNumber)
    {
        if (IsNumber(firstNumber) && IsNumber(secondNumber))
        {
            decimal sun = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
            return Ok(sun.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("sun/{firstNumber}")]
    public ActionResult SquareRoot(string firstNumber)
    {
        if (IsNumber(firstNumber))
        {
            var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));
            return Ok(squareRoot.ToString());
        }
        return BadRequest("Invaled Input");
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

    #endregion
}