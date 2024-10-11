using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Player : Entity
    {
        private int width = 1280;
        private int height = 720;
        private Point force;
        public Point Force {
            get
            {
                Point fforce = force;
                force = new Point(force.X - 1, force.Y - 1);
                return fforce;
            }
            set
            {
                force = new Point(value.X > Speed ? Speed : value.X, value.Y > Speed ? Speed : value.Y);
            }
        }
        public override Point Position 
        {
            get => new Point(X, Y);
            set
            {
                X = Math.Max(Math.Min(value.X, 1280 - 40), 0);
                Y = Math.Max(Math.Min(value.Y, 720 - 65), 0);
            }

        }
        public Player(int _width, int _height, Point _coordinates, Figure _visual, Figure _collider, int _speed) : base(_coordinates, _visual, _collider, _speed)
        {
            width = _width;
            height = _height;
        }
    }
}
