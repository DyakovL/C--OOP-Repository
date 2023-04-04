using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Stealer
{
    public class Spy
    {


        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            //FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            //Type baseClass = classType.BaseType;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            //foreach (FieldInfo field in classFields)
            //{
            //    sb.AppendLine(field.Name);
            //}
            foreach (var item in classMethods)
            {
                sb.AppendLine(item.Name);
            }

            return sb.ToString().Trim();
        }


        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} must be private!");
            } 
            foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} must be public!");
            }

            return sb.ToString().Trim();
        }

        public string StealFieldInfo(string name, params string[] fieldNames)
        {
            Type classType = Type.GetType(name);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {name}");

            foreach ( var field in classFields.Where(x => fieldNames.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} - {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }
    }
}
