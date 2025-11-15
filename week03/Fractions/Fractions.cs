public class Fraction
{
    private int _top;
    private int _bottom;

    // 1) No-argument constructor -> 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2) One-argument constructor -> top/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3) Two-argument constructor -> top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom == 0 ? 1 : bottom; // simple guard to avoid divide by zero
    }

    // Getters
    public int GetTop() => _top;
    public int GetBottom() => _bottom;

    // Setters
    public void SetTop(int top) => _top = top;
    public void SetBottom(int bottom) => _bottom = bottom == 0 ? 1 : bottom;

    // Returns "a/b"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value as double
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
