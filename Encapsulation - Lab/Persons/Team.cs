using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
		private string name;

		public string Name
		{
			get { return name; }
			private set { name = value; }
		}

		private List<Person> firstTeam;

		public IReadOnlyCollection<Person> FirstTeam
		{
			get { return this.firstTeam.AsReadOnly(); }
		}

		private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();

        }

        public IReadOnlyCollection<Person> ReserveTeam
		{
			get { return this.reserveTeam.AsReadOnly();}
		}

		public override string ToString()
		{
			return $"First team has {firstTeam.Count} players.{Environment.NewLine}Reserve team has {reserveTeam.Count} players.";
		}

		public void AddPlayer (Person person)
		{
			if (person.Age < 40)
			{
				firstTeam.Add(person);
			}
			else
			{
				reserveTeam.Add(person);
			}
		}
	}
}
