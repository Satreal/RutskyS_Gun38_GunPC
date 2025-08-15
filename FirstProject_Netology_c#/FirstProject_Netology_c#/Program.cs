using System;
using System.Text.RegularExpressions;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace FirstJob
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string a = "hello,";
            string b = "hello?";
            
            Console.WriteLine(ConcatenateStrings(a, b));

            string nameGreetUser = Console.ReadLine();
            int ageGreetUser = int.Parse(Console.ReadLine());
            string result = GreetUser(nameGreetUser, ageGreetUser);
            Console.WriteLine(result);

            string upperLower = Console.ReadLine();
            Console.WriteLine(LengthUpperLowerStrings(upperLower));

            Console.WriteLine(Substring());

            string[] arrive = new string[] { "Hello", "My", "LittLE", "WOOOOORLD" };
            string stringBuilder = ArriveStringBuilder(arrive);
            Console.WriteLine(stringBuilder);

            string inputString = "Тут фраза, где меняем слово фраза на другое слово и фраза обретает странный смысл. фраза!";
            string oneWord = "фраза";
            string twoWord = "глаз";
            Console.WriteLine(ReplaceWords(inputString,oneWord,twoWord));
            
        }

public static string ConcatenateStrings(string a, string b)
        {
            return a+b;
        }

        public static string GreetUser (string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }
        public static string LengthUpperLowerStrings(string a)
        {
            string answer = $" в строке {a.Length} символов,\nПишем Верхним регистром \"{a.ToUpper()}\",\n и теперь нижним \"{a.ToLower()}\".";
            return answer ;
        }

        public static string Substring()
        {
            string example = "golovastik";
            return example.Substring(0, 5);
        }

        public static string ArriveStringBuilder(string[] arrive)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0;i < arrive.Length;i++)
            {
                stringBuilder.Append(arrive[i]);
                stringBuilder.Append(' ');

            }
            return stringBuilder.ToString();
        }

        public static string ReplaceWords(string oneString, string one, string two)
        { 
            string result = oneString.Replace(one, two);
            return result;
        }


    }
}