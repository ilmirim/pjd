using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();

            label_err.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //в идеале нуужна апроверка с файла на данный логин
            if (textBox_Login.Text.Length == 0)
            {
                label_err.Text = "Введите логин!";
                return;
            }

            else if (textBox_Login.Text.Length > 12)
            {
                label_err.Text = "Логин должен состоять не больше чем из 12 символов!";
                return;
            }

            if (textBox_Password.Text.Length == 0)
            {
                label_err.Text = "Введите пароль!";
                return;
            }

            else if (textBox_Password.Text.Length < 8)
            {
                label_err.Text = "Пароль должен состоять минимум из 8 символов!";
                return;
            }

            Regex mailRegex = new Regex(@"\w+@\w.\w");
            Match match = mailRegex.Match(textBox_Mail.Text);
            if (!match.Success)
            {
                label_err.Text = "Неправильный формат почты!";
                return;
            }

            Close();
            
        }
    }
}
