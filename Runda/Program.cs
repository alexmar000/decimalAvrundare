using System;

namespace Runda
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNr;    // har två variabler för varje inmatning för senare konvertering.
            string StringNr;
            int UserRound;
            string StringRound;
            double ExitNr;
            double TwoRound;  // variabel för två decimalsavrundning som visas varje gång.
            string enterText = "Hej! Vänligen skriv in det decimaltal ni vill avrunda.";
            string decimalText = "Hur många decimaler vill ni avrunda till?";
            
            Console.WriteLine(enterText);
            StringNr = Console.ReadLine();
            userNr = Convert.ToDouble(StringNr);

            Console.WriteLine(decimalText);
            StringRound = Console.ReadLine();
            UserRound = Convert.ToInt32(StringRound);

           ExitNr = Math.Round(value: (userNr), UserRound);
           Console.WriteLine(ExitNr);

            TwoRound = Math.Round(value: (userNr), 2);
            Console.WriteLine(TwoRound);

            Console.ReadKey();
        }
    }
}
