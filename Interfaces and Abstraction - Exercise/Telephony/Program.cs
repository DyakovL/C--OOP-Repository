using System.Data.SqlTypes;
using System.Numerics;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICallable phone;

            foreach (var phoneNumber in phoneNumbers)
            {

                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone();

                }
                else
                {
                    phone = new StationaryPhone();

                }

                try
                {
                    Console.WriteLine(phone.Callable(phoneNumber));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable = new Smartphone();

            foreach (var url in urls)
            {

                try
                {
                    Console.WriteLine(browsable.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}