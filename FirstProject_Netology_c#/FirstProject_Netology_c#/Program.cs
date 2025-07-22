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
            //выполнение первого задания
            int[] fibonachi = new int[8] {0,1,1,2,3,5,8,13};

            //выполнение второго задания
            string[] month = new string[12] { "January", "February", "March","April","May","June","July","August","September","October","November","December"};

            //третье задание
            int[,] matrix = new int[3, 3] { { 2, 3, 4 }, { 4, 9, 16 }, { 8, 27, 64 } };

            //четвертое задание 
            double[][] jagged = new double[3][]; //создаем массив с подмассивами /*{ Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }*/
            jagged[0] = new double[5];// первый подмассив, и загоняем его в первую строку
            for(int i = 0; i < 5; i++)
            {
                jagged[0][i] = i + 1;
            }
            jagged[1] = new double[2]; //загоняем во вторую строку второй массив из констант
            jagged[1][0] = Math.E;
            jagged[1][1] = Math.PI;
            jagged[2] = new double[4];//загоняем массив с логаритмами
            jagged[2][0] = Math.Log10(1);
            jagged[2][1] = Math.Log10(10);
            jagged[2][2] = Math.Log10(100);
            jagged[2][3] = Math.Log10(1000);




            
            
            
            
            

        }
    }
}