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
        private Player player;
        private List<Enemy> entities;
        private Random random;
        private int width, height;
        private int i;

        public GameController(GameForm _gameForm, GameVisualizer _gameVisualizer)
        {
            visualizer = _gameVisualizer;
            entities = new List<Enemy>();
            width = 1280;
            height = 720;
            player = SpawnPlayer();
            visualizer.SetData(entities, player);
            random = new Random();
        }

        public void Start(int w, int h)
        {
            i = 0;
            width = w;
            height = h;
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
                if ((float)x > (float)width * 1.25f || (float)y > (float)height * 1.25f)
                {
                    entities.Remove(entity);
                    return;
                }
                var size = entity.ColliderFigure.Size;
                entity.Position = new Point(x + entity.Direction.X, y + entity.Direction.Y);
                entity.Update(1);
                if(!entity.IsAlive)
                {
                    entities.Remove(entity);
                    return;
                }
                if ((x + size > player.Position.X && x < player.Position.X) ||
                     (x + size > player.Position.X + size && x < player.Position.X + size))
                {
                    if ((y + size > player.Position.Y && y < player.Position.Y) ||
                    (y + size > player.Position.Y + size && y < player.Position.Y + size))
                    {
                        LoseGame();
                    }
                }
                /*if (entity.VisualFigure.Type == Figure.FigureType.square)
                {
                    
                }
                else if(entity.VisualFigure.Type == Figure.FigureType.circle)
                {
                    var ssize = Convert.ToInt32(float.Parse(entity.VisualFigure.Size.ToString()) * 0.75f);
                    if (Math.Abs(entity.X - player.X) < ssize)
                    {
                        LoseGame();
                    }
                    else if(Math.Abs(entity.Y - player.Y) < ssize)
                    {
                        LoseGame();
                    }
                }*/
            }
            visualizer.SetData(entities, player);
        }

        private Player SpawnPlayer()
        {
            var _playerFigure = new Figure(Figure.FigureType.square, 25);
            var _playerColliderFigure = new Figure(Properties.Resources.ship2, Figure.FigureType.square, 20);
            var _player = new Player(width, height,
                new Point((width - _playerFigure.Size) / 2, (height - _playerFigure.Size) / 2), 
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
            var enemyFigure = new Figure(Properties.Resources._32x32, Figure.FigureType.circle, size);
            var enemyColliderFigure = new Figure(Figure.FigureType.circle, Convert.ToInt32(float.Parse(size.ToString()) * 0.5f));
            
            var dir = new Point(
                x == width
                ? -random.Next(1, 5) * 100 / size
                : random.Next(1, 5) * 100 / size,

                y == height
                ? -random.Next(1, 5) * 100 / size
                : random.Next(1, 5) * 100 / size);

            var enemy = new Enemy(10, dir, new Point(x, y), enemyFigure, enemyFigure);
            entities.Add(enemy);
        }
        
        private void LoseGame()
        {
            Form.ActiveForm.Dispose();
        }
    }
}
