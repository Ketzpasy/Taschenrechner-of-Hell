using System;
using System.Collections.Generic;
using System.Globalization;

namespace Taschenrechner
{
    internal class NumberInput
    {
        public static double[] GetNumbersFromUser(string promptText, char separator)
        {
            Console.Write(promptText);
            string numInput = Console.ReadLine().Replace(',', separator);

            string[] numArray = numInput.Split(separator);

            double[] numbers = new double[numArray.Length];
            for (int i = 0; i < numArray.Length; i++)
            {
                while (!double.TryParse(numArray[i], NumberStyles.Any, CultureInfo.InvariantCulture, out numbers[i]))
                {
                    Console.Write("Keine zulässige Eingabe. Bitte gib einen Zahlenwert ein: ");
                    numArray[i] = Console.ReadLine();
                }
            }
            return numbers;
        }
    }
}