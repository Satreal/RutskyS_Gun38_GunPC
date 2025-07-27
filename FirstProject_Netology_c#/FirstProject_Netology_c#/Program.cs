using System;
using System.Text.RegularExpressions;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstJob
{
    class Program
    {

        static void Main(string[] args)
        {
            //задание 1
            int digit1=0;
            int digit2 = 1;
            Console.WriteLine(digit1);
            Console.WriteLine(digit2);
            for(int i=2; i<10;i++)
            {
                int newdigit = digit1 + digit2;
               Console.WriteLine(newdigit);
                digit1 = digit2;
                digit2 = newdigit;

                
            }

            //задание 2
            for(int i=2;i<21;i+=2)//также можно сделать цикл i++, и добавить if(i%2==0), т.е. если нет остатка от деления, значит четное, на печать
            {
                Console.WriteLine(i);
            }

            //задание 3
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

            //задание 4
            string password = "qwerty";
            string user="";
            do
            {
                user = Console.ReadLine();
               if(password!=user)
               {
                    Console.WriteLine("Wrong password!");
                }
                else
                {
                    Console.Write("True password!");
                }

            } while (password != user);
           
            









        }
    }
}