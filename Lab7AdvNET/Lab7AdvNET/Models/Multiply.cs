namespace Lab7AdvNET.Models;

public class Multiply : Calculator
{
    public override float Calculate(Tuple<float, float> numbers)
    {
        return numbers.Item1 * numbers.Item2;
    }

    public Multiply(string x, string y) : base(x,y)
    {
        
    }
}