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
        private GameVisualizer visualizer;
        private Point directionVector;
        private int seconds;
        private Form menuForm;
        private int i;
        private Dictionary<Point, Figure> entitiesInfo;
        private Graphics graphics;
        public PictureBox background => pictureBox1; 

        public GameForm(Form _menuForm)
        {
            InitializeComponent();
            CenterToScreen();

            this.BackColor = Color.White;
            visualizer = new GameVisualizer(this);
            game = new GameController(this, visualizer);
            entitiesInfo = new Dictionary<Point, Figure>();
            entitiesInfo.Add(new Point(0, 0), new Figure(Figure.FigureType.circle, 1));
            menuForm = _menuForm;
            graphics = pictureBox1.CreateGraphics();
            DoubleBuffered = true;
        }

        //Прогрузка объектов и сущностей при созданит сцены
        private void GameForm_Load(object sender, EventArgs e)
        {
            game.Start();
            CenterToScreen();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                directionVector.Y = -1;
            }
            if (e.KeyCode == Keys.D)
            {
                directionVector.X = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                directionVector.Y = 1;
            }
            if (e.KeyCode == Keys.A)
            {
                directionVector.X = -1;
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
            if(i % 5d == 0)
                game.SpawnEnemy();
            if (i == 50)
            {
                i = 0;
                seconds++;
            }
            TextTimer.Text = $"Time: {seconds}";
        }
        private void VisTimer_Tick(object sender, EventArgs e)
        {
             visualizer.Visualize();
        }

        private void GameForm_Deactivate(object sender, EventArgs e)
        {
            menuForm.TopMost = true;
            SaveSystem saveSystem = new SaveSystem("pjd Project");
            saveSystem.AddNewTry(seconds.ToString());
            menuForm.Show();
        }
        
        public void DrawObjects(Dictionary<Point, Figure> _entitiesInfo)
        {
            entitiesInfo = _entitiesInfo;
            PaintEntities(pictureBox1, null);
        }

        private void PaintEntities(object sender, PaintEventArgs e)
        {
            //Bitmap
            graphics.Clear(pictureBox1.BackColor);
            var rect = new Rectangle(entitiesInfo.ElementAt(0).Key.X, entitiesInfo.ElementAt(0).Key.Y, entitiesInfo.ElementAt(0).Value.Size, entitiesInfo.ElementAt(0).Value.Size);
            graphics.DrawImage(Properties.Resources.ship2, rect);
            var i = -1;
            foreach(var enemy in entitiesInfo)
            {
                i++;
                if (i == 0) continue;
                var rectEnemy = new Rectangle(enemy.Key.X, enemy.Key.Y, enemy.Value.Size, enemy.Value.Size);
                graphics.DrawImage(Properties.Resources._64x64 , rectEnemy);
            }
        }
    }
}
