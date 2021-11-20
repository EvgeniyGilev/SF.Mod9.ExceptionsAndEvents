using System;

namespace SF.Mod9.Events
{
    /// <summary>
    /// Создали класс собственного исключения для проверки фамилии на вводе
    /// </summary>
    public class SurnameException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurnameException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public SurnameException(string message) : base(message)
        {
        }
    }
}
