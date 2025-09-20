public class Fraction
{
    private int _top;
    private int _bottom;



    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }



    public void GetTop()
    {

    }

    public void SetTop(int top)
    {

    }

    public void GetBottom()
    {

    }

    public void SetBottom(int bottom)
    {

    }


    public string GetFractionString()
    {
        return "0";
    }

    public double GetDecimalValue()
    {
        return 0;
    }
}