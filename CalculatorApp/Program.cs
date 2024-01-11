using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Action to be Performed: ");
                Console.WriteLine("Press 1 for Addition ");
                Console.WriteLine("Press 2 for Substraction ");
                Console.WriteLine("Press 3 for Multipication ");
                Console.WriteLine("Press 4 for Devision ");

                int action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter First Input: ");
                int input_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Input: ");
                int input_2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (action)
                {
                    case 1:
                        {
                            result = Addition(input_1, input_2);
                            break;
                        }
                    case 2:
                        {
                            result = Substraction(input_1, input_2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(input_1, input_2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(input_1, input_2);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action !! try again.");
                        break;
                }

                Console.WriteLine("The result is {0} ", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input format. please enter valid numbers. ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please enter non zero value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }

            Console.ReadKey();

        }

        //Addition
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

        //Substraction
        public static int Substraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }

        //Multiplication
        public static int Multiplication(int input_1, int input_2)
        {
            int result = (input_1 * input_2);
            return result;
        }

        //Division
        public static int Division(int input_1, int input_2)
        {
            if (input_2 == 0)
            {
                throw new DivideByZeroException();
            }

            int result = (input_1 / input_2);
            return result;
        }




    }
}
