namespace _06.MoneyTransAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new Dictionary<int, double>();
            string[] accountsAsString = Console.ReadLine().Split(",");
            for (int i = 0; i < accountsAsString.Length; i++)
            {
                string[] accountDetails = accountsAsString[i].Split("-");
                int accountNumber = int.Parse(accountDetails[0]);
                double accountMoney = double.Parse(accountDetails[1]);
                bankAccounts.Add(accountNumber, accountMoney);
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] tokens = input.Split();
                    string command = tokens[0];
                    int bankAccount = int.Parse(tokens[1]);
                    double bankMoney = double.Parse(tokens[2]);

                    switch (command)
                    {
                        case "Deposit":
                            bankAccounts[bankAccount] += bankMoney;
                            Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
                            break;
                        case "Withdraw":
                            if (bankMoney > bankAccounts[bankAccount])
                            {
                                throw new InvalidOperationException("Insufficient balance!");
                            }
                            else
                            {
                                bankAccounts[bankAccount] -= bankMoney;
                                Console.WriteLine($"Account {bankAccount} has new balance: {bankAccounts[bankAccount]:f2}");
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Invalid command!");
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
    }
}