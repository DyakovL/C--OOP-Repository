using AuthorProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeTracker
{
    public class Tracker
    {

        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            StringBuilder sb = new StringBuilder();
            foreach (var method in type.GetMethods((BindingFlags)60))
            {
                AuthorAttribute[] attributes = method.GetCustomAttributes<AuthorAttribute>().ToArray();
                

                foreach (var attribute in attributes)
                {
                    sb.AppendLine($"{method.Name} is written by {attribute.Name}");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
