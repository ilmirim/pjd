using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Enemy:Entity
    {
        private Point direction;
        private int liveTime;
        private int time;
        public Point GetDirection => direction;
        public Enemy(int _livetime, Point _direction, Point _coordinates, Figure _visual, Figure _collider, int _speed = 1) : base(_coordinates, _visual, _collider, _speed)
        {
            time = 0;
            direction = _direction;
            liveTime = _livetime * 50;
        }

        public bool PlusTime()
        {
            time++;
            return CheckTime();
        }
        public bool CheckTime()
        {
            if(time == liveTime)
                return false;
            return true;
        }
    }
}
