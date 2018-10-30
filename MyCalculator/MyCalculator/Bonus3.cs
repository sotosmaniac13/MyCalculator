using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Bonus3
    {
        public static void Secondary3()
        {
            // Ask the user to type the first number
            Console.WriteLine("Type a number, and then press Enter");
            //int num1 = Convert.ToInt16(Console.ReadLine());
            // Line 13: convert num1 to integer

            //10. Convert to Float-------------------------------------------------
            float num1 = float.Parse(Console.ReadLine());


            //7. Accept only positive numbers--------------------------------------
            /*while (num1 <= 0)
            {
                Console.WriteLine("Enter a positive number: ");
                num1 = Convert.ToInt16(Console.ReadLine());
            }*/

            //8. Accept only positive numbers up to 100----------------------------
            /*while ((num1 <= 0) || (num1 > 100))
            {
                Console.WriteLine("Enter a number between 1-100: ");
                num1 = Convert.ToInt16(Console.ReadLine());
            }*/

            //9. Accept only numbers between -100 and 100--------------------------
            /*while ((num1 < -100) || (num1 > 100))
            {
                Console.WriteLine("Enter a number between (-100) - (100): ");
                num1 = Convert.ToInt16(Console.ReadLine());
            }*/

            //10. Accept only floats between -100.0 and 100.0----------------------
            while ((num1 < -100.0) || (num1 > 100.0))
            {
                Console.WriteLine("Enter a number between (-100.0) - (100.0): ");
                num1 = float.Parse(Console.ReadLine());
            }

            // Ask the user to type the second number
            Console.WriteLine("Type another number, and then press Enter");
            //int num2 = Convert.ToInt16(Console.ReadLine());
            // Line 18: convert num2 to integer

            //10. Convert to Float-------------------------------------------------
            float num2 = float.Parse(Console.ReadLine());

            //7. Accept only positive numbers--------------------------------------
            /*while (num2 <= 0)
            {
                Console.WriteLine("Enter a positive number: ");
                num2 = Convert.ToInt16(Console.ReadLine());
            }*/

            //8. Accept only positive numbers up to 100----------------------------
            /*while ((num2 <= 0) || (num2 > 100))
            {
                Console.WriteLine("Enter a number between 1-100: ");
                num2 = Convert.ToInt16(Console.ReadLine());
            }*/

            //9. Accept only numbers between -100 and 100--------------------------
            /*while ((num2 < -100) || (num2 > 100))
            {
                Console.WriteLine("Enter a number between (-100) - (100): ");
                num2 = Convert.ToInt16(Console.ReadLine());
            }*/

            //10. Accept only floats between -100.0 and 100.0----------------------
            while ((num2 < -100.0) || (num2 > 100.0))
            {
                Console.WriteLine("Enter a number between (-100.0) - (100.0): ");
                num1 = float.Parse(Console.ReadLine());
            }

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tadd      - Add");
            Console.WriteLine("\tsubtract - Subtract");
            Console.WriteLine("\tmultiply - Multiply");
            Console.WriteLine("\tdivide   - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "add":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                    break;
                case "subtract":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "multiply":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "divide":
                    // Ask the user to enter a non-zero divisor until they do so
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = float.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                // Return text for an incorrect option entry
                default:
                    Console.WriteLine("That is an incorrect option entry, please try again.");
                    break;

            }
            
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");

            Console.ReadKey();
        }
    }
}
