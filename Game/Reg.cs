using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Length == 0)
            {
                textBox_Name.Text = "Ввели некорректное имя";
                return;
            }
            if (textBox_Login.Text.Length == 0)
            {
                textBox_Login.Text = "Логин должен состоять из 12 символов";
            }

        }
    }
}
