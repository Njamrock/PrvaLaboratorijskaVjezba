using System;

namespace MojaPrvaKonzola
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string c;

            try
            {

                a = double.Parse(args[0]);
                b = double.Parse(args[2]);
                c = args[1];


                switch (c)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                        break;
                    default:
                        Console.WriteLine("I don't know this operator.");
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Error during data parsing: " + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR Occurred: " + e.Message);
            }
        }
    }
}
