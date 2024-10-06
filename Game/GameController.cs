using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Media;

namespace Game
{
    internal class GameController
    {
        private MapSystem map;
        private Player player;
        private Control playerControl;
        private GameForm gameForm;
        private Dictionary<Enemy, Control> entities;
        private Random random;
        private int i;

        public GameController(GameForm _gameForm)
        {
            gameForm = _gameForm;
            map = new MapSystem();
            entities = new Dictionary<Enemy, Control>();
            random = new Random();
        }

        public void Start()
        {
            map.Generate();
            SpawnPlayer();
            i = 0;
        }

        public void MovePlayer(Point _direction)
        {
            player.PlusPosition(_direction);
        }

        public void EnemyLogic()
        {
            foreach (var entity in entities)
            {
                var x = entity.Value.Location.X;
                var y = entity.Value.Location.Y;

                var sizeX = entity.Value.Width;
                var sizeY = entity.Value.Height;
                entity.Value.Location = new Point(x + entity.Key.GetDirection.X, y + entity.Key.GetDirection.Y);
                if(!entity.Key.PlusTime())
                {
                    entity.Value.Dispose();
                    entities.Remove(entity.Key);
                    return;
                }
                if ((x + sizeX > playerControl.Location.X && x < playerControl.Location.X) ||
                    (x + sizeX > playerControl.Location.X + playerControl.Width && x < playerControl.Location.X + playerControl.Width))
                {
                    if((y + sizeY > playerControl.Location.Y && y < playerControl.Location.Y) ||
                    (y + sizeY > playerControl.Location.Y + playerControl.Height && y < playerControl.Location.Y + playerControl.Height))
                    {
                        playerControl.BackColor = Color.Red;
                        LoseGame();
                    }
                }
            }
        }

        private void SpawnPlayer()
        {
            
            PictureBox _playerPanel = new PictureBox();
            _playerPanel.BackColor = Color.Transparent;
            _playerPanel.BackgroundImage = Properties.Resources.ship2;
            _playerPanel.BackgroundImageLayout = ImageLayout.Zoom;
            _playerPanel.Size = new Size(25, 25);
            _playerPanel.Location = new Point((1280 - _playerPanel.Width) / 2, (720 - _playerPanel.Height) / 2);
            gameForm.Controls.Add(_playerPanel);
            player = new Player(gameForm, _playerPanel);
            _playerPanel.BringToFront();
            playerControl = _playerPanel;
        }

        public void SpawnEnemy()
        {
            PictureBox _enemyPanel = new PictureBox();
            int size = random.Next(25, 100);
            if (size < 50)
                _enemyPanel.BackgroundImage = Properties.Resources._16x16;
            else if (size < 75)
                _enemyPanel.BackgroundImage = Properties.Resources._32x32;
            else
                _enemyPanel.BackgroundImage = Properties.Resources._64x64;
            _enemyPanel.Size = new Size(size, size);
            int x, y;
            if (random.Next(0, 10) > 5)
                x = 1280;
            else
                x = 0;
            if (random.Next(0, 10) > 5)
                y = 720;
            else
                y = 0;
            _enemyPanel.Location = new Point(x, y);
            _enemyPanel.BackColor = Color.Transparent;
            _enemyPanel.BackgroundImageLayout = ImageLayout.Stretch;
            gameForm.Controls.Add(_enemyPanel);
            _enemyPanel.BringToFront();
            entities.Add(new Enemy(5, new Point(x == 1280 ? -random.Next(1, 5)*100/size : random.Next(1, 5) * 100 / size, y == 720 ? -random.Next(1, 5) * 100 / size : random.Next(1, 5) * 100 / size)), _enemyPanel);
        }
        
        private void LoseGame()
        {
            gameForm.Dispose();
        }
    }
}
