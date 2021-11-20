using System;
using System.Text.RegularExpressions;

namespace SF.Mod9.Events
{
    /// <summary>
    /// Program for SF Mod 9 events example
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main code
        /// </summary>
        public static void Main()
        {
            ReadNumberConsole readUserNumber = new ReadNumberConsole();
            readUserNumber.NumberEnteredHandlerNotify += SortNumber;

            try
            {
                do
                {
                    Console.WriteLine("Ввод фамилий:");
                    var arraySurname = GetArrayFromConsole();
                    readUserNumber.ReadNumber(arraySurname);
                    Console.WriteLine("Для выхода нажмите <Esc>, для повтора любую клавишу");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (SurnameException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Введено некорректное значение " + e.Message);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка, обратитесь к разработчику " + e.Message);
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Сортируем массив в зависимости от введенного числа пользователем
        /// </summary>
        /// <param name="number">число введенное пользователем, определяющее сортировку</param>
        /// <param name="arraySurname">массив фамилий для сортировки</param>
        public static void SortNumber(int number, string[] arraySurname)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение 1, сортировка от А до Я");

                    // сортировка от А до Я
                    Array.Sort(arraySurname);
                    break;

                case 2:
                    Console.WriteLine("Введено значение 2, сортировка от Я до А");

                    // сортировка от Я до А
                    Array.Sort(arraySurname);
                    Array.Reverse(arraySurname);
                    break;
            }

            foreach (var item in arraySurname)
            {
                Console.Write(item + " ");
            }
        }

        /// <summary>
        /// Ввод массива из 5 фамилий через консоль
        /// </summary>
        /// <param name="num">число элементов массива, по умолчанию 5.</param>
        /// <returns>Возвращаем массив фамилий</returns>
        public static string[] GetArrayFromConsole(int num = 5)
        {
            var result = new string[num];
            for (var i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите фамилию пользователя номер {0} с большой буквы", i + 1);
                string surname = Console.ReadLine();

                // Проверяем введенную строку, если она не подходит под регулярное выражение, то просто грубо выдаем наше исключение
                result[i] = CheckSurname(surname) ? surname : throw new SurnameException("Ошибка ввода фамилии - " + surname + " - это не фамилия!");
            }

            return result;
        }

        /// <summary>
        /// Проверка ввода фамилии по регулярному выражению
        /// </summary>
        /// <param name="surname">введенная фамилия</param>
        /// <returns>возвращаем true или false по результату проверки</returns>
        public static bool CheckSurname(string surname)
        {
            // регулярное выражение на проверку фамилии
            Regex regex = new Regex("^[А-Я][а-я]*$");
            return regex.IsMatch(surname);
        }
    }
}
