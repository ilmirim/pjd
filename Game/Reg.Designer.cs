namespace Game
{
    partial class Reg
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
            this.label_err = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Name = new System.Windows.Forms.GroupBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox_Date = new System.Windows.Forms.GroupBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.groupBox_Telephone = new System.Windows.Forms.GroupBox();
            this.textBox_Telephone = new System.Windows.Forms.TextBox();
            this.groupBox_Mail = new System.Windows.Forms.GroupBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Akk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Name.SuspendLayout();
            this.groupBox_Date.SuspendLayout();
            this.groupBox_Telephone.SuspendLayout();
            this.groupBox_Mail.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_err);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox_Name);
            this.groupBox1.Controls.Add(this.groupBox_Date);
            this.groupBox1.Controls.Add(this.groupBox_Telephone);
            this.groupBox1.Controls.Add(this.groupBox_Mail);
            this.groupBox1.Controls.Add(this.groupBox_Password);
            this.groupBox1.Controls.Add(this.groupBox_Login);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_err.ForeColor = System.Drawing.Color.Red;
            this.label_err.Location = new System.Drawing.Point(6, 369);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(41, 13);
            this.label_err.TabIndex = 5;
            this.label_err.Text = "label1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_Name
            // 
            this.groupBox_Name.Controls.Add(this.textBox_Name);
            this.groupBox_Name.Location = new System.Drawing.Point(15, 19);
            this.groupBox_Name.Name = "groupBox_Name";
            this.groupBox_Name.Size = new System.Drawing.Size(251, 49);
            this.groupBox_Name.TabIndex = 2;
            this.groupBox_Name.TabStop = false;
            this.groupBox_Name.Text = "Full Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(22, 19);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(204, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // groupBox_Date
            // 
            this.groupBox_Date.Controls.Add(this.textBox_Date);
            this.groupBox_Date.Location = new System.Drawing.Point(15, 308);
            this.groupBox_Date.Name = "groupBox_Date";
            this.groupBox_Date.Size = new System.Drawing.Size(251, 58);
            this.groupBox_Date.TabIndex = 2;
            this.groupBox_Date.TabStop = false;
            this.groupBox_Date.Text = "Date of Birth";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(22, 19);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(204, 20);
            this.textBox_Date.TabIndex = 1;
            // 
            // groupBox_Telephone
            // 
            this.groupBox_Telephone.Controls.Add(this.textBox_Telephone);
            this.groupBox_Telephone.Location = new System.Drawing.Point(15, 249);
            this.groupBox_Telephone.Name = "groupBox_Telephone";
            this.groupBox_Telephone.Size = new System.Drawing.Size(251, 53);
            this.groupBox_Telephone.TabIndex = 3;
            this.groupBox_Telephone.TabStop = false;
            this.groupBox_Telephone.Text = "Telephone";
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.Location = new System.Drawing.Point(22, 19);
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(204, 20);
            this.textBox_Telephone.TabIndex = 2;
            // 
            // groupBox_Mail
            // 
            this.groupBox_Mail.Controls.Add(this.textBox_Mail);
            this.groupBox_Mail.Location = new System.Drawing.Point(15, 185);
            this.groupBox_Mail.Name = "groupBox_Mail";
            this.groupBox_Mail.Size = new System.Drawing.Size(251, 58);
            this.groupBox_Mail.TabIndex = 1;
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
            // groupBox_Password
            // 
            this.groupBox_Password.Controls.Add(this.textBox_Password);
            this.groupBox_Password.Location = new System.Drawing.Point(15, 129);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Size = new System.Drawing.Size(251, 50);
            this.groupBox_Password.TabIndex = 2;
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
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.textBox_Login);
            this.groupBox_Login.Location = new System.Drawing.Point(15, 74);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(251, 49);
            this.groupBox_Login.TabIndex = 1;
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
            // label_Akk
            // 
            this.label_Akk.AutoSize = true;
            this.label_Akk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Akk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Akk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Akk.Location = new System.Drawing.Point(125, 434);
            this.label_Akk.Name = "label_Akk";
            this.label_Akk.Size = new System.Drawing.Size(104, 13);
            this.label_Akk.TabIndex = 1;
            this.label_Akk.Text = "Уже есть аккаунт?";
            this.label_Akk.Click += new System.EventHandler(this.labelAkk_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(371, 456);
            this.Controls.Add(this.label_Akk);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reg";
            this.Text = "Reg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Name.ResumeLayout(false);
            this.groupBox_Name.PerformLayout();
            this.groupBox_Date.ResumeLayout(false);
            this.groupBox_Date.PerformLayout();
            this.groupBox_Telephone.ResumeLayout(false);
            this.groupBox_Telephone.PerformLayout();
            this.groupBox_Mail.ResumeLayout(false);
            this.groupBox_Mail.PerformLayout();
            this.groupBox_Password.ResumeLayout(false);
            this.groupBox_Password.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.GroupBox groupBox_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox groupBox_Mail;
        private System.Windows.Forms.GroupBox groupBox_Date;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.GroupBox groupBox_Telephone;
        private System.Windows.Forms.TextBox textBox_Telephone;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.GroupBox groupBox_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_err;
        private System.Windows.Forms.Label label_Akk;
    }
}