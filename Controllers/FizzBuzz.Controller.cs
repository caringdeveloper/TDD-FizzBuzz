using FizzBuzz.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly IFizzBuzzer fizzBuzzer;

    public FizzBuzzController(IFizzBuzzer fizzBuzzer)
    {
        this.fizzBuzzer = fizzBuzzer;
    }

    [HttpGet("{input}")]
    public ActionResult<string> GetFizzBuzz(int input)
    {
        var fizzBuzz = this.fizzBuzzer.DoFizzBuzz(input);
        return Ok(fizzBuzz);
    }
}
