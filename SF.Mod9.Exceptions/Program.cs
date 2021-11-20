using System;

namespace SF.Mod9.Exceptions
{
    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main()
        {
            // создали массив исключений, вызвали и перехватили каждое исключение в цикле
            Exception[] exceptions = { new ArgumentNullException(), new ArgumentOutOfRangeException(), new IndexOutOfRangeException(), new DivideByZeroException(), new MyException4Exaple() };
            for (var i = 0; i < 5; i++)
            {
                try
                {
                    throw exceptions[i]; 
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Ошибка № " + i + "   " + e.Message);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Ошибка № " + i  + "   " + e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Ошибка № " + i + "   " + e.Message);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Ошибка № " + i + "   " + e.Message);
                }
                catch (MyException4Exaple e)
                {
                    Console.WriteLine("Ошибка № " + i + "   " + e.Message);
                }
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Собственное исключение
    /// </summary>
    public class MyException4Exaple : Exception
    {
    }
}
