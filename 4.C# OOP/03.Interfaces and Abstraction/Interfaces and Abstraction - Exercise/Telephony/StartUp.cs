namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string[] web = Console.ReadLine()
                .Split(" ")
                .ToArray();

            StationaryPhone stationary = new StationaryPhone();
            Smartphone smart = new Smartphone();

            foreach (string number in numbers)
            {
                bool isValid = true;

                foreach (char n in number)
                {
                    if (char.IsLetter(n))
                    {
                        Console.WriteLine("Invalid number!");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    if (number.Length > 7) 
                    {
                        Console.WriteLine(smart.Calling(number));
                    }
                    else
                    {
                        Console.WriteLine(stationary.Calling(number));
                    }
                }
            }

            foreach (string site in web) 
            {
                bool isValid = true;

                foreach (char c in site) 
                {
                    if (char.IsDigit(c))
                    {
                        Console.WriteLine("Invalid URL!");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(smart.Browsing(site));
                }
            }
        }
    }
}