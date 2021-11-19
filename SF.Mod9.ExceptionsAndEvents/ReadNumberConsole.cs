using System;

namespace SF.Mod9.Events
{
    /// <summary>
    /// Класс, обрабатывающий логику ввода пользователем данных
    /// </summary>
    public class ReadNumberConsole
    {
        /// <summary>
        /// делегат обрабатывающий ввод числа
        /// </summary>
        /// <param name="number">Число введенное пользователем в консоли</param>
        /// <param name="arraySurnames">Массив фамилий для сортировки</param>
        public delegate void NumberEnteredHandler(int number, string[] arraySurnames);

        /// <summary>
        /// Событие ввода числа
        /// </summary>
        public event NumberEnteredHandler NumberEnteredHandlerNotify;

        /// <summary>
        /// Читаем введенное число из консоли
        /// </summary>
        /// <param name="arraySurnames">Массив фамилий для сортировки</param>
        public void ReadNumber(string[] arraySurnames)
        {
            Console.WriteLine("Для сортировки списка введите 1 - сортировка по возрастанию (от А до Я), 2 - сортировка по убыванию (от Я до А)");
            var number = Convert.ToInt32(Console.ReadLine());

            // проверяем, что ввел пользователь именно 1 или 2. Если нет, выбрасываем исключение
            if (number != 1 && number != 2)
            {
                throw new FormatException();
            }

            this.NumberEntered(number, arraySurnames);
        }

        /// <summary>
        /// Метод для вызова события
        /// </summary>
        /// <param name="number">введенное пользователем число</param>
        /// <param name="arraySurnames">Массив фамилий для сортировки</param>
        protected virtual void NumberEntered(int number, string[] arraySurnames)
        {
            this.NumberEnteredHandlerNotify?.Invoke(number, arraySurnames);
        }
    }
}
