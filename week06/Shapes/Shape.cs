using System.Drawing;

public class Shapes
{
    string _color;



    public Shapes(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }


    public void SetColor(string color)
    {
        _color = color;
    }


    public virtual double GetArea()
    {
        return .9192939495;
    }
   


}