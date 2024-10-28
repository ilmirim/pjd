namespace Game
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Mail = new System.Windows.Forms.GroupBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.groupBox_Mail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_err);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox_Mail);
            this.groupBox1.Controls.Add(this.groupBox_Password);
            this.groupBox1.Controls.Add(this.groupBox_Login);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.textBox_Login);
            this.groupBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Login.Location = new System.Drawing.Point(21, 28);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(251, 49);
            this.groupBox_Login.TabIndex = 2;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(22, 19);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(204, 20);
            this.textBox_Login.TabIndex = 0;
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.Controls.Add(this.textBox_Password);
            this.groupBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Password.Location = new System.Drawing.Point(21, 92);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Size = new System.Drawing.Size(251, 50);
            this.groupBox_Password.TabIndex = 3;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(22, 21);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(204, 20);
            this.textBox_Password.TabIndex = 1;
            // 
            // groupBox_Mail
            // 
            this.groupBox_Mail.Controls.Add(this.textBox_Mail);
            this.groupBox_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Mail.Location = new System.Drawing.Point(21, 157);
            this.groupBox_Mail.Name = "groupBox_Mail";
            this.groupBox_Mail.Size = new System.Drawing.Size(251, 58);
            this.groupBox_Mail.TabIndex = 4;
            this.groupBox_Mail.TabStop = false;
            this.groupBox_Mail.Text = "Mail";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(22, 19);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(204, 20);
            this.textBox_Mail.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err.ForeColor = System.Drawing.Color.Red;
            this.label_err.Location = new System.Drawing.Point(40, 222);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(39, 12);
            this.label_err.TabIndex = 6;
            this.label_err.Text = "label1";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(340, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.groupBox_Password.ResumeLayout(false);
            this.groupBox_Password.PerformLayout();
            this.groupBox_Mail.ResumeLayout(false);
            this.groupBox_Mail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.GroupBox groupBox_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_Mail;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Label label_err;
    }
}