using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<String> {
            "Tomato",
            "Potato",
            "ToMato",
            "Potato",
            "Red Tomato",
            "Tomato Ketchup",
            "Grapes",
            "grapes",
            "potato"
            };

            //tomato (case insensitive)

            var tomato = new List<String>();
            foreach (var item in products)
            {
                if (String.Compare(item, "tomato", StringComparison.OrdinalIgnoreCase) == 0) tomato.Add(item);
            }
            Console.WriteLine("Count of strings equal to tomato(case insensitive) : " + tomato.Count);

            //Potato (case sensitive)

            Console.WriteLine("\n\nIndices of list where exactly Potato (case sensitive) is present");
            for (int i = 0; i < products.Count; i++)
            {
                if (String.Compare(products[i], "Potato", StringComparison.Ordinal) == 0)Console.WriteLine(i);
            }
        }
    }
}
