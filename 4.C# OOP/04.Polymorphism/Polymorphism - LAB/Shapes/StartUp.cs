namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle= new(20);

            Console.WriteLine(circle.Draw());
        }
    }
}