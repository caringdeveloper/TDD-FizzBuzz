using FizzBuzz.Interfaces;
using System;

namespace FizzBuzz;

class FizzBuzzHost : IFizzBuzzHost
{
    private readonly IFizzBuzzService fizzBuzzService;

    public FizzBuzzHost(IFizzBuzzService fizzBuzzService)
    {
        this.fizzBuzzService = fizzBuzzService;
    }

    public void Run(string[] args)
    {
        if (args.Length != 1)
            throw new ArgumentException("You need to provide the input number and the input number only");

        if (!int.TryParse(args[0], out var input))
            throw new ArgumentException("You must provide an integer number as input");

        var result = this.fizzBuzzService.DoFizzBuzz(input);
        Environment.Exit(0);
    }
}