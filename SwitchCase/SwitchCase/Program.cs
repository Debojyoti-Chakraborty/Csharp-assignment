using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class Product
    {
        public String Name;
        public double Price;
        public int Quantity;
        public String Type;
        public Product(string name, double price, int quantity, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
    }
    class Program
    {
        
        static List<Product> productList = new List<Product>()
            {
                new Product("lettuce", 10.5, 50, "Leafy Green"),
                new Product("cabbage", 20, 100, "Cruciferous"),
                new Product("pumpkin", 30, 30, "Marrow"),
                new Product("cauliflower", 10, 25, "Cruciferous"),
                new Product("zuchhini", 20.5, 50, "Marrow"),
                new Product("yam", 30, 50, "Root"),
                new Product("spinach", 10, 100, "Leafy Green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("garlic", 30, 20, "Leafy Green"),
                new Product("silverbeet", 10, 50, "Marrow")
            };

        static void TypeBased()
        {
            List<Product> leafyList = productList.Where(x => x.Type=="Leafy Green").ToList();
            List<Product> cruciList = productList.Where(x => x.Type =="Cruciferous").ToList();
            List<Product> rootList = productList.Where(x => x.Type =="Root").ToList();
            List<Product> marrowList = productList.Where(x => x.Type =="Marrow").ToList();
            Console.WriteLine("Type Based List\n");
            Console.WriteLine("Leafy Green");
            foreach (var item in leafyList)
            {
                Console.WriteLine(item.Name+"\t\t"+item.Price+"\t\t"+item.Quantity);
            }
            Console.WriteLine();

            Console.WriteLine("Cruciferous");
            foreach (var item in cruciList)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity);
            }
            Console.WriteLine();

            Console.WriteLine("Root");
            foreach (var item in rootList)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity);
            }
            Console.WriteLine();

            Console.WriteLine("Marrow");
            foreach (var item in marrowList)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity);
            }
            Console.WriteLine();
        }
        static void Costly()
        {
            var costly = productList.Where(x => x.Price > 50).ToList();
            var cheap = productList.Where(x => x.Price <= 50).ToList();
            Console.WriteLine("Costly Products\n");
            foreach (var item in costly)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity +"\t\t"+item.Type);
            }
            Console.WriteLine();
            Console.WriteLine("Cheap Products\n");

            foreach (var item in cheap)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity + "\t\t" + item.Type);
            }
            Console.WriteLine();
        }
        static void Average()
        {
            double avg = 0.0;
            foreach (var item in productList)
            {
                avg = avg + item.Price;
            }
            avg = avg / productList.Count();
            Console.WriteLine("Average Price : " + avg);
        }
        static void TotalPrice()
        {
            double total=0.0;
            foreach (var item in productList)
            {
                total = total + item.Price * item.Quantity;
            }
            Console.WriteLine("Total Price : " + total);
        }

        static void Main(string[] args)
        {


            int choice=9;
            Console.WriteLine("Select option : \n1.Print type based list\n2. Print total price\n3. Print Average price\n4. Distinguish Costly and Cheap Products\n0. To Exit");
            try
            {
                 choice = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
                {
                Console.WriteLine("Enter Above Choices");
                }
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1: Console.Clear(); TypeBased();break;
                    case 2: Console.Clear(); TotalPrice();break;
                    case 3: Console.Clear(); Average();break;
                    case 4: Console.Clear(); Costly();break;
                    default : Console.Clear();  Console.WriteLine("Enter Choice 1-4");break;

                }
                Console.WriteLine("Select option : \n1.Print type based list\n2. Print total price\n3. Print Average price\n4. Distinguish Costly and Cheap Products\n0. To Exit");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Enter 1 of the Above Choices");
                }
            }
        }
    }
}
