using System;

namespace SF.Mod9.Events
{
    /// <summary>
    /// Класс, обрабатывающий логику ввода пользователем числа в консоль
    /// </summary>
    public class ReadUserNumber
    {
        /// <summary>
        /// делегат обрабатывающий ввод числа
        /// </summary>
        /// <param name="number">Число введенное пользователем в консоли</param>
        public delegate void NumberEnteredHandler(int number);

        /// <summary>
        /// Событие ввода числа
        /// </summary>
        public event NumberEnteredHandler NumberEnteredHandlerNotify;

        /// <summary>
        /// Читаем введенное число из консоли
        /// </summary>
        public void ReadNumber()
        {
            Console.WriteLine("Для сортировки списка введите 1 - сортировка по возрастанию (от А до Я), 2 - сортировка по убыванию (от Я до А)");
            var number = Convert.ToInt32(Console.ReadLine());

            // проверяем, что ввел пользовател именно 1 или 2. Если нет, выбрасываем исключение
            if (number != 1 && number != 2)
            {
                throw new FormatException();
            }
   
            this.NumberEntered(number);
        }

        /// <summary>
        /// Метод для вызова события
        /// </summary>
        /// <param name="number">введенное пользователем число</param>
        protected virtual void NumberEntered(int number)
        {
            this.NumberEnteredHandlerNotify?.Invoke(number);
        }
    }
}
