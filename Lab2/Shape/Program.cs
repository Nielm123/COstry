
abstract class Shape
{
    int x = 0;
    int y = 0;
    int width = 0;
    int height = 0;
    public virtual void draw()
    {

    }
}

class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Rysuje kwardat");
    }
}
class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Rysuje trujkont");
    }
}
class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Rysuje kulko");
    }
}
class zad1
{
    static void Main(string[] args)
    {
        List <Shape> lista = new List<Shape>();
        Circle c = new Circle();
        Triangle t = new Triangle();
        Rectangle r = new Rectangle();
        lista.Add(c);
        lista.Add(t);   
        lista.Add(r);
        foreach (Shape shape in lista)
        {
            shape.draw();
        }
    }
}