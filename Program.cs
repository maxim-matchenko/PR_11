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
            string select;
            string S;
            string S1;
            Console.WriteLine("Здравствуйте!");
            do // внешний цикл для повторного запуска 
            {
                Console.WriteLine("\n--- Новый расчет ---");
                while (true)// Цикл ввода строки S
                {
                    try
                    {
                        Console.Write("Введите строку S: ");
                        S = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(S))
                        {
                            throw new ArgumentException("Строка не может быть пустой или состоять только из пробелов");
                        }
                        break; // Выход из цикла ввода S
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Возникла ошибка: " + e.Message);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Пожалуйста, повторите ввод.\n");
                    }
                }
                while (true)// Цикл ввода подстроки S1
                {
                    try
                    {
                        Console.Write("Введите подстроку S1: ");
                        S1 = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(S1))
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
                while ((index = S.IndexOf(S1)) >= 0)
                {
                    S = S.Remove(index, S1.Length);
                }
                Console.WriteLine("Преобразованная строка: " + S);
                Console.Write("\nХотите выполнить программу еще раз? (да - 1/нет - любая клавиша): ");
                select = Console.ReadLine();
            }
            while (select == "1");
            Console.WriteLine("\nПрограмма завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
