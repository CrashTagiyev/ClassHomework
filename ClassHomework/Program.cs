


using System;
using System.Runtime.CompilerServices;
using System.Security;

public class point
{
    public point() { }
    public point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }

    void showData()
    {

        Console.WriteLine(X);
        Console.WriteLine(Y);
    }
    public override string ToString()
    =>
$"X:{X}\nY:{Y}";

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public class counter
{
    public counter(int min, int max)
    {
        this.Min = min;
        this.Max = max;
        this.Current = min;
    }

    public int Min { get; set; }
    public int Max { get; set; }
    public int Current { get; set; }

    public void increment()
    {
        if (this.Current < this.Max) Current++;
    }
    public void Deccrement()
    {
        if (Current > this.Min) Current--;
    }
    public override string ToString()
    => $"Current:{Current}";
}

public class Fraction
{
    public Fraction(int numinator, int denominator)
    {
        Numerator = numinator;
        Denominator = denominator;
    }

    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public string Sum(Fraction Otherfraction)
    {
        int den = this.Denominator *Otherfraction.Denominator;
        int num = this.Numerator * Otherfraction.Denominator + Otherfraction.Numerator * this.Denominator;
        return $"Num:{num}\nDen:{den}";
    }
    public string substract(Fraction other)
    {
        int Den = this.Denominator * other.Denominator;
        int Num = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
        
        return $"Num:{Num}\nDen:{Den}";
    }
    public string Multiply(Fraction other)
    {
        int Num = this.Numerator * other.Numerator;
        int Den = this.Denominator * other.Denominator;

        return $"Num:{Num}\nDen:{Den}";
    }
    public string Divide(Fraction other)
    {


        int Num = this.Numerator * other.Denominator;
        int Den = this.Denominator * other.Numerator;

        return $"Num:{Num}\nDen:{Den}";
    }

    public override string ToString()
    => $"Num:{Numerator}\nDenom:{Denominator}";
}
internal class Program
{
    static void Main(string[] args)
    {
        //point point = new point(22, 13);
        //Console.WriteLine(point.ToString());

        //counter counter = new counter(0, 10);
        //counter.increment();
        //Console.WriteLine(counter.ToString());

        Fraction f1 = new Fraction(3, 4);
        Fraction f2 = new Fraction(5, 6);
        Console.WriteLine(f2.Sum(f1));

        //Console.WriteLine(f1.ToString());
    }
}