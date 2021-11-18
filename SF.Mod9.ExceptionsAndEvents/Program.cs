using System;

namespace SF.Mod9.ExceptionsAndEvents
{
    /// <summary>
    /// Program for SF Mod 9 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main code
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Введено некорректное значение " + e.Message);
                throw;
            }
        }
    }
}
