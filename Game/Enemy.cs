using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Enemy : Entity
    {
        private Point direction;
        private int remainingLifetime;
        private int lifetimeInMilliseconds;

        public Point Direction => direction;
        public bool IsAlive => remainingLifetime > 0;

        public Enemy(int lifetimeInSeconds, Point direction, Point coordinates, Figure visual, Figure collider, int speed = 1)
            : base(coordinates, visual, collider, speed)
        {
            this.direction = direction;
            this.lifetimeInMilliseconds = lifetimeInSeconds * 100; // Изменение на 100 для более точного контроля времени
            this.remainingLifetime = lifetimeInMilliseconds;
        }

        public void Update(int deltaTime)
        {
            remainingLifetime -= deltaTime;
        }
    }
}
