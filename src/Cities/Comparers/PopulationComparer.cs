using System.Collections.Generic;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // Since we want to sort strings, we can use the
            // comparer for the built-in string class
            return y.Population - x.Population;
        }
    }
}
