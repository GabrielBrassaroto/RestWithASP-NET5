using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumbmer}")]
    public IActionResult Sum(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var sum = ConverToDecimal(firstNumber) + ConverToDecimal(secondNumbmer);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }


    [HttpGet("division/{firstNumber}/{secondNumbmer}")]
    public IActionResult Division(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var division = ConverToDecimal(firstNumber) / ConverToDecimal(secondNumbmer);
            return Ok(division.ToString());
        }
        return BadRequest("Invalid Input");
    }



    [HttpGet("subtraction/{firstNumber}/{secondNumbmer}")]
    public IActionResult Subtraction(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var subtraction = ConverToDecimal(firstNumber) - ConverToDecimal(secondNumbmer);
            return Ok(subtraction.ToString());
        }
        return BadRequest("Invalid Input");
    }


    [HttpGet("multiplication/{firstNumber}/{secondNumbmer}")]
    public IActionResult Multiplication(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var multiplication = ConverToDecimal(firstNumber) * ConverToDecimal(secondNumbmer);
            return Ok(multiplication.ToString());
        }
        return BadRequest("Invalid Input");
    }



    [HttpGet("mean/{firstNumber}/{secondNumbmer}")]
    public IActionResult Mean(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var average = (ConverToDecimal(firstNumber) + ConverToDecimal(secondNumbmer)) / 2;
            return Ok(average.ToString());
        }
        return BadRequest("Invalid Input");
    }




    [HttpGet("square-root/{firstNumber}")]
    public IActionResult SquareRoot(string firstNumber)
    {

        if (IsNumeric(firstNumber))
        {
            var squareroot = Math.Sqrt((double)ConverToDecimal(firstNumber));
            return Ok(squareroot.ToString());
        }
        return BadRequest("Invalid Input");
    }




    public bool IsNumeric(string strNumber)
    {
        double number;
        bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, 
            System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return isNumber;
    }

    public decimal ConverToDecimal(string strNumber)
    {
        decimal decimalValue;
        if(decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

}
