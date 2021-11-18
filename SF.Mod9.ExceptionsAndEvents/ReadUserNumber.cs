using System;

namespace SF.Mod9.ExceptionsAndEvents
{
    /// <summary>
    /// Класс, обрабатывающий логику ввода пользователем числа в консоль
    /// </summary>
    public class ReadUserNumber
    {
        // делегат
        public delegate void NumberEnteredHandler(int number);

        // событие
        public event NumberEnteredHandler NumberEnteredHandlerNotify;

        /// <summary>
        /// Читаем введенное число из консоли
        /// </summary>
        public void ReadNumber()
        {
            Console.WriteLine("Для сортировки списка введите 1 - сортировка по возрастанию, 2 - сортировка по убыванию");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

        }
    }
}
