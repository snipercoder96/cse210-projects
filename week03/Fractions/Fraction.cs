/*
Designing the Fractions class
*/

class Fraction
{   

    // Principle of Encapsulation
    private int _top;
    private int _bottom;

    // Create 3 constructors (This is known as Constructor overloading)

    // Constructor 1 to take no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }

    //Constructor 2 takes only 1 parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3 takes 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create Get and Setters
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
    }
}