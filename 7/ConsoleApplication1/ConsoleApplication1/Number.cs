using System;
using System.Runtime;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    public class Number : IComparable<Number>, IFormattable, IConvertible
    {
        private int A;
        private int B;

        public Number(int a, int b) {
            
            A = a;
            B = b;
            Simple();
        }

        public Number(int digit) {
            A = digit;
            B = 1;
        }

        public Number(string s, string format)
        {
            Regex StandartRegex = new Regex(@"^(-?\d+)/(\d+)$");
            Regex DoubleRegex = new Regex(@"^(-?\d+)[,\.](\d+)$");
            if (format == "Standart")
            {
                Match match = StandartRegex.Match(s);
                int first = int.Parse(match.Groups[1].Value);
                int second = int.Parse(match.Groups[2].Value);
                A = first;
                B = second;
                Simple();
            }

            if (format == "Single")
            {
                A = Convert.ToInt32(s);
                B = 1;
            }

            if (format == "Double")
            { 
                Match match = DoubleRegex.Match(s);
                int integer = int.Parse(match.Groups[1].Value);
                string decimalPart = match.Groups[2].Value;
                int first = (int)Math.Pow(10, decimalPart.Length);
                int second = Math.Abs(int.Parse(decimalPart));
                A = integer * first + second;
                B = first;
                Simple();
            }
        }
        private int Gcd(int a, int b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }

        private void Simple()
        {
            int gcd = Gcd(Math.Abs(A), Math.Abs(B));
            A /= gcd;
            B /= gcd;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Number number = obj as Number;
            if (number == null) return false;
            return this.A == number.A && this.B == number.B;
        }
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return ToString(format);
        }
        public override string ToString()
        {
            return ToString("StdOutput");
        }
        
        public string ToString(string format)
        {
            if (format == null)
            {
                format = "StdOutput";
            }
            switch (format)
            {
                case "StdOutput":
                    return string.Concat(A, "/", B);
                case "CeilOutput":
                    return Math.Ceiling((decimal)A / B).ToString();
                case "DoubleOutput":
                    return ((decimal)A / B).ToString();
                default: return "0";
            }
        }
        public static Number operator *(Number a, Number b)
        {
            return new Number(a.A * b.A, a.B * b.B);
        }
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.A * b.B + b.A * a.B, a.B * b.B);
        }

        public static Number operator -(Number x)
        {
            return new Number(-x.A, x.B);
        }

        public static Number operator -(Number a, Number b)
        {
            return a + -b;
        }

        public static Number operator /(Number a, Number b)
        {
            return new Number(a.A * b.B, a.B * b.A);
        }

        public int CompareTo(Number other)
        {
            int lcm = (B * other.B) / Gcd(B, other.B);
            int first = B * A / lcm;
            int second =  other.B * other.A / lcm;
            return first.CompareTo(second);
        }
        public static bool operator ==(Number a, Number b)
        {
            return a.CompareTo(b) == 0;
        }
        public static bool operator !=(Number a, Number b)
        {
            return a.CompareTo(b) != 0;
        }
        public static bool operator >(Number a, Number b)
        {
            return a.CompareTo(b) > 0;
        }
        public static bool operator <(Number a, Number b)
        {
            return a.CompareTo(b) < 0;
        }
        public static bool operator >=(Number a, Number b)
        {
            return a.CompareTo(b) >= 0;
        }
        public static bool operator <=(Number a, Number b)
        {
            return a.CompareTo(b) <= 0;
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(A, provider);
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(ToDouble(provider), provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(ToDouble(provider), provider);
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime(ToDouble(provider), provider);
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(ToDouble(provider), provider);
        }
        public double ToDouble(IFormatProvider provider)
        {
            return ((double) A) / B;
        }
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(ToDouble(provider), provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(ToDouble(provider), provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(ToDouble(provider), provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(ToDouble(provider), provider);
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(ToDouble(provider), provider);
        }
        public string ToString(IFormatProvider provider)
        {
            return ToString();
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(ToDouble(provider), conversionType, provider);
        }
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(ToDouble(provider), provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(ToDouble(provider), provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(ToDouble(provider), provider);
        }
        public static explicit operator byte(Number number)
        {
            return number.ToByte(null);
        }
        public static explicit operator short(Number number)
        {
            return number.ToInt16(null);
        }
        public static explicit operator int(Number number)
        {
            return number.ToInt32(null);
        }
        public static explicit operator long(Number number)
        {
            return number.ToInt64(null);
        }
        public static explicit operator float(Number number)
        {
            return number.ToSingle(null);
        }
        public static explicit operator double(Number number)
        {
            return number.ToDouble(null);
        }
        public static explicit operator decimal(Number number)
        {
            return number.ToDecimal(null);
        }
    }
}