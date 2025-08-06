using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace FirstJob
    {
        public struct Interval
        {
            public int Min { get; }
            public int Max { get; }
            public Random RandomValue = new Random();
            public double Get()
            {
                return RandomValue.Next(Min,Max);
            }
            public Interval(int minValue, int maxValue)
            {
                if (minValue < 0)
                {
                    minValue = 0;
                    Console.WriteLine("Ошибка ввода данных. Значение приведено к 0");
                }
                if (maxValue < 0)
                {
                    maxValue = 0;
                    Console.WriteLine("Ошибка ввода данных. Значение приведено к 0");
                }
                if (minValue > maxValue)
                {
                    (minValue, maxValue) = (maxValue, minValue);//данные меняются местами. чтобы не создавать лишнюю переменную
                    Console.WriteLine("Ошибка ввода данных значений.");
                }
                if (minValue == maxValue)
                {
                    maxValue += 10;
                    Console.WriteLine("Ошибка ввода данных значений. Максимальное значение увеличено");
                }
                Min = minValue;
                Max = maxValue;

            }
        }
    }


