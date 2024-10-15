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
        public int Speed
        { 
            get => speed; 
            set => speed = value < 1 ? 1 : value;
        }
        public virtual Point Position
        {
            get => new Point(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }
        public Entity(Point _coordinates, Figure _visual, Figure _collider, int _speed) 
        {
            X = _coordinates.X;
            Y = _coordinates.Y;
            visualFigure = _visual;
            colliderFigure = _collider;
            Speed = _speed;
        }
        public Entity(int _speed)
        {
            X = 0;
            Y = 0;
            visualFigure = new Figure();
            colliderFigure = new Figure();
            Speed = _speed;
        }
    }
}
