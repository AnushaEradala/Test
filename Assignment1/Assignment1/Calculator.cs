using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int input1, input2;
            int result;
            string doYouWantToContinue;
            do
            {
                Console.WriteLine("************************** Console Calculator Operations *************************");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Please Select your operation:");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter value 1:");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter value 2:");
                input2 = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: result = input1 + input2;
                        Console.WriteLine("Sum= {0}", result);
                        break;
                    case 2: result = input1 - input2;
                        Console.WriteLine("Difference= {0}", result);
                        break;
                    case 3: result = input1 * input2;
                        Console.WriteLine("Product = {0}", result);
                        break;
                    case 4: result = input1 / input2;
                        Console.WriteLine("Division = {0}", result);
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                }
                Console.Write("Do you wish to continue (y/n)?");
                doYouWantToContinue = Console.ReadLine();
            } while (doYouWantToContinue.ToLower() == "y");
            Console.WriteLine("************************** ThankYou..! *************************");

        }
    }
}
