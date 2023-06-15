using System.Collections;
using Lab7AdvNET.Models;

namespace Lab7AdvNET.Test;

public class CalculateTests
{
    [Theory]
    [InlineData("10","10",20)]
    [InlineData("23","5",28)]
    [InlineData("1","1",2)]
    [InlineData("-90","30",-60)]
    [InlineData("0","0",0)]
    public void CalculateAdditionWithCorrectNumbers_ShouldReturnCorrectResult(string x,string y, float exp)
    {
        Calculator calc = new Addition(x,y);

        var result = calc.Input(calc.X, calc.Y);
        var action = calc.Calculate(result);
        
        Assert.Equal(exp,action);
    }

    [Theory]
    [InlineData("3","9")]
    [InlineData("33","23")]
    [InlineData("49","-13")]
    [InlineData("0","0")]
    [InlineData("-40","30")]
    public void CalculatingNumbers_ShouldAddResultsToLog(string x,string y)
    {
        Calculator calc = new Addition(x, y);
        var input = calc.Input(calc.X, calc.Y);
        var result = calc.Calculate(input);
        calc.PrintResult(result);
        var expected = $"The result is: ({result}) with given numbers " +
                       $"({x}) and ({y}) and done with Addition\n";

        Assert.Contains(expected,Menu.Results);
    }

    // Testing to learn about exception testing, Would usually be handled with try/catch -
    // and not throw and exception.
    [Fact]
    public void TryingToDivideByZero_ShouldThrowDivideByZeroException()
    {
        Calculator calc = new Division("15", "0");

        Action act = () => calc.Calculate(calc.Input(calc.X, calc.Y));

        DivideByZeroException dze = Assert.Throws<DivideByZeroException>(act);
    }
    
    
}