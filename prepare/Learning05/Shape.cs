using System;
using static System.Console;

public abstract class Shape() {

    private string _color;

    // public Shape(string color) {
    //     _color = color;
    // }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    public virtual double GetArea() {
        throw Ex
    }

}