using System;

namespace SquareLib
{
    public class Circle: Figure
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                if (value >= 0)
                {
                    _r = value;
                }
                else
                {
                    Console.WriteLine("Радиус не может быть отрицательным");
                }
            }
        }

        public Circle()
        {
            _r = 0;
        }

        public Circle(double r)
        {
            if (r >= 0)
            {
                this._r = r;
            }
            else
            {
                Console.WriteLine("Радиус должен быть неотрицательным!");
            }
        }

        public override double GetSquare()
        {
            return Math.PI * _r * _r;
        }
    }
}
