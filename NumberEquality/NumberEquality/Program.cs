using System;

namespace NumberEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating sum of floating-point variables

            float X = 0.06f, Y = 5.94f;
            float sum = X + Y;
            Console.WriteLine("The sum of X and Y is : " + sum);

            //Checking Equality
            
            String equal= sum == 6 ?"Summation of X&Y is equal to 6" : "Summation of X&Y is not equal to 6";
            Console.WriteLine(equal+"\n");

            //Checking Greater Value

            Console.WriteLine("Printing Greater Value Variable");
            String res = X > Y ? "X : "+X : "Y: "+Y;
            Console.WriteLine(res);
        }
    }
}
