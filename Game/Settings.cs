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
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        

        private Boolean isPlaing = true;
        /*private void MuteButton_Click(object sender, EventArgs e)
        {
            if (StartUpMusic.IsLoadCompleted)
            {
                if (isPlaing)
                    StartUpMusic.Stop();  
                else
                    StartUpMusic.Play();
                isPlaing=false;
            }
        }*/
    }
}
