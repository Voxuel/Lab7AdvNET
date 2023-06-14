namespace Lab7AdvNET.Models;

public class Calculator
{
    public string X { get; set; }
    public string Y { get; set; }

    public Calculator()
    {
        
    }
    public Calculator(string x, string y)
    {
        X = x;
        Y = y;
    }

    public void Run()
    {
        PrintResult(Calculate(Input(X,Y)));
    }
    public Tuple<float, float> Input(string numX, string numY)
    {
        if (numX.Contains('.') || numY.Contains('.'))
        {
            Console.WriteLine("Only use comas as dividers for decimal points");
            Menu.RunApp();
        }
        float x = 0;
        float y = 0;
        try
        {
            x = float.Parse(numX);
            y = float.Parse(numY);
            return new(x, y);
        }
        catch (Exception)
        {
            Console.WriteLine("\nWrong input type try again");
        }

        return null;
    }

    public virtual float Calculate(Tuple<float, float> numbers)
    {
        return Calculate(numbers);
    }

    public void PrintResult(float result)
    {
        Type obj = GetType();
        Console.Clear();
        var output = $"The result is: ({result}) with given numbers " +
                     $"({X}) and ({Y}) and done with {obj.Name}\n";
        Console.Write(output);
        Menu.Results.Add(output);
    }
}