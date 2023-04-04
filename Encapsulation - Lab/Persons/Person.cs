using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			private set
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("First name cannot contain fewer than 3 symbols!\"");
				}
				firstName = value;
			}
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
            private set
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
				}
				lastName = value;
			}
		}

		private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Age	
		{
			get { return age; }
            private set
			{
				if (value <= 0 )
				{
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
				age = value;
			}
		}

		public override string ToString()
		{
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
	}
}
 