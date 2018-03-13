using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            IComparer<City> namecomparer = new NameComparer();

            cities.Sort(namecomparer);

            PrintCities(cities);

            Console.ReadLine();

            IComparer<City> statecomparer = new StateComparer();

            cities.Sort(statecomparer);

            PrintCities(cities);

            Console.ReadLine();

            IComparer<City> popcomparer = new PopulationComparer();

            cities.Sort(popcomparer);

            PrintCities(cities);

            Console.ReadLine();

            IComparer<City> areacomparer = new AreaComparer();

            cities.Sort(areacomparer);

            PrintCities(cities);

            Console.ReadLine();


        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
