using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(planetList2);

            Console.WriteLine("\nAddRange(planetList)");

            planetList.Insert(2, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanetsList = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

        }
    }
}
