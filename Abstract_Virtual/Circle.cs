namespace Abstract_Virtual;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle (double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override string ToString()
    {
        return "Kreis mit einem Radius von " + Radius + ".";
    }
}