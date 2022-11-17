
using Calculator;

namespace ConsoleAppCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    float firstNumber = 0, secondNumber = 0;
                    string operation;
                    Console.WriteLine("Please enter first number");
                    firstNumber = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    secondNumber = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter type of operation");
                    operation = Console.ReadLine();

                    SimpleCalculator simpCalc = new SimpleCalculator(firstNumber, secondNumber);

                    switch (operation)
                    {
                        case "+":
                            {
                                Console.WriteLine(simpCalc.Summarize());
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine(simpCalc.Deduct());
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine(simpCalc.Multiply());
                                break;
                            }
                        case "/":
                            {
                                Console.WriteLine(simpCalc.Divide());
                                break;
                            }
                        case "%":
                            {
                                Console.WriteLine(simpCalc.Percent());
                                break;
                            }
                    }
                }
                catch (FormatException)
                { 
                    Console.WriteLine("Can't convert a string to number. Please enter number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("The second number mustn't be zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



        }
    }
}