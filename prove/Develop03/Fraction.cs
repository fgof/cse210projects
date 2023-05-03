using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;

    }
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }
    public string GetFraction()
    {
        string display = $"{_topNumber}/{_bottomNumber}"; 
        return display;
    }
    public double DecimalAmount()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }

}