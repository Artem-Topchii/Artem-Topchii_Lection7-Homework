using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artem_Topchii_Lection7_Console
{
    class ClassDollars
    {
        private int _dollars = 0;
        private int _cents = 0;

        public ClassDollars()
        {
            Dollars = 0;
            Cents = 0;
        }

        public ClassDollars(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public int Dollars
        {
            get => _dollars;
            set
            {
                if(value >= 0)
                {
                    _dollars = value;
                }
                else
                {
                    throw new ArgumentException("Enter positive value");
                }
            }
        }
        
        public int Cents
        {
            get => _cents;
            set
            {
                if(value >= 0)
                {
                    _cents = value;
                }
                else
                {
                    throw new ArgumentException("Enter positive value");
                }

                if(_cents >= 100)
                {
                    _dollars += _cents / 100;
                    _cents %= 100;
                }
            }
        }

        public static ClassDollars operator +(ClassDollars firstValue, ClassDollars secondValue)
        {
            ClassDollars result = new ClassDollars(0, 0);

            result._dollars = firstValue._dollars + secondValue._dollars;
            result._cents = firstValue._cents + secondValue._cents;

            return result;
        }

        public static ClassDollars operator -(ClassDollars firstValue, ClassDollars secondValue)
        {
            ClassDollars result = new ClassDollars();

            result._dollars = firstValue._dollars - secondValue._dollars;
            result._cents = firstValue._cents - secondValue._cents;

            return result;
        }

        public override string ToString()
        {
            return $"{Dollars}.{Cents} {nameof(Dollars)}";
        }
    }
}
