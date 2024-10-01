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
            SaveSystem save = new SaveSystem();
            MuteButton.Checked = save.isActiveMusic;
            checkBox1.Checked = save.isActiveSound;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Focus();
        }

        private void Settings_Deactivate(object sender, EventArgs e)
        {
            mainForm.TopMost = true;
            SaveSystem save = new SaveSystem();
            save.SaveSettings(MuteButton.Checked, checkBox1.Checked);
            mainForm.Show();
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}