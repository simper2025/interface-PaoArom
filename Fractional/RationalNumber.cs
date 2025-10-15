using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractional
{
    public class RationalNumber : IEquatable<RationalNumber>, IComparable<RationalNumber>
    {
        int numerator;
        int denominator;

        public RationalNumber(int num, int denom)
        {
            numerator = num;
            denominator = denom;

            var gcd = GreatestCommonDenominator(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        // (from Adam Fall 2020) 
        static int GreatestCommonDenominator(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return GreatestCommonDenominator(b, a % b);
            }
        }
        public bool Equals(RationalNumber? other)
        {
            return other is not null &&
                   numerator * other.denominator == other.numerator * denominator;
        }

        public int CompareTo(RationalNumber? other)
        {
            if (other is null) return 1;
            if (numerator * other.denominator > other.numerator * denominator) return 1;
            else if (numerator * other.denominator < other.numerator * denominator) return -1;
            else return 0;
        }
    }
}