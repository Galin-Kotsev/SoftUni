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
        
        public string RevealPrivateMethods(string investigatedClass)
        {

            StringBuilder stringBuilder = new StringBuilder();

            var classType 
                = Type.GetType(investigatedClass);

            Object classObject 
                = Activator.CreateInstance(classType);

            MethodInfo[] methods 
                = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            stringBuilder.AppendLine($"All Private Methods of Class: {classType}");
            stringBuilder.AppendLine($"Base Class: {classObject.GetType().BaseType.Name}");

            foreach (var method in methods)
            {
                stringBuilder.AppendLine(method.Name);
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
