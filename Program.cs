using System;
using System.Transactions;

namespace FirstC_SharpProg
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, solution;
            string operation;
            bool cont;

            do
            {
                Console.WriteLine("Enter first number");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operation to be performed");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        solution = num1 + num2;
                        Console.WriteLine("The solution is " + solution);
                        break;
                    case "-":
                        solution = num1 - num2;
                        Console.WriteLine("The solution is " + solution);
                        break;
                    case "*":
                        solution = num1 * num2;
                        Console.WriteLine("The solution is " + solution);
                        break;
                    case "/":
                        if (num2 == 0)
                            Console.WriteLine("Cannot devide by zero");
                        else
                        {
                            solution = num1 / num2;
                            Console.WriteLine("The solution is " + solution);
                        }
                        break;
                }
                Console.WriteLine("Do you wish to perform another calculation?  Y/N");
                string sCont = Console.ReadLine();

                if (sCont.Equals("Y") || sCont.Equals("y"))
                    cont = true;
                else
                {
                    cont = false;
                    Console.WriteLine("Goodbye");
                }
            } while (cont);
        }
    }
}
