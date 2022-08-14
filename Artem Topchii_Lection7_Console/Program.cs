using System;

namespace Artem_Topchii_Lection7_Console
{
    class Program
    {
        static void Main()
        {
            ClassDollars firstValue = new ClassDollars(120, 125);
            ClassDollars secondValue = new ClassDollars(25, 125);
            ClassDollars result = new ClassDollars();

            result = firstValue - secondValue;
        }
    }
}
