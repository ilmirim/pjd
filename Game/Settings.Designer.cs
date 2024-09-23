namespace Game
{
    partial class Settings
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
            this.MuteButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MuteButton
            // 
            this.MuteButton.AutoSize = true;
            this.MuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuteButton.Location = new System.Drawing.Point(86, 89);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(66, 17);
            this.MuteButton.TabIndex = 0;
            this.MuteButton.Text = "Музыка";
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MuteButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MuteButton;
    }
}