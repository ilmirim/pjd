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
        private Dictionary<Enemy, Control> entities;
        private Graphics graphics;
        public GameVisualizer(GameForm _gameForm) 
        {
            gameForm = _gameForm;
        }

        public void SetData(Dictionary<Enemy, Control> _entities)
        {
            entities = _entities;
        }

        public void Visualize()
        {

        }
    }
}
