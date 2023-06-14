using Lab7AdvNET.Models;

namespace Lab7AdvNET.Test;

public class InputTests
{
    [Fact]
    public void ReceiveCorrectInputNumbers_ShouldReturnNewTupleWithParsedNumbers()
    {
        var calc = new Calculator("15", "34");

        var expected = new Tuple<float, float>(15, 34);
        var result = calc.Input(calc.X, calc.Y);
        
        Assert.Equal(expected,result);
    }

    [Fact]
    public void ReceiveWrongDataTypeAsInput_ShouldReturnErrorMessage()
    {
        var calc = new Calculator("15", "number");
        var sw = new StringWriter();
        Console.SetOut(sw);
        var expected = "\nWrong input type try again\r\n";

        calc.Input(calc.X, calc.Y);
        string result = sw.ToString();
        
        Assert.Equal(expected,result);
    }
}