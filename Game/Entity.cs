using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public class Entity
    {
        public int X, Y;
        private Figure visualFigure, colliderFigure;
        private int speed;
        public Figure VisualFigure => visualFigure;
        public Figure ColliderFigure => colliderFigure;
        public int Speed => speed;
        public Entity(Point _coordinates, Figure _visual, Figure _collider, int _speed) 
        {
            X = _coordinates.X;
            Y = _coordinates.Y;
            visualFigure = _visual;
            colliderFigure = _collider;
            speed = _speed;
        }
    }
}
