using System;
using System.ComponentModel.Design;
using System.Drawing;

namespace TwoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //for (; ; )
            //{
            //    Console.WriteLine($"i = {i}");
            //    i++;
            //}

            //for (int i = 1, j = 1; i < 10; i++, j++)
            //{
            //    Console.WriteLine($"{i * j}");
            //}

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Сумма: {sum}");

            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);

            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //int i = -1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);

            //int j = -1;
            //while (j > 0)
            //{
            //    Console.WriteLine(j); 
            //    j--;
            //}

            //foreach (char i in "Hello world")
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}

            //string? input;
            //Console.WriteLine("Добро пожаловать в Эхо-чат!\nНапиши что-нибудь (или 'выход' для завершения):");

            //while (true)
            //{
            //    Console.Write("> ");
            //    input = Console.ReadLine();

            //    if (input == null) continue;

            //    if (input.ToLower() == "выход")
            //    {
            //        Console.WriteLine("До встречи!");
            //        break;
            //    }

            //    Console.WriteLine($"Вы сказали: {input}");
            //}
            //DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today);

            //TaskPriority priority = TaskPriority.High;
            //Console.WriteLine((int)priority);

            //var times = Enum.GetValues(typeof(TimeOfDay));
            //var heroes = Enum.GetValues(typeof(Hero));

            //for (int i = 0; i < times.Length; i++)
            //{
            //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");

            //    for (int j = 0; j < heroes.Length; j++)
            //    {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.Write($"{h} – ");

            //        switch (time)
            //        {
            //            case TimeOfDay.Утро:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.воин => "делает зарядку ⚔️ мечом",
            //                    Hero.маг => "заваривает зелья",
            //                    Hero.вор => "крадётся по базару",
            //                    _ => "ничего не делает"
            //                });
            //                break;

            //            case TimeOfDay.День:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.воин => "тренируется на арене",
            //                    Hero.маг => "изучает древние книги",
            //                    Hero.вор => "прячется в тенях",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Вечер:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.воин => "ест мясо у костра",
            //                    Hero.маг => "создаёт магический щит",
            //                    Hero.вор => "планирует налёт",
            //                    _ => ""
            //                });
            //                break;

            //            case TimeOfDay.Ночь:
            //                Console.WriteLine(h switch
            //                {
            //                    Hero.воин => "спит в палатке",
            //                    Hero.маг => "медитирует под луной",
            //                    Hero.вор => "лезет в чужой дом",
            //                    _ => ""
            //                });
            //                break;
            //        }
            //    }
            //}

            //zadanie 2
            //orderstatus status = orderstatus.New;
            //if (status == orderstatus.New || status == orderstatus.Processing)
            //{
            //    Console.WriteLine("заказ можно отменить");
            //}
            //else 
            //{
            //    Console.WriteLine("заказ уже нельзя отменить");
            //}

            //zadanie 3
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //zadanie 4 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"5 * {i} = {i*5}");
            //}

            //zadanie 5
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся");
            //}

            //zadanie 6
            //Console.WriteLine("введи количество");
            //int n = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //}

            //zadanie 7
            //Console.WriteLine("введи чо нить");
            //string text = Console.ReadLine();
            //Console.WriteLine("введи количество");
            //int n = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(text);
            //}

            //ZADANIE 8
            //Boolean esli = true;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Введите число:");
            //    int sch = int.Parse(Console.ReadLine());
            //    if (sch % 2 != 0)
            //    {
            //        esli = false;
            //    }
            //} if (esli)
            //{
            //    Console.WriteLine("да");
            //} else
            //{
            //    Console.WriteLine("нет");
            //}

            //zadanie 9
            Console.WriteLine("Добро пожаловать на стрельбище!");
            Console.WriteLine("Введите 'стоп', чтобы завершить стрельбу.");
            string shoot = "";
            int n = 0;
            while (shoot == "")
            {
                Console.Write("Нажмите Enter для выстрела: ");
                shoot = Console.ReadLine();
                Console.WriteLine("Выстрел завершен");
                n += 1;

            }
            Console.WriteLine("Стрельба завершена");
            Console.WriteLine($"Израсходавано боеприпасов: {n}");

        }
        enum DayOfWeek
        {
            Monday,    
            Tuesday,   
            Wednesday, 
            Thursday,  
            Friday,   
            Saturday,  
            Sunday,    
        }
        enum TaskPriority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }
        enum Hero { воин, маг, вор }
        enum TimeOfDay { Утро, День, Вечер, Ночь }

        enum trafficlight {Red, Yellow, Green}
        enum orderstatus { New, Processing, Shipped, Delivered}

    }
}   