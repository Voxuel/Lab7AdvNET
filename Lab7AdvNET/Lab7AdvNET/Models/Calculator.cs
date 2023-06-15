namespace Lab7AdvNET.Models;

// Class used as base for subclasses through polymorphism
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
    
    /// <summary>
    /// Executes sequence of methods for calculating input numbers.
    /// </summary>
    public void Run()
    {
        var converted = Input(X, Y);
        var result = Calculate(converted);
        PrintResult(result);
    }
    /// <summary>
    /// Handles input and converts to float datatype from string input in console.
    /// </summary>
    /// <param name="numX"></param>
    /// <param name="numY"></param>
    /// <returns>Tuple of floats to deconstruct in following methods</returns>
    public Tuple<float, float> Input(string numX, string numY)
    {
        if (numX.Contains('.') || numY.Contains('.'))
        {
            Console.WriteLine("Only use comas as dividers for decimal points");
            Menu.RunApp();
        }
        try
        {
            var x = float.Parse(numX);
            var y = float.Parse(numY);
            return new Tuple<float, float>(x, y);
        }
        catch (Exception)
        {
            Console.WriteLine("\nWrong input type try again");
        }

        return null;
    }
    /// <summary>
    /// Base for calculating
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public virtual float Calculate(Tuple<float, float> numbers)
    {
        return Calculate(numbers);
    }
    /// <summary>
    /// Prints the result and adds it to the log.
    /// Gets the current instance name for clean display in log and result.
    /// </summary>
    /// <param name="result (result after calculation)"></param>
    public void PrintResult(float result)
    {
        Type obj = GetType();
        var output = $"The result is: ({result}) with given numbers " +
                     $"({X}) and ({Y}) and done with {obj.Name}\n";
        Console.Write(output);
        Menu.Results.Add(output);
    }
}