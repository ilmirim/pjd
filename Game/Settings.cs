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
    public partial class Settings : Form
    {
        Form mainForm;
        public Settings(Form form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void Settings_Deactivate(object sender, EventArgs e)
        {
            mainForm.TopMost = true;
            mainForm.Show();
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}