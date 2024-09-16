using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class Player : Entity
    {
        private Control player;
        private Point location
        {
            get
            {
                return player.Location;
            }
            set
            {
                if (value.X > Form.ActiveForm.Width - player.Width)
                {
                    player.Location = new Point(Form.ActiveForm.Width - player.Width, player.Location.Y);
                }
                else if (value.Y > Form.ActiveForm.Height - player.Height)
                {
                    player.Location = new Point(player.Location.X, Form.ActiveForm.Height - player.Height);
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
        public Player(Control _player, EntityType _type = EntityType.player, int _hp = 1, int _damage = 1) : base(_type, _hp, _damage)
        {
            player = _player;
        }

        public void PlusPosition(Point _position)
        {
            location = new Point(player.Location.X + _position.X, player.Location.Y + _position.Y);
        }
    }
}
