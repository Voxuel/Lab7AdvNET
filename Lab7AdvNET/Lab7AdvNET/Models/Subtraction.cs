namespace Lab7AdvNET.Models;

public class Subtraction : Calculator
{
    public override float Calculate(Tuple<float, float> numbers)
    {
        return numbers.Item1 - numbers.Item2;
    }

    public Subtraction(string x, string y) : base(x, y)
    {
    }
}