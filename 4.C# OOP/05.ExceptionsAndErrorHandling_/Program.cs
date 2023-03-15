namespace _05.ExceptionsAndErrorHandling_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            try
            {
                if (num < 0)
                {
                    throw new InvalidOperationException("Invalid number.");
                }

                Console.WriteLine(Math.Sqrt(num));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}