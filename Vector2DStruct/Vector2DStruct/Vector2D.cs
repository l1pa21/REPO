using System;

namespace Vector2DStruct
{
    public struct Vector2D
    {
        private const double Eps = 1e-10;

        public double X { get; set; }

        public double Y { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}; {Y})";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector2D))
                throw new ArgumentException();

            Vector2D other = (Vector2D)obj;

            return Math.Abs(X - other.X) < Eps
                && Math.Abs(Y - other.Y) < Eps;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(Vector2D a, Vector2D b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Vector2D a, Vector2D b)
        {
            return !a.Equals(b);
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(
                a.X + b.X,
                a.Y + b.Y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(
                a.X - b.X,
                a.Y - b.Y);
        }

        public static Vector2D operator *(Vector2D a, double k)
        {
            return new Vector2D(
                a.X * k,
                a.Y * k);
        }

        public static Vector2D operator *(double k, Vector2D a)
        {
            return a * k;
        }

        public static double operator *(Vector2D a, Vector2D b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
    }
}