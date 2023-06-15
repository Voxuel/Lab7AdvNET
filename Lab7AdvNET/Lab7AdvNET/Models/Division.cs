
namespace Lab7AdvNET.Models;

public class Division : Calculator
{
    public override float Calculate(Tuple<float, float> numbers)
    {
        try
        {
            if (numbers.Item1 == 0 || numbers.Item2 == 0)
            {
                throw new DivideByZeroException();
            }

            return numbers.Item1 / numbers.Item2;
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
    }
    
    public Division(string x, string y) : base(x, y)
    {
    }
}