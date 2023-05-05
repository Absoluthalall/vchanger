namespace VSGen
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGamePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPathToExe = new System.Windows.Forms.Label();
            this.labelDlcStatus = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelDlcStatus2 = new System.Windows.Forms.Label();
            this.labelSetCoins = new System.Windows.Forms.Label();
            this.toggleButtonSetCoins = new CustomControls.MoreControls.ToggleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 410);
            this.panel1.TabIndex = 0;
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGamePath.Location = new System.Drawing.Point(12, 37);
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.ReadOnly = true;
            this.textBoxGamePath.Size = new System.Drawing.Size(372, 21);
            this.textBoxGamePath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(126, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 22);
            this.panel2.TabIndex = 3;
            // 
            // labelPathToExe
            // 
            this.labelPathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToExe.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPathToExe.Location = new System.Drawing.Point(12, 11);
            this.labelPathToExe.Name = "labelPathToExe";
            this.labelPathToExe.Size = new System.Drawing.Size(185, 23);
            this.labelPathToExe.TabIndex = 0;
            this.labelPathToExe.Text = "Path To Game Launcher";
            // 
            // labelDlcStatus
            // 
            this.labelDlcStatus.AutoSize = true;
            this.labelDlcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDlcStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDlcStatus.Location = new System.Drawing.Point(18, 11);
            this.labelDlcStatus.Name = "labelDlcStatus";
            this.labelDlcStatus.Size = new System.Drawing.Size(176, 32);
            this.labelDlcStatus.TabIndex = 20;
            this.labelDlcStatus.Text = "Legacy of the Moonspell\r\nDLC Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(18, 43);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(27, 16);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "No";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStatus2.Location = new System.Drawing.Point(248, 43);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(27, 16);
            this.labelStatus2.TabIndex = 23;
            this.labelStatus2.Text = "No";
            // 
            // labelDlcStatus2
            // 
            this.labelDlcStatus2.AutoSize = true;
            this.labelDlcStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDlcStatus2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDlcStatus2.Location = new System.Drawing.Point(248, 11);
            this.labelDlcStatus2.Name = "labelDlcStatus2";
            this.labelDlcStatus2.Size = new System.Drawing.Size(145, 32);
            this.labelDlcStatus2.TabIndex = 22;
            this.labelDlcStatus2.Text = "Tides of the Foscari\r\nDLC Status:";
            // 
            // labelSetCoins
            // 
            this.labelSetCoins.AutoSize = true;
            this.labelSetCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetCoins.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSetCoins.Location = new System.Drawing.Point(64, 37);
            this.labelSetCoins.Name = "labelSetCoins";
            this.labelSetCoins.Size = new System.Drawing.Size(156, 16);
            this.labelSetCoins.TabIndex = 25;
            this.labelSetCoins.Text = "Set Coins To 7777777";
            // 
            // toggleButtonSetCoins
            // 
            this.toggleButtonSetCoins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonSetCoins.Location = new System.Drawing.Point(12, 35);
            this.toggleButtonSetCoins.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonSetCoins.Name = "toggleButtonSetCoins";
            this.toggleButtonSetCoins.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonSetCoins.TabIndex = 24;
            this.toggleButtonSetCoins.Text = "toggleButton1";
            this.toggleButtonSetCoins.UseVisualStyleBackColor = true;
            this.toggleButtonSetCoins.CheckStateChanged += new System.EventHandler(this.toggleButtonSetCoins_CheckStateChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.toggleButtonSetCoins);
            this.panel3.Controls.Add(this.labelSetCoins);
            this.panel3.Location = new System.Drawing.Point(144, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 69);
            this.panel3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Disabled";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelDlcStatus);
            this.panel4.Controls.Add(this.labelDlcStatus2);
            this.panel4.Controls.Add(this.labelStatus2);
            this.panel4.Controls.Add(this.labelStatus);
            this.panel4.Location = new System.Drawing.Point(144, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 74);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelPathToExe);
            this.panel5.Controls.Add(this.textBoxGamePath);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(144, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 75);
            this.panel5.TabIndex = 28;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGamePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPathToExe;
        private System.Windows.Forms.Label labelDlcStatus;
        internal System.Windows.Forms.Label labelStatus;
        internal System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelDlcStatus2;
        private System.Windows.Forms.Label labelSetCoins;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label1;
        public CustomControls.MoreControls.ToggleButton toggleButtonSetCoins;
    }
}