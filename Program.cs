using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number");
            double int1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Press any operator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            double int2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(int1 + int2);
            }

            else if(op == "-")
            {
                Console.WriteLine(int1 - int2);
            }

            else if (op == "*")
            {
                Console.WriteLine(int1 * int2); 
            }

            else if (op == "/")
            {
                Console.WriteLine(int1 / int2); 
            }

            else if (op == "%")
            {
                Console.WriteLine(int1 % int2); 
            }

            Console.ReadLine();
        }

    
    }
}
