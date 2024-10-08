using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Figure
    {
        public enum FigureType
        {
            square,
            circle
        }
        private FigureType type;
        private int size;
        public FigureType Type => type;
        public int Size => size;

        public Figure(FigureType _type = FigureType.square, int _size = 25) 
        {
            size = _size;
            type = _type;  
        }
    }
}
