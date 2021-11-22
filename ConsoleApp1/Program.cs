using System;

namespace ConsoleApp1
{
    class Program
    {
        /// Poszczególne funkcjonalności uruchamiamy komentowaniem/odkomentowaniem linijek kodu.
        static void Main(string[] args)
        {
            ExceptionMaker.ThrowException();

            //// Miejsce pojawienia się wyjątku, to nie jest miejsce, gdzie należy dokonać poprawki.
            //new HardException(new int[] { 2, 1, 3, 7 }).DisplayValues();
            //new HardException().DisplayValues();

            //// Źródło wyjątku prowadzi nas do metody, która jest bezpośrednim sprawcą.
            //EasyException.ReadFile("");

            Console.WriteLine("Hello World!");
        }
    }
}
