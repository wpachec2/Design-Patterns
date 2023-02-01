using System;
using System.Drawing;

namespace MVC_Countries___Design_Patterns
{
	public class CountryView
	{
        //Property
        public Country DisplayCountry { get; set; }

        //Constructor
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }

        //Method
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nFlag Color: ");
            foreach (string flagColor in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(flagColor);
                Console.WriteLine(flagColor);
            }
        }
    }
}

