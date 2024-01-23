using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    internal class Fehlerbehandlung
    {
        public static void HandleError(Exception ex)
        {
           if (ex is ArgumentException)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            }

           else if (ex is DivideByZeroException)
            {
                Console.WriteLine("Fehler! Division durch 0  nicht möglich");
            }

           else if (ex is InvalidOperationException)
            {
                Console.WriteLine("Fehler: Ungültige Operation");
            }
        }

    }
}