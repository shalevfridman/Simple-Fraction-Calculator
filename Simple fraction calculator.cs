using System;

class Fraction
{
    private int numerator;
    private int denominator;
    private int wholeNumber;

    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
        wholeNumber = numerator / denominator;
        numerator %= denominator;
    }

    public int Numerator { get { return numerator; } set { numerator = value; } }
    public int Denominator { get { return denominator; } set { denominator = value; } }
    public int WholeNumber { get { return wholeNumber; } }

    public override string ToString()
    {
        if (wholeNumber > 0)
            return $"{wholeNumber} {numerator}/{denominator}";
        else
            return $"{numerator}/{denominator}";
    }

    public int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    public void Reduce()
    {
        int gcd = GCD(Math.Abs(numerator), denominator);
        numerator /= gcd;
        denominator /= gcd;
        wholeNumber = numerator / denominator;
        numerator %= denominator;
    }

    public Fraction Add(Fraction other)
    {
        int commonDenominator = denominator * other.denominator;
        int newNumerator = numerator * other.denominator + other.numerator * denominator;
        return new Fraction(newNumerator, commonDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int commonDenominator = denominator * other.denominator;
        int newNumerator = numerator * other.denominator - other.numerator * denominator;
        return new Fraction(newNumerator, commonDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = numerator * other.numerator;
        int newDenominator = denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Divide(Fraction other)
    {
        int newNumerator = numerator * other.denominator;
        int newDenominator = denominator * other.numerator;
        return new Fraction(newNumerator, newDenominator);
    }
}