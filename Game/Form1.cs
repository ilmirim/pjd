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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();
            this.Hide();
        }
    }
}
