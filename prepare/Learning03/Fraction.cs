using System;
using System.Runtime.CompilerServices;
using static System.Console;

public class Fraction {
    // Constructors
    public Fraction() {
        Top = 1;
        Bottom = 1;
    }

    public Fraction(int top) {
        Top = top;
        Bottom = 1;
    }

    public Fraction(int top, int bottom) {
        Top = top;
        Bottom = bottom;
    }

    // Getters/Setters
    public int Top {
        get; set;}

    public int Bottom {
        get; set;}

    public string GetFractionString() {
        return $"{Top}/{Bottom}";
    }

    public double GetDecimalValue() {
        double myDouble = (double)Top / Bottom;
        return myDouble;
    }
}
