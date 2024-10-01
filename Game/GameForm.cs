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
        private GameController game;
        private Point directionVector;
        private int seconds;
        private Form menuForm;
        private int i;
        public GameForm(Form _menuForm)
        {
            InitializeComponent();
            CenterToScreen();
            game = new GameController(this);
            menuForm = _menuForm;
        }
        //Прогрузка объектов и сущностей при созданит сцены
        private void GameForm_Load(object sender, EventArgs e)
        {
            game.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.MovePlayer(directionVector);
            game.EnemyLogic();

            i++;
            if(i == 50)
            {
                i = 0;
                seconds++;
                game.SpawnEnemy();
            }
            TextTimer.Text = $"Time: 0:{seconds}";
        }

        private void GameForm_Deactivate(object sender, EventArgs e)
        {
            menuForm.TopMost = true;
            SaveSystem saveSystem = new SaveSystem("pjd Project");
            saveSystem.AddNewTry($"time 0:{seconds}");
            menuForm.Show();
        }
    }
}
