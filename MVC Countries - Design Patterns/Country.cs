using System;
namespace MVC_Countries___Design_Patterns
{
	public class Country
	{
		//Properties
		public string Name { get; set; }
		public string Continent { get; set; }
		public List<string> Colors { get; set; }
		

		//Constructors
		public Country(string _name, string _continent, List<string> _colors)
		{
			Name = _name;
			Continent = _continent;
			Colors = _colors;
		}
	}
}

