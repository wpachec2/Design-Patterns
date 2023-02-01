using System;
namespace MVC_Countries___Design_Patterns
{
	public class CountryListView
	{
        //Property
        public List<Country> Countries { get; set; }

		//Constructor
		public CountryListView(List<Country> _countries)
		{
			Countries = _countries;
		}

        //Method
        public void Display()
        {
            int i = 0;
            foreach (Country c in Countries)
            {
                Console.WriteLine($"{i++}. {c.Name}");
            }
        }
    }
}

