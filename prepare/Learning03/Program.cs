using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Fraction!");

        Fraction frac1 = new Fraction();
        WriteLine(frac1.GetFractionString());
        WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(5);
        WriteLine(frac2.GetFractionString());
        WriteLine(frac2.GetDecimalValue());

        Fraction frac3= new Fraction(1, 5);
        WriteLine(frac3.GetFractionString());
        WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(1, 7);
        WriteLine(frac4.GetFractionString());
        WriteLine(frac4.GetDecimalValue());
    }
}