﻿using Lab7AdvNET.Models;

namespace Lab7AdvNET;

public class Menu
{
    public static List<string> Results = new List<string>();
    public static void RunApp()
    {
        int input = 0;
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Calculator!");
            Console.WriteLine("1.Calculate\n2.See all results\n3.Exit");
            int.TryParse(Console.ReadLine(), out input);
            switch (input)
            {
                case 1:
                    Calculate();
                    break;
                case 2:
                    PrintAllResults();
                    break;
                case 3:
                    isRunning = false;
                    break;
            }
        }
    }

    public static void Calculate()
    {
        Console.Write("Choose the first number: ");
        var first = Console.ReadLine();
        Console.Write("\nChoose the second number: ");
        var second = Console.ReadLine();
        Console.WriteLine("Choose an option below");
        Console.WriteLine("1.Addition\n2.Subtraction\n3.Division");
        int.TryParse(Console.ReadLine(), out int input);

        switch (input)
        {
            case 1:
                Calculator add = new Addition(first, second);
                add.Run();
                break;
            case 2:
                Calculator sub = new Subtraction(first, second);
                sub.Run();
                break;
            case 3:
                Calculator div = new Division(first, second);
                div.Run();
                break;
        }
    }
    

    public static void PrintAllResults()
    {
        foreach (var result in Results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine("Press ENTER to return to menu");
        Console.ReadLine();
    }
}