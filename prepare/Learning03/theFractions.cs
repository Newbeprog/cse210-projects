using System; 
/*
Encapsulation Learning Activity 
Write a program using encapsulation/constructors to write fractions
Kamas Peterson 
(c) 2023
*/
public class Fraction
{
    private int _kpNumerator; 
    private int _kpDenominator;

    public Fraction()
    {
        _kpNumerator = 1; 
        _kpDenominator = 1; 
    }

    public Fraction(int wholeNumber)
    {
        _kpNumerator = wholeNumber;
        _kpDenominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _kpNumerator = top; 
        _kpDenominator = bottom;
    }
    
    public string GetFractionString()
    {
        string text = $"{_kpNumerator}/{_kpDenominator}";
        return text; 
    }
    
    public double GetDecimalValue()
    {
        return (double)_kpNumerator / (double)_kpDenominator;
    }
}