using System;
using System.Globalization;

namespace uppggift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string fortsätt = "";
            string[] svar = new string[10] {"Ja", "Nej", "Definitivt", "Definitivt inte", "Kanske", "Förmodligen", "Förmodligen inte", "Otroligt", "Potensiellt", "Möjligtvis"};
            do
            {
                Console.WriteLine("Vill du ställa en fråga till och avsluta? Skriv då ja");
                fortsätt = Console.ReadLine();
                Console.WriteLine("Ställ din fråga");
                string fråga = Console.ReadLine();
                Console.WriteLine(svar[slump.Next(10)]);
            } while (fortsätt != "ja");
        }
    }
}
