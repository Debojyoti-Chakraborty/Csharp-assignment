using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharp
{
    public class Product
    {
        String Name;
        double Price;
        int Quantity;
        String Type;

        Product(String name, double price, int quantity, String type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
        public static void Main(String[] args)
        {
            var productList = new List<Product> {
            new Product("lettuce", 10.5, 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30, 30, "Marrow"),
            new Product("cauliflower", 10, 25, "Cruciferous"),
            new Product("zucchini", 20.5, 50, "Marrow"),
            new Product("yam", 30, 50, "Root"),
            new Product("spinach", 10, 100, "Leafy green"),
            new Product("broccoli", 20.2, 75, "Cruciferous"),
            new Product("garlic", 30, 20, "Leafy green"),
            new Product("silverbeet", 10, 50, "Marrow")
        };

            // 1

            Console.WriteLine("Total Number of Products in the list : " + productList.Count() + "\n");


            //2

            productList.Add(new Product("Potato", 10, 50, "Root"));

            Console.WriteLine("Total Number of Products after adding Potatoes in the list : " + productList.Count() + "\n");

            //3

            var leafyList = productList.Where(x => x.Type == "Leafy green").ToList();
            Console.WriteLine("Products of type 'Leafy Green'");
            foreach (var product in leafyList)
            {
                Console.WriteLine(product.Name + "\t\t" + product.Price + "Rs\t\t" + product.Quantity + "\t\t" + product.Type);
            }


            //4

            Console.WriteLine("\nAll Garlic Sold Out\n");
            productList.Remove(productList.Find(x => x.Name == "garlic"));
            Console.WriteLine("Total Number of Products remaining in the list : " + productList.Count() + "\n");


            //5

            Console.WriteLine("Adding 50 Cabbages\n");
            productList.Find(x => x.Name == "cabbage").Quantity = productList.Find(x => x.Name == "cabbage").Quantity + 50;
            Console.WriteLine("Quantity of Cabbage Remaining : " + productList.Find(x => x.Name == "cabbage").Quantity + "\n");


            //6

            double total = productList.Find(x => x.Name == "lettuce").Price * 1 + productList.Find(x => x.Name == "zucchini").Price * 2 + productList.Find(x => x.Name == "broccoli").Price * 1;
            Console.WriteLine("Total Price to pay after buying 1kg lettuce, 2kg zucchini, 1kg broccoli : " + Math.Round(total));
        }
    }
}