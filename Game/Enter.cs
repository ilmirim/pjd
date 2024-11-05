using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Game
{
    public partial class Enter : Form
    {
        private bool isLogin;
        private string path;

        public Enter()
        {
            InitializeComponent();

            errorText.Text = "";
            isLogin = false;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//pjd Project//loginData";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!isLogin)
            {
                if (loginText.Text.Length > 12)
                {
                    errorText.Text = "Длинна логина больше 12 символов";
                    return;
                }
                else if (loginText.Text.Length == 0)
                {
                    errorText.Text = "Длинна логина равна 0 символам";
                    return;
                }

                if (passwordText.Text != confirmPassword.Text)
                {
                    errorText.Text = "Пароли не совпадают";
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

                Regex emailRegex = new Regex(@"\S+@\S+\.((by)|(ru)|(com))");
                Match match = emailRegex.Match(emailText.Text);
                if (!match.Success)
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

                Regex cardEXPRegex = new Regex("((0[1-9])|(1[0-2]))/[0-9]{2}");
                match = cardEXPRegex.Match(cardEXPText.Text);
                if (!match.Success)
                {
                    errorText.Text = "Неправильный формат срока годности карты";
                    return;
                }

                DateTime dateTime = DateTime.ParseExact(match.Value, "MM/yy", CultureInfo.InvariantCulture);

                if (dateTime <= DateTime.Now)
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

                if (IsUserExist())
                {
                    errorText.Text = "Логин занят";
                    return;
                }

                var textToFile = $"{loginText.Text}_{passwordText.Text}_{emailText.Text}_{cardNumberText.Text}_{cardEXPText.Text}_{CCVText.Text}";
                File.AppendAllText(path, textToFile);

                Close();
            }
            else
            {
                var allData = File.ReadAllLines(path);

                var flag = false;
                foreach (var data in allData)
                {
                    if (loginText.Text == data.Split('_')[0] &&
                        passwordText.Text == data.Split('_')[1])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    errorText.Text = "Неправильный логин или пароль";
                    return;
                }
                else Close();
            }
        }

        private bool IsUserExist()
        {
            var allData = File.ReadAllLines(path);

            foreach (var data in allData)
            {
                if (loginText.Text == data.Split('_')[0])
                    return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isLogin = !isLogin;

            if (isLogin)
            {
                label1.Text = "У меня нет аккаунта";
                confirmPassGorup.Visible = false;
                emailGroup.Visible = false;
                cardNumber.Visible = false;
                cardEXPGroup.Visible = false;
                CCVGroup.Visible = false;
            }
            else
            {
                label1.Text = "У меня уже есть аккаунт";
                confirmPassGorup.Visible = true;
                emailGroup.Visible = true;
                cardNumber.Visible = true;
                cardEXPGroup.Visible = true;
                CCVGroup.Visible = true;
            }

        }
    }
}
