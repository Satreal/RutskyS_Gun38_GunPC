using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace FirstJob
    {
        public struct Interval
        {
            public double Min { get; }
            public double Max { get; }
            Random RandomValue = new Random();
            public double Get()
            {
                return RandomValue.NextDouble() * (Max - Min) + Min;
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


