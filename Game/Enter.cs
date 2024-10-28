using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Game
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();

            errorText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginText.Text.Length > 12 )
            {
                errorText.Text = "Длинна логина больше 12 символов";
                return;
            }
            else if(loginText.Text.Length == 0)
            {
                errorText.Text = "Длинна логина равна 0 символам";
                return;
            }

            if (passwordText.Text.Length > 20)
            {
                errorText.Text = "Длинна пароля больше 20 символов";
                return;
            }
            else if (passwordText.Text.Length < 8)
            {
                errorText.Text = "Длинна пароля меньше 8 символам";
                return;
            }

            Regex emailRegex = new Regex("\\S+@\\S+\\.\\S+"); 
            Match match = emailRegex.Match(emailText.Text);
            if(!match.Success)
            {
                errorText.Text = "Неправильный формат почты";
                return;
            }

            Regex cardNumberRegex = new Regex(@"\d{4}-\d{4}-\d{4}-\d{4}");
            match = cardNumberRegex.Match(cardNumberText.Text);
            if (!match.Success)
            {
                errorText.Text = "Неправильный формат номера карты";
                return;
            }

            Regex cardEXPRegex = new Regex("[0-9]{2}/[0-9]{2}");
            match = cardEXPRegex.Match(cardEXPText.Text);
            if (!match.Success)
            {
                errorText.Text = "Неправильный формат срока годности карты";
                return;
            }

            Regex ccvRegex = new Regex("[0-9]{3}");
            match = ccvRegex.Match(CCVText.Text);
            if (!match.Success)
            {
                errorText.Text = "Неправильный формат CCV кода";
                return;
            }

            errorText.Text = "";

            Close();
        }
    }
}
