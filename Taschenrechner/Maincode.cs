using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{

    class ProgramCalculator
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Konsolen Taschenrechner in C#\r");
            Console.WriteLine("------------------------\n");

            //Abfrage Operationen als Liste oder Array (switch-case) 

            //static void ListOperations()
            //hier alles mit einer Liste machen 

            //static void ArrayOperation() 
            //hier alles mit Array machen 



            while (!endApp)
            {
                // NumberInputs Funktion aufrufen
                double[] numbers = NumberInput.GetNumbersFromUser("Gib die Nummern ein. Trenne Zahlen mit Leerzeichen und bestätige mit Enter.\n(Verwende Punkt oder Komma als Dezimaltrennzeichen): \n ", ' ');

                double result = 0;

                PrintMenu(); // PrintMenu aufrufen

                string op = Console.ReadLine();



                try
                {
                    result = SwitchAuswahl.DoOperation(numbers, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Diese Operation ist mathematisch nicht korrekt.\n");
                    }
                    else Console.WriteLine("\nDein Ergebnis: {0:0.##}\n", result);
                }

            
                catch (ArgumentException ex)
                {
                    Fehlerbehandlung.HandleError(ex);
                }
                catch (DivideByZeroException ex)
                {
                    Fehlerbehandlung.HandleError(ex);
                }
              

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Drücke 'n' und Enter um die App zu schließen, oder eine beliebige Taste um fortzufahren: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }




        public static void PrintMenu()
        {
            Console.WriteLine("\nWähle einen der folgenden Operanten:\n");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraktion");
            Console.WriteLine("\tm - Multiplikation");
            Console.WriteLine("\td - Division");
            Console.Write("\nDeine Wahl:  ");
        }


    }
}