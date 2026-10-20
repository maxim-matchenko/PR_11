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
        public static void Main(String[] args)
        {
            Console.Title = "Практическая работа №11";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = Encoding.UTF8; // важно 
            Console.Clear(); // Очистка консоли
            int index;
            string select;
            string sourceText; //исходный текст 
            string tangetSubstring;//целевая подстрока
            Console.WriteLine("Здравствуйте!");
            do // внешний цикл для повторного запуска 
            {
                Console.WriteLine("\n--- Новый расчет ---");
                while (true)// Цикл ввода строки sourceText
                {
                    try
                    {
                        Console.Write("Введите строку sourceText: ");
                        sourceText = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(sourceText))
                        {
                            throw new ArgumentException("Строка не может быть пустой или состоять только из пробелов");
                        }
                        break; // Выход из цикла ввода sourceText
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Возникла ошибка: " + e.Message);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Пожалуйста, повторите ввод.\n");
                    }
                }
                while (true)// Цикл ввода подстроки tangetSubstring
                {
                    try
                    {
                        Console.Write("Введите подстроку tangetSubstring: ");
                        tangetSubstring = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(tangetSubstring))
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
                while ((index = sourceText.IndexOf(tangetSubstring)) >= 0)
                {
                    sourceText = sourceText.Remove(index, tangetSubstring.Length);
                }
                Console.WriteLine("Преобразованная строка: " + sourceText);
                Console.Write("\nХотите выполнить программу еще раз? (да - 1/нет - любая клавиша): ");
                select = Console.ReadLine();
            }
            while (select == "1");
            Console.WriteLine("\nПрограмма завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
