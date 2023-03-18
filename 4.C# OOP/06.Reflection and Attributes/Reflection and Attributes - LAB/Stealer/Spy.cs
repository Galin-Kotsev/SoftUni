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
        
        public string StealFieldInfo(string investigatedClass, params string[] requestFields)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | 
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public); 

            Object haker = Activator.CreateInstance(classType);

            stringBuilder.AppendLine($"Class under investigation: {classType}");

            foreach (FieldInfo field in classFields
                .Where(x => requestFields.Contains(x.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} =  {field.GetValue(haker)}");
            }


            return stringBuilder.ToString();
        }
    }
}
