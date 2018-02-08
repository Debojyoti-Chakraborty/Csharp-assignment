using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinister
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinister = new Dictionary<int, String>
            {
                { 1998, "Atal Vihari Vajpayee" },
                { 2014, "Narendra Modi" },
                { 2004, "Manmohan Singh" }

            };

            //Looking up Prime Minister of 2004

            Console.WriteLine("The Prime Minister of 2004 was : " + primeMinister[2004]);

            //Adding Current Prime Minister

            primeMinister.Add(2017, "Debojyoti Chakraborty");
            Console.WriteLine("\n\nCurrent Prime Minister Added\n");
            foreach (var item in primeMinister)
            {
                Console.WriteLine(item);
            }

            //Creating a Read-Only Dictionary


            IReadOnlyDictionary<int, String> readOnlyDictionary = new Dictionary<int, String>
        {
            { 1998, "Atal Vihari Vajpayee" },
                { 2014, "Narendra Modi" },
                { 2004, "Manmohan Singh" }
        };
            Console.WriteLine("\nSorted Dictionary");

            //sorting dictionary

            var keyList = primeMinister.Keys.ToList();
            keyList.Sort();
            foreach (var key in keyList)
            {
                Console.WriteLine("{0}: {1}", key, primeMinister[key]);
            }

        }

           


        
        
    }
}
