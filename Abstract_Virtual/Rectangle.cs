namespace Abstract_Virtual;

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public Rectangle(double width, double heigh)
    {
        Width = width;
        Height = heigh;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return "Rechteck mit einer Höhe von " + Height + " und Breite von " + Width + ".";
    }
}