public class Cycling : Activity
{
    float _speed;

    public Cycling(string myDate, int myActLength, float mySpeed) : base (myDate, myActLength)
    {
        _speed = mySpeed;
    }

}