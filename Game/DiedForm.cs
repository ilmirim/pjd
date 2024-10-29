using Game.Properties;
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
    public partial class DiedForm : Form
    {
        private Graphics graphics;
        private int i;
        private GameForm gameForm;
        public DiedForm()
        {
            InitializeComponent();
            CenterToScreen();

            graphics = pictureBox1.CreateGraphics();            
            //graphics.DrawImage(Properties.Resources.ship2,Rectangle);
        }

        private void DiedForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
            if (e.KeyCode == Keys.Space) { gameForm.Show(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            pictureBox1.Image = Properties.Resources.ship2;
            if (i%10==0 )
            {
                pictureBox1.Image = Properties.Resources._64x64;
            }
            
            pictureBox1.Refresh();  

        }

    }
}
