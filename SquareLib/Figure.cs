using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public abstract class Figure
    {
        private readonly double _square;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => _square;

        protected Figure()
        {
            _square = GetSquare();
        }
        public abstract double GetSquare();
    }
}
