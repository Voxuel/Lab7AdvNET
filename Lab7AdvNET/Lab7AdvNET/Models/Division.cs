
namespace Lab7AdvNET.Models;

public class Division : Calculator
{
    public override float Calculate(Tuple<float, float> numbers)
    {
        numbers.Deconstruct(out float x, out float y);
        return (y == 0) ? x : x / y;
    }
    
    public Division(string x, string y) : base(x, y)
    {
    }
}