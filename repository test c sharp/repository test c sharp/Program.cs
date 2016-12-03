using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository_test_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input one numbers");
            double num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("input action:");
            char actchar = char.Parse(Console.ReadLine());
            Console.WriteLine("input another number");
            double num4 = int.Parse(Console.ReadLine());
            double result=calculator(num3, num4, actchar);
            Console.WriteLine(result);
        }
        public static double calculator(double num1, double num2, char action)
        {
            switch (action)
            {
                case '+':
                    return num1 + num2;
                    break;
                case '/':
                    return num1 / num2;
                    break;
                case '*':
                    return num1 * num2;
                    break;
                case '-':
                    return num1 - num2;
                    break;
                default:
                    return 0;
            }
        }
    }
}
