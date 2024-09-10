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
        private MapSystem map;
        private GameForm game;
        private Control player;
        public Player(GameForm _gameForm ,MapSystem _map, int _hp = 1, int _damage = 1) : base(_hp, _damage)
        {
            game = _gameForm;
            map = _map;
            Spawn();
        }

        public void Position(Point _position)
        {
            player.Location = new Point(player.Location.X + _position.X, player.Location.Y + _position.Y);
        }

        public void Spawn()
        {
            Panel _player = new Panel();
            _player.Size = new System.Drawing.Size(50, 50);
            _player.Location = new Point((1280 - _player.Width) / 2, (720 - _player.Height) / 2);
            game.Controls.Add(_player);
            player = _player;
            player.BringToFront();
        }
    }
}
