using System;
using System.Collections.Generic;
using System.Linq;

namespace Taschenrechner
{
    class SwitchAuswahl
    {
        public static double DoOperation(IEnumerable<double> numbers, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = numbers.Sum();
                    break;

                case "s":

                    if (numbers.Count() < 2)   // Gibt es 2 Zahlen die Subtrahiert werden können?
                    {
                        throw new ArgumentException("Subtraktion erfordert mindestens zwei Zahlen."); // Wenn nicht wird die Exception ausgeworfen
                    }
                    return numbers.First() - numbers.Skip(1).Sum();

                case "m":
                    result = numbers.Aggregate((a, b) => a * b);
                    break;

                case "d":
                    if (numbers.Skip(1).Any(num => num == 0))  // Wenn irgendeine Zahl 0  ist wird die Exception geworfen
                    {
                        throw new DivideByZeroException("Durch 0 teilen ist nicht möglich");
                       
                    }
                    return numbers.First() / numbers.Skip(1).Aggregate((a, b) => a / b);

                default:

                    throw new InvalidOperationException("Ungültige Operation ausgewählt");
                    // Invalid-Operation Exception
                    break;
            }

            return result;
        }
    }
}