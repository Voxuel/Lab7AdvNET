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
    
    
}