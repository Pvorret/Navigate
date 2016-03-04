using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigate
{
    class Program
    {
        static void Main(string[] args)
        {
            ADT.Map denmark = new ADT.Map();
            denmark.AddCity("Aalborg");
            denmark.AddCity("Herning");
            denmark.AddCity("Aarhus");
            denmark.AddCity("Esbjerg");
            denmark.AddCity("Silkeborg");
            denmark.AddCity("Fredericia");
            denmark.AddCity("Middelfart");
            denmark.AddCity("Faaborg");
            denmark.AddCity("Odense");

            denmark.AddDistance("Aalborg", "Aarhus", 118, true);
            denmark.AddDistance("Aalborg", "Herning", 145, true);
            denmark.AddDistance("Herning", "Silkeborg", 40, true);
            denmark.AddDistance("Silkeborg", "Aarhus", 44, true);
            denmark.AddDistance("Herning", "Esbjerg", 88, true);
            denmark.AddDistance("Silkeborg", "Faaborg", 163, true);
            denmark.AddDistance("Aarhus", "Fredericia", 93, true);
            denmark.AddDistance("Fredericia", "Middelfart", 12, true);
            denmark.AddDistance("Middelfart", "Odense", 47, true);
            denmark.AddDistance("Middelfart", "Faaborg", 66, true);
            denmark.AddDistance("Faaborg", "Odense", 40, true);
            denmark.AddDistance("Esbjerg", "Odense", 135, true);

            Algoritm.ShortestRute sr = new Algoritm.ShortestRute();
            string route = sr.CalculateRoute("Aalborg", "Odense", denmark);
            Console.WriteLine(route);

            Console.ReadKey();
        }
    }
}
