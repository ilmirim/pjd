using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Player : Entity
    {
        private Control player;
        private int width, height;
        private Point location
        {
            get
            {
                return player.Location;
            }
            set
            {
                if (value.X > width - player.Width)
                {
                    player.Location = new Point(width - player.Width, player.Location.Y);
                }
                else if (value.Y > height - player.Height)
                {
                    player.Location = new Point(player.Location.X, height - player.Height);
                }
                else if (value.Y < 0)
                {
                    player.Location = new Point(player.Location.X, 0);
                }
                else if (value.X < 0)
                {
                    player.Location = new Point(0, player.Location.Y);
                }
                else
                {
                    player.Location = value;
                }
            }
        }
        public Player(GameForm _gameForm, Control _player, EntityType _type = EntityType.player, int _hp = 1, int _damage = 1) : base(_type, _hp, _damage)
        {
            player = _player;
            width = _gameForm.Width;
            height = _gameForm.Height;
        }

        public void PlusPosition(Point _position)
        {
            location = new Point(player.Location.X + _position.X, player.Location.Y + _position.Y);
        }
    }
}
