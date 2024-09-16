﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class GameController
    {
        private MapSystem map;
        private Player player;
        private GameForm gameForm;
        private Dictionary<Entity, Control> entities;

        public GameController(GameForm _gameForm)
        {
            gameForm = _gameForm;
            map = new MapSystem();
            entities = new Dictionary<Entity, Control>();
        }

        public void Start()
        {
            map.Generate();
            SpawnPlayer();

        }

        public void MovePlayer(Point _direction)
        {
            player.PlusPosition(_direction);
        }

        public void EnemyLogic()
        {
            Point direction = new Point(0, 0);
            foreach (var entity in entities)
            {
                if(entity.Key.Type == Entity.EntityType.player)
                    continue;

                direction = new Point(entity.Value.Location.X - entities[player].Location.X);

            }
        }

        private void SpawnPlayer()
        {
            
            Panel _playerPanel = new Panel();
            _playerPanel.Size = new Size(25, 25);
            _playerPanel.Location = new Point((1280 - _playerPanel.Width) / 2, (720 - _playerPanel.Height) / 2);
            gameForm.Controls.Add(_playerPanel);
            player = new Player(_playerPanel);
            entities.Add(player, _playerPanel);
            _playerPanel.BringToFront();
        }

        public void SpawnEnemy()
        {
            Panel _enemyPanel = new Panel();
            _enemyPanel.Size = new Size(15, 15);
            _enemyPanel.Location = new Point((1280 - _enemyPanel.Width) / 4, (720 - _enemyPanel.Height) / 4);
            _enemyPanel.BackColor = Color.Red;
            gameForm.Controls.Add(_enemyPanel);
            _enemyPanel.BringToFront();
        }
    }
}
