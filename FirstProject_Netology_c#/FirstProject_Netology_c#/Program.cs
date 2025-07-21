using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstJob
{
    class Program
    {

        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int number1))
            {
                // число записывается в переменную number1
            }
            else
            {
                Console.WriteLine("ERROR! Please, enter number!!!");
                return;
            }
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                // число записывается в переменную number2
            }
            else
            {
                Console.WriteLine("ERROR! Please, enter number!!!");
                return;
            }
            var ch = Console.ReadLine();
            if (ch.Length == 1 && (ch[0] == '&' || ch[0] == '|' || ch[0] == '^'))
            {
                switch (ch[0])
                {
                    case '&':
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, number1 & number2);
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 & number2, 2));
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 & number2, 16)); break;
                    case '|':
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, number1 | number2);
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 | number2, 2));
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 | number2, 16)); break;
                    case '^':
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, number1 ^ number2);
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 ^ number2, 2));
                        Console.WriteLine("Result  {0} {1} {2} ={3}", number1, ch, number2, Convert.ToString(number1 ^ number2, 16)); break;

                }
            }
            else
            {
                Console.WriteLine("Error, Wrong sign");

            }

        }
    }
}