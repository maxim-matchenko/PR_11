//****************************************************************************
//* Практическая работа N11                                                  *
//* Выполнил: Матченко M.C., группа 2-ИСП-оКФ                                *
//* Вариант 3                                                                *
//* Задание: Основные структуры языка: символы и строки                      *
//****************************************************************************
using System;
namespace PR_11
{    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Практическая работа №11"; 
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear(); // Очистка консоли
            Console.WriteLine("Здравствуйте!");
            try
            {
                string Select;// Переменная для контроля повторного запуска
                do // внешний цикл для повторного запуска 
                {
                    Console.WriteLine("\n--- Новый расчет ---");
                    Console.Write("Введите строку S: ");
                    string S = Console.ReadLine();
                    if (string.IsNullOrEmpty(S))
                    {
                        throw new ArgumentException("Строка не может быть пустой"); // частное исключение
                    }
                    Console.Write("Введите подстроку S1: ");
                    string S1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(S1))
                    {
                        throw new ArgumentException("Строка не может быть пустой"); // частное исключение
                    }
                    if (S.Contains(S1))
                        S = S.Replace(S1, "_");
                    Console.WriteLine("Преобразованная строка: " + S);
                    Console.Write("\nХотите выполнить программу еще раз? (да - 1/нет - любая клавиша): ");
                    Select = Console.ReadLine();
                }
                while (Select == "1");
            }                   
            catch (Exception e) // обработка исключений 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nВозникла ошибка: " + e.Message);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ReadKey();
            }
            Console.WriteLine("\nПрограмма завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
