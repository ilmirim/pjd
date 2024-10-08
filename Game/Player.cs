using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Player : Entity
    {
        public Point Force {
            get => Force; 
            set
            {
                var tempPoint = value;
                if (tempPoint.X > Speed) tempPoint = new Point(Speed, tempPoint.Y);
                if (tempPoint.Y > Speed) tempPoint = new Point(tempPoint.X, Speed);
                Force = new Point(tempPoint.X - 1, tempPoint.Y - 1);
            }
        }
        public Player(Point _coordinates, Figure _visual, Figure _collider, int _speed) : base(_coordinates, _visual, _collider, _speed)
        {
            
        }
    }
}
