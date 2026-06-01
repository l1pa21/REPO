using System.Globalization;
using System;

namespace PhoneCallStruct
{
    public struct PhoneCall
    {
        private const double eps = 1e-10;

        private int time;
        public int Time
        {
            get => time;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Время должно быть положительным");

                time = value;
            }
        }

        private double rate;
        public double Rate
        {
            get => rate;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Тариф должен быть положительным");

                rate = value;
            }
        }

        public double Cost
        {
            get => Math.Round(Time / 60.0 * Rate, 2);
        }

        public PhoneCall(int time, double rate) : this()
        {
            Time = time;
            Rate = rate;
        }

        public override string ToString()
        {
            return $"Разговор: {Time} c по {Rate.ToString(CultureInfo.InvariantCulture)} руб./мин";
        }

        public override bool Equals(object obj)
        {
            if (obj is PhoneCall other)
            {
                return Time == other.Time &&
                       Math.Abs(Rate - other.Rate) < eps;
            }

            throw new ArgumentException("Объект не является PhoneCall");
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Time.GetHashCode();
                hash = hash * 23 + Rate.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(PhoneCall a, PhoneCall b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(PhoneCall a, PhoneCall b)
        {
            return !a.Equals(b);
        }

        public static PhoneCall operator +(PhoneCall a, PhoneCall b)
        {
            if (Math.Abs(a.Rate - b.Rate) > eps)
                throw new ArgumentException("Тарифы должны совпадать");

            return new PhoneCall(a.Time + b.Time, a.Rate);
        }

        public static PhoneCall operator *(PhoneCall call, double k)
        {
            if (k <= 0)
                throw new ArgumentException("Коэффициент должен быть положительным");

            return new PhoneCall(call.Time, call.Rate * k);
        }

        public static PhoneCall operator *(double k, PhoneCall call)
        {
            return call * k;
        }
    }
}