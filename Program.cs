//****************************************************************************
//* Практическая работа N11                                                  *
//* Выполнил: Матченко M.C., группа 2-ИСП-оКФ                                *
//* Вариант 3                                                                *
//* Задание: Основные структуры языка: символы и строки                      *
//****************************************************************************
using System;
using System.Text;
namespace PR_11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Практическая работа №11";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = Encoding.UTF8; // важно 
            Console.Clear(); // Очистка консоли
            int index;
            string select;// переменная для контроля повторного запуска
            string str1;// строка
            string str2;//подстрока
            Console.WriteLine("Здравствуйте!");
            do // внешний цикл для повторного запуска 
            {
                Console.WriteLine("\n--- Новый расчет ---");
                while (true)// Цикл ввода строки str1
                {
                    try
                    {
                        Console.Write("Введите строку str1: ");
                        str1 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(str1))
                        {
                            throw new ArgumentException("Строка не может быть пустой или состоять только из пробелов");
                        }
                        break; // Выход из цикла ввода str1
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Возникла ошибка: " + e.Message);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Пожалуйста, повторите ввод.\n");
                    }
                }
                while (true)// Цикл ввода подстроки str2
                {
                    try
                    {
                        Console.Write("Введите подстроку str2: ");
                        str2 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(str2))
                        {
                            throw new ArgumentException("Строка не может быть пустой или состоять только из пробелов");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Возникла ошибка: " + e.Message);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Пожалуйста, повторите ввод.\n");
                    }
                }
                // Удаление подстроки 
                while ((index = str1.IndexOf(str2)) >= 0)
                {
                    str1 = str1.Remove(index, str2.Length);
                }
                Console.WriteLine("Преобразованная строка: " + str1);
                Console.Write("\nХотите выполнить программу еще раз? (да - 1/нет - любая клавиша): ");
                select = Console.ReadLine();
            }
            while (select == "1");
            Console.WriteLine("\nПрограмма завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
