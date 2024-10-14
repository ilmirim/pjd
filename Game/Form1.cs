using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Game
{
    public partial class Form1 : Form
    {
        SoundPlayer music, clickSound, openSound;
        SaveSystem saveSystem;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            music = new SoundPlayer(Properties.Resources.menu);
            clickSound = new SoundPlayer(Properties.Resources.click);
            openSound = new SoundPlayer(Properties.Resources.SettingAplied);
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            saveSystem = new SaveSystem("pjd Project");
            
        }
        private void Play()
        {
            GameForm game = new GameForm(this);
            game.Show();
            this.Hide();
        }
        private void Exit()
        {
            this.Close();
        }

        private void OpenSettings()
        {
            clickSound.Play();
            Settings settings = new Settings(this);
            settings.Show();
            //this.Hide();
        } 

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(saveSystem.isActiveMusic)
                music.Play();
            Focus();
            listView1.Clear();
            var record = 0;
            /*foreach (var item in saveSystem.GetAllTryes())
            {
                listView1.Items.Add($"time - {item} sec");
                int seconds = int.Parse(item);
                if (record < seconds)
                    record = seconds;
            }*/
            int firstNumber = record > 59 ? record / 60 : 0;
            int secondNumber = record > 59 ? record - (record / 60) * 60 : record;
            label3.Text = $"{firstNumber}:{secondNumber}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Play();
            if (e.KeyCode == Keys.Escape)
                Exit();
            if (e.KeyCode == Keys.Tab)
                OpenSettings();
        }
    }
}
