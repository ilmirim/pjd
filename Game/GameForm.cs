﻿using System;
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
        private int minutes;
        private int i;
        private int playerSpeed = 5;
        public GameForm()
        {
            InitializeComponent();
            CenterToScreen();
            map = new MapSystem(this);
        }
        //Прогрузка объектов и сущностей при созданит сцены
        private void GameForm_Load(object sender, EventArgs e)
        {
            map.Generate();
            player = new Player(this, map, 100, 1);
            seconds = 0;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                directionVector.Y = -playerSpeed;
            }
            if (e.KeyCode == Keys.D)
            {
                directionVector.X = playerSpeed;
            }
            if (e.KeyCode == Keys.S)
            {
                directionVector.Y = playerSpeed;
            }
            if (e.KeyCode == Keys.A)
            {
                directionVector.X = -playerSpeed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.PlusPosition(directionVector);
            i++;
            if(i == 50)
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
