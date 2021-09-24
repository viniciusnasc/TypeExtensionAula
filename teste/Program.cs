using System;
using System.Globalization;
using teste.Extensions;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Vinicius de Souza Nascumento";
            Console.WriteLine(s1.Cut(8));
        }
    }
}
