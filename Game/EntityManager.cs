using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class EntityManager
    {
        private MapSystem map;
        private GameForm game;
        private Control player;

        public EntityManager()
        {

        }

        public void SpawnPlayer()
        {
            Panel _player = new Panel();
            _player.Size = new Size(50, 50);
            _player.Location = new Point((1280 - _player.Width) / 2, (720 - _player.Height) / 2);
            game.Controls.Add(_player);
            player = _player;
            player.BringToFront();
        }
    }
}
