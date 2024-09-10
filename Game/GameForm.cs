using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        private MapSystem map;
        private Player player;
        private Point directionVector;
        private int seconds;
        private int i;
        public GameForm()
        {
            InitializeComponent();
            CenterToScreen();
            map = new MapSystem(this);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            map.Generate();
            player = new Player(this, map, 100, 1);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                directionVector.Y = -5;
            }
            if (e.KeyCode == Keys.D)
            {
                directionVector.X = 5;
            }
            if (e.KeyCode == Keys.S)
            {
                directionVector.Y = 5;
            }
            if (e.KeyCode == Keys.A)
            {
                directionVector.X = -5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Position(directionVector);
            i++;
            if(i == 200)
            {
                i = 0;
                seconds++;
            }
            TextTimer.Text = $"Time: 0:{seconds}";
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                directionVector.Y = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                directionVector.X = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                directionVector.Y = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                directionVector.X = 0;
            }
        }
    }
}
