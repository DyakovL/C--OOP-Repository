namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 20);
            Shape circle = new Circle(30);

            Console.WriteLine(circle.CalculateArea());
        }
    }
}