using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod9.Events
{
    /// <summary>
    /// Создали класс собственного исключения для проверки Фамилии на вводе
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
