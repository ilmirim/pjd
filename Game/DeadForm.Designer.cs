namespace Game
{
    partial class DeadForm
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
            this.diedLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diedLabel
            // 
            this.diedLabel.AutoSize = true;
            this.diedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diedLabel.ForeColor = System.Drawing.Color.Red;
            this.diedLabel.Location = new System.Drawing.Point(101, 49);
            this.diedLabel.Name = "diedLabel";
            this.diedLabel.Size = new System.Drawing.Size(128, 31);
            this.diedLabel.TabIndex = 0;
            this.diedLabel.Text = "You died";
            this.diedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(134, 164);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(65, 25);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "label2";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(55, 347);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(217, 347);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // DeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 449);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.diedLabel);
            this.Name = "DeadForm";
            this.Text = "DeadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diedLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonExit;
    }
}