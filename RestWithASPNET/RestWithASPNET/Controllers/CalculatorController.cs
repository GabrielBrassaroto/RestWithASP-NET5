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
    public IActionResult Get(string firstNumber, string secondNumbmer)
    {

        if (IsNumeric(firstNumber) && IsNumeric(secondNumbmer))
        {
            var sum = ConverToDecimal(firstNumber) + ConverToDecimal(secondNumbmer);
            return Ok(sum.ToString());
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
