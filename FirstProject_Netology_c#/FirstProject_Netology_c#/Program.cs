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
            int digit;
            do
            {
                Console.WriteLine("Доброго дня! для продолжения, введите номер задачи: 1,2 или 3");
                if (int.TryParse(Console.ReadLine(), out digit)&& (digit>=1&&digit<=3))
                {
                    break;
                    
                }
                Console.WriteLine("Ошибка ввода данных!... скоро запустимся заново");
            } while (true);

            Console.WriteLine("Ожидаем запуска программы");
            switch (digit)
            {
                case 1: CheckTaskFirst(); break;
                    case 2: CheckTaskSecond(); break;
                    case 3: CheckTaskThird(); break;
            }
        }

        private class One
        {
            private readonly List<string> _list = new List<string>() { "first", "second", "third" };
            public void TaskLoop()
            { 
             
                while (true)
                {
                    Console.WriteLine("Пожалуйста, введите новую строчку для добавления ее в список");
                    _list.Add(Console.ReadLine());
                    Console.WriteLine("ОТлично, успешно добавлено в список, на данный момент список состоит из следующий элементов:");
                    Console.WriteLine(string.Join(",", _list));
                    Console.WriteLine("Добавьте еще одну строку в список, ее запихнем в середину");
                    _list.Insert(_list.Count/2, Console.ReadLine());
                    Console.WriteLine("Отлично, теперь список выглядит так:" + string.Join(",", _list));
                    Console.WriteLine("Если хотите завершить добавление, введите \"stop\". Для продолжения введите любой символ.");
                    string input = Console.ReadLine();
                    if(input=="stop")
                    {
                        Console.WriteLine("Спасибо, работа завершена, надеюсь, выполнена верно.");
                        break;
                    }
                }
            }

        }
        private class Two
        {
            private readonly Dictionary<string, int> _journal = new Dictionary<string, int>();
            public void TaskLoop()
            {
                while (true)
                {
                    Console.WriteLine("Поиграем в преподавателя. будем вводить Фамилию, а потом ставить его оценку в журнал...");
                    Console.WriteLine("Введите фамилию ученика:");
                    string family = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("а теперь введите оценку, от 2 до 5");
                        if (int.TryParse(Console.ReadLine(), out int digit) && (digit >= 2 && digit <= 5))
                        {
                            _journal[family] = digit;//_journal.Add(family,digit)

                            break;

                        }
                        Console.WriteLine("некорректные данные, попробуй снова");
                    } while (true);
                    Console.WriteLine($"Студент {family} успешно добавлен в журнал");

                    do
                    {
                        Console.WriteLine("Давай проверим работоспособность нашего журнала. ВВеди фамилию студента:");
                        string name = Console.ReadLine();
                        if (_journal.ContainsKey(name))
                        {
                            Console.WriteLine($"у студента {name} оценка {_journal[name]}");
                            break;
                        }
                        Console.WriteLine("УУУпс, такого нет, попробуй еще раз.");
                    } while (true);


                    Console.WriteLine("Если хотите завершить добавление, введите \"stop\". Если хотите перед выходом просмотреть весь журнал, введите " +
                        "\"J\". Для продолжения введите любой символ.");
                    string input = Console.ReadLine();
                    if (input == "stop")
                    {
                        Console.WriteLine("Спасибо, работа завершена, надеюсь, выполнена верно.");
                        break;
                    }
                    if (input == "J")
                    {
                        foreach (var people in _journal)
                        {
                            Console.WriteLine($"{people.Key}: {people.Value}");
                            continue;
                        }
                    } }
            


            }

        }
        private class Three
        {
            public void TaskLoop()
            {

            }

        }
        private static void CheckTaskFirst()
        {
            var listTask = new One();
            listTask.TaskLoop();
        }
        private static void CheckTaskSecond()
        {
            var listTask = new Two();
            listTask.TaskLoop();
        }
        private static void CheckTaskThird()
        {
            var listTask = new Three();
            listTask.TaskLoop();
        }
    }
        
    
}