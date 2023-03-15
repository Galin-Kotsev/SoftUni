namespace _05.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int numberOfExceptions = 0;
            while (numberOfExceptions < 3)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string param = tokens[1];
                try
                {
                    switch (command)
                    {
                        case "Replace":
                            int newElement = int.Parse(tokens[2]);
                            nums[int.Parse(param)] = newElement;
                            break;
                        case "Show":
                            Console.WriteLine(nums[int.Parse(param)]);
                            break;
                        case "Print":
                            int startIndex = int.Parse(param);
                            int endIndex = int.Parse(tokens[2]);
                            List<int> newNums = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                newNums.Add(nums[i]);
                            }
                            Console.WriteLine(String.Join(", ", newNums));
                            break;
                        default:
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    numberOfExceptions++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (FormatException)
                {
                    numberOfExceptions++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}