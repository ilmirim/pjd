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
        public int Size
        {
            get => size;
            set
            {
                size = value < 1 ? 1 : value;
            }
        }

        public Figure(FigureType _type = FigureType.square, int _size = 25) 
        {
            size = _size;
            type = _type;  
        }
        public Figure(int _size)
        {
            size = 25;
            type = FigureType.square;
        }
        public Figure()
        {
            size = 25;
            type = FigureType.square;
        }
    }
}
