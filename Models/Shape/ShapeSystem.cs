namespace Models.Shape.ShapeSystem;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw!!!");
    }
}

class Circle : Shape 
{
    public override void Draw()
    {
        Console.WriteLine("Circle drawed!!!");
    } 
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Rectangle drawed!!!");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Triangle drawed!!!");
    }
}
