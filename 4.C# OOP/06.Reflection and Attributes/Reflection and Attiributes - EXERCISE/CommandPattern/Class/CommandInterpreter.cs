using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Class
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] commandArgs = args.Split();

            Assembly assembly = Assembly.GetEntryAssembly();

            Type cmdType 
                = assembly.GetTypes().FirstOrDefault(x => x.Name == $"{commandArgs[0]}Command");

            object cmdInstance 
                = Activator.CreateInstance(cmdType);

            MethodInfo methodInfo 
                = cmdType.GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(x => x.Name == "Execute");

            string result 
                = (string)methodInfo.Invoke(cmdInstance, new object[] { commandArgs.Skip(1).ToArray() });

            return result;
        }
    }
}
