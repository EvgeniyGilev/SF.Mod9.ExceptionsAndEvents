using System;

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
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            ReadUserNumber readUserNumber = new ReadUserNumber();
            readUserNumber.NumberEnteredHandlerNotify += ShowNumber;

            try
            {
                readUserNumber.ReadNumber();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Введено некорректное значение " + e.Message);
                throw;
            }
        }

        /// <summary>
        /// Вывод в консоль собщения в зависимости от числа, введенного пользователем
        /// </summary>
        /// <param name="number">число введенное пользователем</param>
        private static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Введено значение 1, сортировка от А до Я"); 
                        break;

                case 2: Console.WriteLine("Введено значение 2, сортировка от Я до А"); 
                        break;
            }
        }
    }
}
