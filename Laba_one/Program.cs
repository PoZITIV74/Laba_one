using System;
using static System.Math;
using System.Collections.Generic;

namespace Laba_one
{
    internal class Program
    {
        static void Main(string[] args)

        {
            { /*  Console.WriteLine("Введите log");
             Console.WriteLine("Основание a:");
             double a = double.Parse(Console.ReadLine());
         Console.WriteLine("Аргумент b:");        
                 double b = double.Parse(Console.ReadLine());
         double z = Math.Log(b, a);

         double As = Math.Round(z, 1);
         Console.WriteLine($"Округление до десятых: { As}");
             double Ast = Math.Round(z, 2);
         Console.WriteLine($"Округление до сотых: { Ast}");
             Console.WriteLine($"Без округления: {z}");
            */
            } // 1 задание

            {

                /*
                  Console.WriteLine("Меню");
                  Console.WriteLine("1. Из градусов в радианы");
                  Console.WriteLine("2. Из радианов в градусы");

                  int list = int.Parse(Console.ReadLine());   // Ввод нужного числа из списка
                  double Pi = Math.PI;
                  int gradus = 180;

                  if (list == 1)          // выбор нужного пункта
                  {
                      Console.WriteLine("Конвертация из градусов в радианы выбрана");
                      Console.Write("Введите Градусы: ");
                      int gradusi = int.Parse(Console.ReadLine());        //Ввод нужного градуса
                      double itog = gradusi * Pi / gradus;                //Градусы переводятся в радианы (заданный результат умнажается на число PI и делится на 180)
                      Console.Write("Округление до n знака после запятой: ");
                      int okruglenie = int.Parse(Console.ReadLine());     //Ввод числа до нужного знака после запятой
                      double vivod = Round(itog, okruglenie);             //Округляет число после ввода
                      Console.WriteLine("Градусы в радианы: " + vivod);
                  }
                  else if (list == 2)
                  {
                      Console.WriteLine("Конвертация из радианов в градусы выбрана");
                      Console.Write("Введите радиану: ");
                      double radian = double.Parse(Console.ReadLine());              //Ввод нужной радианы
                      double itog = radian * gradus / Pi;                     // Радианы переводятся в градусы (заданный результат умнажается на 180 градусов и делится на PI )
                      Console.Write("Округление до n знака после запятой: ");
                      int okruglenie = int.Parse(Console.ReadLine());         //Ввод числа до нужного знака после запятой
                      double vivod = Round(itog, okruglenie);                 //Округляет число после ввода
                      Console.WriteLine("Радианы в градусы: " + vivod);
                  }
                  else Console.WriteLine("Значение отсутствует"); */
            } // 2 задание

            {
                /*
                Console.WriteLine("Первый параллелограмм");
                 Console.WriteLine("Введите вершину а, x координату");       // коардинаты точек первой фигуры из строки переводится в double
                 double a1x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину а, y координату");
                 double a1y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину b, x координату");
                 double b1x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину b, y координату");
                 double b1y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину c, x координату");
                 double c1x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину c, y координату");
                 double c1y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину d, x координату");
                 double d1x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину d, y координату");
                 double d1y = double.Parse(Console.ReadLine());

                 Console.WriteLine("_________________________________________________");
                 Console.WriteLine("");

                 Console.WriteLine("Второй параллелограм");
                 Console.WriteLine("Введите вершину а2, x координату");      // коардинаты точек второй фигуры из строки переводится в double
                 double a2x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину а2, y координату");
                 double a2y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину b2, x координату");
                 double b2x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину b2, y координату");
                 double b2y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину c2, x координату");
                 double c2x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину c2, y координату");
                 double c2y = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину d2, x координату");
                 double d2x = double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите вершину d2, y координату");
                 double d2y = double.Parse(Console.ReadLine());

                 var DOWN = Sqrt(Pow(a1x - d1x, 2.0) + Pow(a1y - d1y, 2.0));         // возводится в квадратный корень , потом возвращается в начальное число 
                 var UP = Sqrt(Pow(b1x - c1x, 2.0) + Pow(b1y - c1y, 2.0));
                 var Levo = Sqrt(Pow(a1x - b1x, 2.0) + Pow(a1y - b1y, 2.0));
                 var Pravo = Sqrt(Pow(c1x - d1x, 2.0) + Pow(c1y - d1y, 2.0));

                 var DOWN2 = Sqrt(Pow(a2x - d2x, 2.0) + Pow(a2y - d2y, 2.0));
                 var UP2 = Sqrt(Pow(b2x - c2x, 2.0) + Pow(b2y - c2y, 2.0));
                 var Levo2 = Sqrt(Pow(a2x - b2x, 2.0) + Pow(a2y - b2y, 2.0));
                 var Pravo2 = Sqrt(Pow(c2x - d2x, 2.0) + Pow(c2y - d2y, 2.0));

                 Console.WriteLine("_________________________________________________");
                 Console.WriteLine("");


                 if (a1x == a2x || b1x == b2x || c1x == c2x || d1x == d2x || a1y == a2y || b1y == b2y || c1y == c2y || d1y == d2y) // проверяет наложение
                 {
                     Console.WriteLine("Ошибка. Наложение фигуры");

                 }
                 else if (a1x > a2x && a1x < b2x && a1y > a2y && a1y < b2y || b1x > a2x && a1x < c2x && b1y > a2y && a1y < c2y || c1x > a2x && a1x < d2x && c1y > a2y && a1y < d2y || d1x > a2x && a1x < a2x && d1y > a2y && a1y < a2y)
                 {
                     Console.WriteLine("Ошибка. Пересичение фигур");               // проверяет пересичение

                 }


                 Console.WriteLine("_________________________________________________");
                 Console.WriteLine("");

                 Console.WriteLine("Первая фигура");

                 if (Levo == Pravo || UP == DOWN)       // проверяет правильность фигуры
                 {
                     Console.WriteLine("Фигура построена");
                 }
                 else if (Levo == UP && Pravo == DOWN)       // проверяет правильность фигуры
                 {
                     Console.WriteLine("Фигура построена");
                 }
                 else
                 {
                     Console.WriteLine("Ошибка");
                 }

                 Console.WriteLine("_________________________________________________");
                 Console.WriteLine("");

                 Console.WriteLine("Вторая фигура");

                 if (Levo2 == Pravo2 || UP2 == DOWN2)   // проверяет правильность фигуры
                 {
                     Console.WriteLine("Фигура построена");
                 }
                 else if (Levo2 == UP2 && Pravo2 == DOWN2)       // проверяет правильность фигуры
                 {
                     Console.WriteLine("Фигура построена");
                 }
                 else
                 {
                     Console.WriteLine("Ошибка"); 
                */
            } // 3 задание

            {
                /* Console.WriteLine("Введите уравнение");
                 string vvod = Console.ReadLine();
                 vvod = vvod.Replace("-", ".-");         // заменяет знак с минуса на точку с минумос
                 vvod = vvod.Replace("+", ".+");         // заменяет плюс на плюс с точкой
                 string[] per = vvod.Split('.', '=');    // разделяет на разные строки 
                 Console.WriteLine("___________________________");
                 for (int i = 0; i < per.Length; i++)
                 {
                     if (per[i].EndsWith("x"))  // находит число с x
                     { per[i] = per[i].Replace("x", ""); Console.Write(per[i]); Console.WriteLine(" Множитель"); } // убирает x и делает пустоту
                 }
                 for (int i = 0; i < per.Length; i++)  // смотрит до конца строки
                 {
                     if (per[i].EndsWith("|")) // смотрит совпадает ли этот символ
                     {
                         per[i] = per[i].Replace("+|", "");  //убрал часть модуля перед число и сделал пустоту
                         string per2 = per[i];               // чмсло
                         per2 = per2.Replace("-", "|-");     // убирает минус перед число и после остаток модуля и минус
                         string per3 = per2;                 // число
                         Console.Write(per2);
                         per3 = per3.Replace("-", "");   // убирает минус и меняет на пустоту
                         Console.WriteLine("Модуль числа " + per3);  // число без модуля и минуса
                     }
                 }
                */
            } // 4 задание

            {
                Console.WriteLine("Массив чисел в диапозоне от -100 до 100:");
                int[,] numbers = new int[5, 10];  // задаются строки и столбцы
                Random ran = new Random(); // задаем переменую для рандомных чисел 
                var check = new HashSet<int>(); // будет смотреть дубль числа

                for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
                {
                    for (int j = 0; j < numbers.GetLength(1); j++) // numbers.GetLength(1) столбцы 10
                    {
                        int Numbers;
                        Numbers = ran.Next(-100, 100); // генерирует рандомные числа
                        while (check.Contains(Numbers))  // если находит такоеже число то его пересоздает 
                        {
                            Numbers = ran.Next(-100, 100); // если есть дубль то по новой
                        }
                        check.Add(Numbers);     // если нету дубля то дальше
                        numbers[i, j] = Numbers;

                    }
                }

                for (int i = 0; i < numbers.GetLength(0); i++) //задает строки
                {
                    for (int j = 0; j < numbers.GetLength(1); j++) // задает столбцы
                    {
                        Console.Write($" |{numbers[i, j]} \t"); // выводит получившийся результат

                    }
                    Console.WriteLine();

                }

                Console.WriteLine("____________________________________________________________________________________");   // разделяет 

                Console.WriteLine("");
                for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
                {
                    double min = int.MaxValue;          //перменная которая смотрит минимальное значение из отрицательных
                    for (var j = 0; j < numbers.GetLength(1); j++) //  столбцы 10
                    {
                        if (numbers[i, j] < min)        // смотрит минимальное по каждой строке
                        {
                            min = numbers[i, j];        // Минимальное
                        }

                    }
                    Console.WriteLine("Минимальное значение: " + min);      //выводим все минимальные
                }
                Console.WriteLine("____________________________________________________________________________________");   // разделяет 

                Console.WriteLine();
                for (int i = 0; i < numbers.GetLength(0); i++)    // numbers.GetLength(0) сьроки 5        
                {
                    double max = int.MinValue;          //перменная которая смотрит минимальное значение из отрицательных
                    for (var j = 0; j < numbers.GetLength(1); j++)   //  столбцы 10   
                    {
                        if (numbers[i, j] > max)        // смотрит максимальное 
                        {
                            max = numbers[i, j];        // Максимальное
                        }

                    }
                    Console.WriteLine("Максимальное значение: " + max);         //выводим все максимальные
                }

                Console.WriteLine("____________________________________________________________________________________");    // разделяет 

                Console.WriteLine("");
                for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
                {
                    double min = int.MaxValue;          //перменная которая смотрит минимальное значение из отрицательных
                    for (var j = 0; j < numbers.GetLength(1); j++) //  столбцы 10
                    {
                        if (numbers[i, j] < min)        // смотрит минимальное по каждой строке
                        {
                            min = numbers[i, j];        // Минимальное
                        }

                    }
                    Console.WriteLine("Минимальное значение: " + min);      //выводим все минимальные
                    Console.WriteLine("____________________________________________________________________________________");   // разделяет 

                    for (int j = -10; j < 10; j++)      // диапозон просчета
                    {
                        Console.WriteLine();
                        double sin = Math.Sin(j * min);         //синус
                        double cos = Math.Cos(j * min);         //косинус
                        double tan = Math.Tan(j * min);         // тангенс
                        double sin2 = Math.Round(sin, 2);       // округляет значения до 2 знаков после запятой
                        double cos2 = Math.Round(cos, 2);
                        double tan2 = Math.Round(tan, 2);

                        Console.Write(sin2 + "s\t");
                        Console.Write(cos2 + "c\t");
                        Console.Write(tan2 + "t\t");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("____________________________________________________________________________________");  // разделяет 

                double[] per = new double[5];       // строки
                for (int i = 0; i < numbers.GetLength(0); i++)         // смотрит 5 строк
                {
                    double ss = 0;
                    for (int j = 0; j < numbers.GetLength(1); j++) // столбы
                    {
                        ss += Math.Abs(numbers[i, j]); // обсолютное значение по горизантале и вертикале 
                        ss /= 10; // с 10 столбцов среднее арифмитическое 
                    }
                    per[i] = ss; // строка равна столбам
                    Console.WriteLine("Среднее значение по строке: " + per[i]);
                }

                Console.WriteLine("____________________________________________________________________________________");  // разделяет 

                double Min = double.MaxValue;       //новые перемные мксимума и минимума
                double Max = double.MinValue;
                for (int i = 0; i < numbers.GetLength(0); i++)   // строки
                {
                    if (per[i] < Min) // минимальное значение берет из строки
                    {
                        Min = per[i];
                    }
                }
                for (int i = 0; i < numbers.GetLength(0); i++)   // строки
                {
                    if (per[i] > Max)   // максимальное значение берет из строки
                    {
                        Max = per[i];
                    }
                }
                Console.Write("Минимальное значение: " + Min); // из придыдущего берет минимальное по строке
                Console.WriteLine();
                Console.Write("Максимальное значение: " + Max); // из придыдущего берет максимальное по строке
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Среднее арифмитическое в cos, sin, tangens");
                for (int j = -10; j < 10; j++)     // берем от минимума
                {
                    double sin = Math.Sin(j * Min);         //синус среднего
                    double cos = Math.Cos(j * Min);         //косинус среднего
                    double tan = Math.Tan(j * Min);         // тангенс среднего
                    double sin2 = Math.Round(sin, 2);       // округляет значения до 2 знаков после запятой
                    double cos2 = Math.Round(cos, 2);
                    double tan2 = Math.Round(tan, 2);
                    Console.WriteLine("");
                    Console.Write(sin2 + "\t");
                    Console.Write(cos2 + "\t");
                    Console.Write(tan2 + "\t");
                }
            } // 5 задание
        }
    }
}
