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
        private GameVisualizer visualizer;
        private MapSystem map;
        private Player player;
        private List<Enemy> entities;
        private Random random;
        private int width, height;
        private int i;

        public GameController(GameForm _gameForm, GameVisualizer _gameVisualizer)
        {
            visualizer = _gameVisualizer;
            map = new MapSystem();
            entities = new List<Enemy>();
            player = SpawnPlayer();
            visualizer.SetData(entities, player);
            random = new Random();
            width = 1280;
            height = 720;
        }

        public void Start()
        {
            map.Generate();
            i = 0;
        }

        public void MovePlayer(Point _direction)
        {
            player.Force = _direction;
            player.Position = new Point(player.X + _direction.X*player.Speed, player.Y + _direction.Y*player.Speed);
        }

        public void EnemyLogic()
        {
            foreach (var entity in entities)
            {
                var x = entity.X;
                var y = entity.Y;

                var size = entity.ColliderFigure.Size;
                entity.Position = new Point(x + entity.GetDirection.X, y + entity.GetDirection.Y);
                if(!entity.PlusTime())
                {
                    entities.Remove(entity);
                    return;
                }
                if ((x + size > player.Position.X && x < player.Position.X) ||
                    (x + size > player.Position.X + player.VisualFigure.Size && x < player.Position.X + player.VisualFigure.Size))
                {
                    if ((y + size > player.Position.Y && y < player.Position.Y) ||
                    (y + size > player.Position.Y + player.VisualFigure.Size && y < player.Position.Y + player.VisualFigure.Size))
                    {
                        LoseGame();
                        var diedForm = new DiedForm();
                        diedForm.Show();
                        diedForm.TopMost = true;
                    }
                }
                
            }
            visualizer.SetData(entities, player);
        }

        private Player SpawnPlayer()
        {
            var _playerFigure = new Figure(Figure.FigureType.square, 25);
            var _playerColliderFigure = new Figure(Figure.FigureType.square, 20);
            var _player = new Player(1280, 720,
                new Point((1280 - _playerFigure.Size) / 2, (720 - _playerFigure.Size) / 2), 
                _playerFigure, 
                _playerColliderFigure, 5);
            return _player;
        }

        public void SpawnEnemy()
        {
            int x, y;
            if (random.Next(0, 10) > 5)
                x = width;
            else
                x = 0;
            if (random.Next(0, 10) > 5)
                y = height;
            else
                y = 0;
            var size = random.Next(25, 150);
            var enemyFigure = new Figure(Figure.FigureType.circle, size);
            var enemyColliderFigure = new Figure(Figure.FigureType.circle, Convert.ToInt32(float.Parse(size.ToString()) * 0.75f));
            var dir = new Point(x == width ? -random.Next(1, 5) * 100 / size : random.Next(1, 5) * 100 / size, y == height ? -random.Next(1, 5) * 100 / size : random.Next(1, 5) * 100 / size);
            var enemy = new Enemy(10, dir, new Point(x, y), enemyFigure, enemyFigure);
            entities.Add(enemy);
        }
        
        private void LoseGame()
        {
            Form.ActiveForm.Dispose();
        }
    }
}
