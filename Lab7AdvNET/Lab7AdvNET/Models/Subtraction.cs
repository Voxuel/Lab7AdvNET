namespace Lab7AdvNET.Models;

public class Subtraction : Calculator
{
    public override float Calculate(Tuple<float, float> numbers)
    {
        numbers.Deconstruct(out float x, out float y);
        var result = x - y;
        return result;
    }

    public Subtraction(string x, string y) : base(x, y)
    {
    }
}