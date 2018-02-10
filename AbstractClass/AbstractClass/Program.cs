using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Employee
    {
        public String Name;
        public String Id;
        public String Designation;
        public double Experience;
        public double AnnualSalary;
        public String JoiningDate;
        public abstract double CalcSalary();
    }
    public class HR : Employee
    {
        double BasicSalary;
        public HR(double basic, double exp)
        {
            this.Experience = exp;
            this.BasicSalary = basic;
        }
        public override double CalcSalary()
        {
            return BasicSalary + 1000 * Experience;
        }
    }
    public class Developer : Employee
    {
        double BasicSalary;
        public Developer(double basic, double exp)
        {
            this.Experience = exp;
            this.BasicSalary = basic;
        }
        public override double CalcSalary()
        {
            return BasicSalary + 2000 * Experience;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer(8000, 5);
            HR hr1 = new HR(8000, 4);
            Console.WriteLine("Total Salary of HR : " + hr1.CalcSalary());
            Console.WriteLine("Total Salary of Developer : " + dev1.CalcSalary());
        }
    }
}
