using System;
using System.Diagnostics.Metrics;

namespace MVC_Countries___Design_Patterns
{
	public class CountryController
	{
        public List<Country> CountriesDB = new List<Country>()
        {
            new Country("United States", "North America", new List<string> {"Red","White","Blue"}),
            new Country("Italy", "Europe", new List<string> {"Green","White","Red"}),
            new Country("Canada", "North America", new List<string> {"Red","White"}),
            new Country("Mexico", "South America", new List<string> {"Green","White","Red"}),
            new Country("Greece", "Europe", new List<string> {"White","Blue"}),
            new Country("China", "Asia", new List<string> {"Red","Yellow"}),
            new Country("Austrailia", "Oceania", new List<string> {"Blue","Red","White"}),
            new Country("Switzerland", "Europe", new List<string> {"Red","White"}),
            new Country("Egypt", "Africa", new List<string> {"Red","White","Black"}),
            new Country("Japan", "Asia", new List<string> {"White","Red"})
        };

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void CountryAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            bool restart = true;
            while (restart)
            {
                CountryListView clv = new CountryListView(CountriesDB);
                clv.Display();
                while (true)
                {
                    int result = int.Parse(Console.ReadLine());
                    if (result >= 0 && result <= 9)
                    {
                        CountryAction(CountriesDB[result]);
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid Entry, enter 1-9: ");
                    }
                }

                Console.WriteLine();

                exitProgram(ref restart);

                Console.WriteLine();

                Console.WriteLine("Goodbye!");
            }
        }

        static void exitProgram(ref bool reset)
        {
            while (true)
            {
                Console.Write("Would you like to learn about another country? (y/n): ");
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer.Contains('y'))
                {
                    Console.Clear();
                    break;
                }
                else if (answer.Contains('n'))
                {
                    reset = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
        }
    }
}

