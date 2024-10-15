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
        private GameForm GameForm;
        public DiedForm()
        {
            InitializeComponent();
            CenterToScreen();

            graphics = pictureBox1.CreateGraphics();            
            //graphics.DrawImage(Properties.Resources.ship2,Rectangle);
        }

        private void DiedForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {}
            if (e.KeyCode == Keys.Space) {}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
