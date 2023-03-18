using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {

        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] fields 
                = classType.GetFields(BindingFlags.Instance| BindingFlags.Static| BindingFlags.Public);

            MethodInfo[] methodPublic 
                = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            MethodInfo[] methodNonPublic
                = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in methodNonPublic.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have be public!");
            }

            foreach (var method in methodPublic.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have be private!");
            }

            return sb.ToString().Trim();
        }
    }
}
