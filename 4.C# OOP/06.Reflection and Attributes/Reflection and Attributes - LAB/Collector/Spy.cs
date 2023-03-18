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
        
        public string CollectGettersAndSetters(string investigatedClass)
        {

            StringBuilder stringBuilder = new StringBuilder();

            var classType 
                = Type.GetType(investigatedClass);

            MethodInfo[] methods 
                = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);



            foreach (var method in methods.Where(x => x.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in methods.Where(x => x.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
