using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class GameVisualizer
    {
        private GameForm gameForm;
        private List<Enemy> entities;
        private Player player;
        public GameVisualizer(GameForm _gameForm) 
        {
            gameForm = _gameForm;
        }

        public void SetData(List<Enemy> _entities, Player _player)
        {
            entities = _entities;
            player = _player;
        }

        public void Visualize()
        {
            var entityInfo = new Dictionary<Point, Figure>();
            entityInfo.Add(player.Position, player.VisualFigure);
            foreach(var entity in entities)
            {
                if(!entityInfo.ContainsKey(entity.Position))
                {
                    entityInfo.Add(entity.Position, entity.VisualFigure);
                }
            }
            gameForm.DrawObjects(entityInfo);
        }
    }
}
