using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<String> { "Boat", "House", "Cat", "River", "Cupboard" };

            //Printing plurals

            for(int i=0;i<words.Count;i++)
            {
                Console.WriteLine(words[i]+'s');
            }

            //Replacing with synonym
            words[1] = words[1].Replace("House", "Home");
            Console.WriteLine("\n");

            //Adding new Element
            words.Add("New Word");
            Console.WriteLine(words.Count);

            Console.WriteLine("\n");
            //character length 7
            var sevenLetter = words.Where(x => x.Length==7).ToList();
            foreach(var word in sevenLetter)
            {
                Console.WriteLine(word);
            }

            //Printing word on 3rd position
            Console.WriteLine(words[2]);

            Console.WriteLine("\n");

            //printing words in ascending order
            List<String> a = words.ToList();
            a.Sort();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            //printing reverse
            words.Reverse();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
