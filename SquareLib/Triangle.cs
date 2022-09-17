using System;

namespace SquareLib
{
    public class Triangle: Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get => _a;
            set
            {
                if (value >= 0)
                {
                    _a = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                }
            }
        }
        public double B
        {
            get => _b;
            set
            {
                if (value >= 0)
                {
                    _b = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                }
            }
        }
        public double C
        {
            get => _c;
            set
            {
                if (value >= 0)
                {
                    _c = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                }
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }
            else
            {
                Console.WriteLine("Некорректные значения сторон");
                this._a = 0;
                this._b = 0;
                this._c = 0;
            }
        }

        public Triangle()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }

        public override double GetSquare()
        {
            double p = (_a + _b + _c) / 2;
            double s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return s;
        }

        public bool IsRectangular()
        {
            return (_a * _a + _b * _b == _c * _c || (_a * _a + _c * _c == _b * _b) || (_c * _c + _b * _b == _a * _a));

        }
    }
}
