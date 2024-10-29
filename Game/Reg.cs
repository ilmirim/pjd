using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Reg : Form
    {
        DateTime temp;

        public Reg()
        {
            InitializeComponent();

            label_err.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_Name.Text.Length == 0)
            {
                label_err.Text = "Введите имя!";
                return;
            }

            Regex fullNameRegex = new Regex(@"^(([А-ЯЁ][а-яё]+)|([A-Z][a-z]+))\s(([А-ЯЁ][а-яё]+)|([A-Z][a-z]+))\s(([А-ЯЁ][а-яё]+)|([A-Z][a-z]+))$");
            Match match = fullNameRegex.Match(textBox_Name.Text);
            if (!match.Success)
            {
                label_err.Text = "Неверный формат имени!";
                return;
            }

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

            // mail gmail yandex
            // ru com
            Regex mailRegex = new Regex(@"\w+@(mail\.ru|gmail\.com|yandex\.ru)$");
            match = mailRegex.Match(textBox_Mail.Text);
            if (!match.Success)
            {
                label_err.Text = "Неправильный формат почты!";
                return;
            }

            Regex telephoneRegex = new Regex(@"^[8]{1}\d{10}$");
            match = telephoneRegex.Match(textBox_Telephone.Text);
            if (!match.Success)
            {
                label_err.Text = "Неправильный формат телефона!";
                return;
            }

            // Проверка
            Regex dateRegex = new Regex(@"([012]\d|30|31)\.(0\d|10|11|12)\.([1|2][0|9]\d{2})$");
            match = dateRegex.Match(textBox_Date.Text);

            if (match.Success)
            {
                var dateParsed = DateTime.TryParse(textBox_Date.Text, out var date);

                if (date > DateTime.Today || !dateParsed)
                {
                    label_err.Text = "Неправильный формат даты!";
                    return;
                }
            }
            else
            {
                label_err.Text = "Неправильный формат даты!";
                return;
            }




            label_err.Text = "";
            //дописать запись данных в файл
            Close();
        }

        private void labelAkk_Click(object sender, EventArgs e)
        {
            var signInForm = new SignInForm();
            signInForm.ShowDialog();
            Close();
        }
    }
}
