
using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Answer1;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Sub-String Service.");

            while (SubString())
            {
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static bool SubString()
    {
        string? text;
        string? indexLength;
        int index;
        int length;
        
        do
        {
            Console.Write("Enter text only (a-z) or (A-Z): ");
            text = Console.ReadLine();

        } while (!IsValidText(text));

        do
        {
            Console.Write("Enter index and length separate by space: ");
            indexLength = Console.ReadLine();
        } while (!IsValidIndexAndLength(indexLength, out index, out length));

        var result = text?.Length < index + 1 ? "Error: StartIndex cannot be larger than length of string." : text?.Substring(index, length);
        Console.WriteLine(result);
        return true;
    }

    static bool IsValidText(string? input)
    {
        if (input?.Contains("exit")??false)
        {
            Environment.Exit(0);
        }

        Regex regex = new Regex("^[a-zA-Z]+$");

        if (input == null)
        {
            Console.WriteLine("Error: Input should not null!!!");
            return false;
        }

        if (!regex.IsMatch(input))
        {
            Console.WriteLine("Error: String contains non-alphabetical character(s).");
            return false;
        }

        return true;
    }

    static bool IsValidIndexAndLength(string? input, out int index, out int length)
    {
        index = 0;
        length = 0;
        string[]? inputArr = input?.Split(' ');

        if (inputArr?.Length != 2)
        {
            Console.WriteLine("Error: Input must contain exactly two numbers separated by a space.");
            return false;
        }

        if (!int.TryParse(inputArr[0], out index) || !int.TryParse(inputArr[1], out length))
        {
            Console.WriteLine("Error: Input must contain two valid integers separated by a space.");
            return false;
        }

        if (index < 0 || length < 0)
        {
            Console.WriteLine("Error: Number must be positive integer.");
            return false;

        }
        
        return true;
    }
}