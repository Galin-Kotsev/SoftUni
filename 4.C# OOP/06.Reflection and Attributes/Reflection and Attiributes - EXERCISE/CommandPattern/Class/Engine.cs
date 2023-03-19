using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Class
{
    public class Engine : CommandInterpreter,IEngine,ICommandInterpreter
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string command;
            while (true)
            {
                command = Console.ReadLine();
                string result = commandInterpreter.Read(command);
                Console.WriteLine(result);
            }
        }
    }
}
