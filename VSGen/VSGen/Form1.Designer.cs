namespace VSGen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButtonGenerate = new FontAwesome.Sharp.IconButton();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonDLC2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonDLC1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSecHeroes = new FontAwesome.Sharp.IconButton();
            this.iconButtonStHeroes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUserData = new System.Windows.Forms.Label();
            this.panelHeroSettings = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleButtonUnlockAll = new CustomControls.MoreControls.ToggleButton();
            this.labelUnlocked = new System.Windows.Forms.Label();
            this.toggleButtonUnlock = new CustomControls.MoreControls.ToggleButton();
            this.labelChangeAll = new System.Windows.Forms.Label();
            this.toggleButtonChangeAll = new CustomControls.MoreControls.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleButtonHP = new CustomControls.MoreControls.ToggleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.toggleButtonRegen = new CustomControls.MoreControls.ToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleButtonLuck = new CustomControls.MoreControls.ToggleButton();
            this.toggleButtonMovespeed = new CustomControls.MoreControls.ToggleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleButtonGems = new CustomControls.MoreControls.ToggleButton();
            this.toggleButtonProjectiles = new CustomControls.MoreControls.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleButtonExp = new CustomControls.MoreControls.ToggleButton();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.backgroundWorkerDlcChecker = new System.ComponentModel.BackgroundWorker();
            this.panelLeftMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeroSettings.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeftMenu.Controls.Add(this.label9);
            this.panelLeftMenu.Controls.Add(this.iconButtonGenerate);
            this.panelLeftMenu.Controls.Add(this.iconButtonSettings);
            this.panelLeftMenu.Controls.Add(this.iconButtonDLC2);
            this.panelLeftMenu.Controls.Add(this.iconButtonDLC1);
            this.panelLeftMenu.Controls.Add(this.iconButtonSecHeroes);
            this.panelLeftMenu.Controls.Add(this.iconButtonStHeroes);
            this.panelLeftMenu.Controls.Add(this.panelLogo);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(229, 661);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(12, 637);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Version: ";
            // 
            // iconButtonGenerate
            // 
            this.iconButtonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGenerate.FlatAppearance.BorderSize = 0;
            this.iconButtonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonGenerate.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconButtonGenerate.IconColor = System.Drawing.Color.White;
            this.iconButtonGenerate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGenerate.IconSize = 32;
            this.iconButtonGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGenerate.Location = new System.Drawing.Point(0, 480);
            this.iconButtonGenerate.Name = "iconButtonGenerate";
            this.iconButtonGenerate.Size = new System.Drawing.Size(229, 60);
            this.iconButtonGenerate.TabIndex = 6;
            this.iconButtonGenerate.Text = "Generate";
            this.iconButtonGenerate.UseVisualStyleBackColor = true;
            this.iconButtonGenerate.Click += new System.EventHandler(this.iconButtonGenerate_Click);
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButtonSettings.IconColor = System.Drawing.Color.White;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 32;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 420);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Size = new System.Drawing.Size(229, 60);
            this.iconButtonSettings.TabIndex = 5;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            this.iconButtonSettings.Click += new System.EventHandler(this.iconButtonSettings_Click);
            // 
            // iconButtonDLC2
            // 
            this.iconButtonDLC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDLC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDLC2.FlatAppearance.BorderSize = 0;
            this.iconButtonDLC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDLC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDLC2.IconChar = FontAwesome.Sharp.IconChar.Tree;
            this.iconButtonDLC2.IconColor = System.Drawing.Color.White;
            this.iconButtonDLC2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDLC2.IconSize = 32;
            this.iconButtonDLC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDLC2.Location = new System.Drawing.Point(0, 360);
            this.iconButtonDLC2.Name = "iconButtonDLC2";
            this.iconButtonDLC2.Size = new System.Drawing.Size(229, 60);
            this.iconButtonDLC2.TabIndex = 4;
            this.iconButtonDLC2.Text = "Tides of the \r\nFoscari DLC";
            this.iconButtonDLC2.UseVisualStyleBackColor = true;
            this.iconButtonDLC2.Click += new System.EventHandler(this.iconButtonDLC2_Click);
            // 
            // iconButtonDLC1
            // 
            this.iconButtonDLC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDLC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDLC1.FlatAppearance.BorderSize = 0;
            this.iconButtonDLC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDLC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDLC1.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.iconButtonDLC1.IconColor = System.Drawing.Color.White;
            this.iconButtonDLC1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDLC1.IconSize = 32;
            this.iconButtonDLC1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDLC1.Location = new System.Drawing.Point(0, 300);
            this.iconButtonDLC1.Name = "iconButtonDLC1";
            this.iconButtonDLC1.Size = new System.Drawing.Size(229, 60);
            this.iconButtonDLC1.TabIndex = 3;
            this.iconButtonDLC1.Text = "Legacy of the \r\nMoonspell DLC";
            this.iconButtonDLC1.UseVisualStyleBackColor = true;
            this.iconButtonDLC1.Click += new System.EventHandler(this.iconButtonDLC1_Click);
            // 
            // iconButtonSecHeroes
            // 
            this.iconButtonSecHeroes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSecHeroes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSecHeroes.FlatAppearance.BorderSize = 0;
            this.iconButtonSecHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSecHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSecHeroes.IconChar = FontAwesome.Sharp.IconChar.Mask;
            this.iconButtonSecHeroes.IconColor = System.Drawing.Color.White;
            this.iconButtonSecHeroes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSecHeroes.IconSize = 32;
            this.iconButtonSecHeroes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSecHeroes.Location = new System.Drawing.Point(0, 240);
            this.iconButtonSecHeroes.Name = "iconButtonSecHeroes";
            this.iconButtonSecHeroes.Size = new System.Drawing.Size(229, 60);
            this.iconButtonSecHeroes.TabIndex = 2;
            this.iconButtonSecHeroes.Text = "Secret Characters";
            this.iconButtonSecHeroes.UseVisualStyleBackColor = true;
            this.iconButtonSecHeroes.Click += new System.EventHandler(this.iconButtonSecHeroes_Click);
            // 
            // iconButtonStHeroes
            // 
            this.iconButtonStHeroes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonStHeroes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonStHeroes.FlatAppearance.BorderSize = 0;
            this.iconButtonStHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStHeroes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButtonStHeroes.IconColor = System.Drawing.Color.White;
            this.iconButtonStHeroes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStHeroes.IconSize = 32;
            this.iconButtonStHeroes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStHeroes.Location = new System.Drawing.Point(0, 180);
            this.iconButtonStHeroes.Name = "iconButtonStHeroes";
            this.iconButtonStHeroes.Size = new System.Drawing.Size(229, 60);
            this.iconButtonStHeroes.TabIndex = 1;
            this.iconButtonStHeroes.Text = "Standard Characters";
            this.iconButtonStHeroes.UseVisualStyleBackColor = true;
            this.iconButtonStHeroes.Click += new System.EventHandler(this.iconButtonHeroes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 180);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VSGen.Properties.Resources.icon_610ce98233b35;
            this.pictureBox1.Location = new System.Drawing.Point(38, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelUserData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 70);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(184, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserData.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUserData.Location = new System.Drawing.Point(605, 9);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(129, 45);
            this.labelUserData.TabIndex = 1;
            this.labelUserData.Text = "Username\r\nStatus: Free\r\nExpires: xx-xx-xxxx";
            // 
            // panelHeroSettings
            // 
            this.panelHeroSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHeroSettings.Controls.Add(this.panel3);
            this.panelHeroSettings.Controls.Add(this.pictureBoxAvatar);
            this.panelHeroSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeroSettings.Location = new System.Drawing.Point(536, 0);
            this.panelHeroSettings.Name = "panelHeroSettings";
            this.panelHeroSettings.Size = new System.Drawing.Size(257, 575);
            this.panelHeroSettings.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.toggleButtonUnlockAll);
            this.panel3.Controls.Add(this.labelUnlocked);
            this.panel3.Controls.Add(this.toggleButtonUnlock);
            this.panel3.Controls.Add(this.labelChangeAll);
            this.panel3.Controls.Add(this.toggleButtonChangeAll);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.toggleButtonHP);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.toggleButtonRegen);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.toggleButtonLuck);
            this.panel3.Controls.Add(this.toggleButtonMovespeed);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.toggleButtonGems);
            this.panel3.Controls.Add(this.toggleButtonProjectiles);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.toggleButtonExp);
            this.panel3.Location = new System.Drawing.Point(0, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 401);
            this.panel3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(69, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Unlock All Heroes";
            // 
            // toggleButtonUnlockAll
            // 
            this.toggleButtonUnlockAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonUnlockAll.Location = new System.Drawing.Point(17, 353);
            this.toggleButtonUnlockAll.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonUnlockAll.Name = "toggleButtonUnlockAll";
            this.toggleButtonUnlockAll.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonUnlockAll.TabIndex = 20;
            this.toggleButtonUnlockAll.Text = "toggleButton1";
            this.toggleButtonUnlockAll.UseVisualStyleBackColor = true;
            this.toggleButtonUnlockAll.Click += new System.EventHandler(this.toggleButton1_Click);
            // 
            // labelUnlocked
            // 
            this.labelUnlocked.AutoSize = true;
            this.labelUnlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnlocked.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUnlocked.Location = new System.Drawing.Point(69, 274);
            this.labelUnlocked.Name = "labelUnlocked";
            this.labelUnlocked.Size = new System.Drawing.Size(73, 16);
            this.labelUnlocked.TabIndex = 19;
            this.labelUnlocked.Text = "Unlocked";
            // 
            // toggleButtonUnlock
            // 
            this.toggleButtonUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonUnlock.Enabled = false;
            this.toggleButtonUnlock.Location = new System.Drawing.Point(17, 272);
            this.toggleButtonUnlock.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonUnlock.Name = "toggleButtonUnlock";
            this.toggleButtonUnlock.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonUnlock.TabIndex = 18;
            this.toggleButtonUnlock.Text = "toggleButton1";
            this.toggleButtonUnlock.UseVisualStyleBackColor = true;
            this.toggleButtonUnlock.CheckedChanged += new System.EventHandler(this.toggleButtonUnlock_CheckedChanged);
            // 
            // labelChangeAll
            // 
            this.labelChangeAll.AutoSize = true;
            this.labelChangeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChangeAll.Location = new System.Drawing.Point(69, 327);
            this.labelChangeAll.Name = "labelChangeAll";
            this.labelChangeAll.Size = new System.Drawing.Size(78, 16);
            this.labelChangeAll.TabIndex = 17;
            this.labelChangeAll.Text = "Enable All";
            // 
            // toggleButtonChangeAll
            // 
            this.toggleButtonChangeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonChangeAll.Enabled = false;
            this.toggleButtonChangeAll.Location = new System.Drawing.Point(17, 325);
            this.toggleButtonChangeAll.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonChangeAll.Name = "toggleButtonChangeAll";
            this.toggleButtonChangeAll.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonChangeAll.TabIndex = 16;
            this.toggleButtonChangeAll.Text = "toggleButton1";
            this.toggleButtonChangeAll.UseVisualStyleBackColor = true;
            this.toggleButtonChangeAll.CheckStateChanged += new System.EventHandler(this.toggleButtonChangeAll_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Many HP";
            // 
            // toggleButtonHP
            // 
            this.toggleButtonHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonHP.Enabled = false;
            this.toggleButtonHP.Location = new System.Drawing.Point(17, 37);
            this.toggleButtonHP.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonHP.Name = "toggleButtonHP";
            this.toggleButtonHP.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonHP.TabIndex = 0;
            this.toggleButtonHP.Text = "toggleButton1";
            this.toggleButtonHP.UseVisualStyleBackColor = true;
            this.toggleButtonHP.CheckedChanged += new System.EventHandler(this.toggleButtonHP_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(69, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "High regeneration";
            // 
            // toggleButtonRegen
            // 
            this.toggleButtonRegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonRegen.Enabled = false;
            this.toggleButtonRegen.Location = new System.Drawing.Point(17, 237);
            this.toggleButtonRegen.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonRegen.Name = "toggleButtonRegen";
            this.toggleButtonRegen.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonRegen.TabIndex = 14;
            this.toggleButtonRegen.Text = "toggleButton1";
            this.toggleButtonRegen.UseVisualStyleBackColor = true;
            this.toggleButtonRegen.CheckedChanged += new System.EventHandler(this.toggleButtonRegen_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(69, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "High Luck";
            // 
            // toggleButtonLuck
            // 
            this.toggleButtonLuck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonLuck.Enabled = false;
            this.toggleButtonLuck.Location = new System.Drawing.Point(17, 204);
            this.toggleButtonLuck.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonLuck.Name = "toggleButtonLuck";
            this.toggleButtonLuck.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonLuck.TabIndex = 12;
            this.toggleButtonLuck.Text = "toggleButton1";
            this.toggleButtonLuck.UseVisualStyleBackColor = true;
            this.toggleButtonLuck.CheckedChanged += new System.EventHandler(this.toggleButtonLuck_CheckedChanged);
            // 
            // toggleButtonMovespeed
            // 
            this.toggleButtonMovespeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonMovespeed.Enabled = false;
            this.toggleButtonMovespeed.Location = new System.Drawing.Point(17, 68);
            this.toggleButtonMovespeed.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonMovespeed.Name = "toggleButtonMovespeed";
            this.toggleButtonMovespeed.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonMovespeed.TabIndex = 4;
            this.toggleButtonMovespeed.Text = "toggleButton1";
            this.toggleButtonMovespeed.UseVisualStyleBackColor = true;
            this.toggleButtonMovespeed.CheckedChanged += new System.EventHandler(this.toggleButtonMovespeed_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(69, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "High rad. of getting gems";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(69, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Movespeed x3";
            // 
            // toggleButtonGems
            // 
            this.toggleButtonGems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonGems.Enabled = false;
            this.toggleButtonGems.Location = new System.Drawing.Point(17, 169);
            this.toggleButtonGems.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonGems.Name = "toggleButtonGems";
            this.toggleButtonGems.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonGems.TabIndex = 10;
            this.toggleButtonGems.Text = "toggleButton1";
            this.toggleButtonGems.UseVisualStyleBackColor = true;
            this.toggleButtonGems.CheckedChanged += new System.EventHandler(this.toggleButtonGems_CheckedChanged);
            // 
            // toggleButtonProjectiles
            // 
            this.toggleButtonProjectiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonProjectiles.Enabled = false;
            this.toggleButtonProjectiles.Location = new System.Drawing.Point(17, 101);
            this.toggleButtonProjectiles.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonProjectiles.Name = "toggleButtonProjectiles";
            this.toggleButtonProjectiles.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonProjectiles.TabIndex = 6;
            this.toggleButtonProjectiles.Text = "toggleButton1";
            this.toggleButtonProjectiles.UseVisualStyleBackColor = true;
            this.toggleButtonProjectiles.CheckedChanged += new System.EventHandler(this.toggleButtonProjectiles_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(69, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exp x10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(69, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Huge Projectiles";
            // 
            // toggleButtonExp
            // 
            this.toggleButtonExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonExp.Enabled = false;
            this.toggleButtonExp.Location = new System.Drawing.Point(17, 135);
            this.toggleButtonExp.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonExp.Name = "toggleButtonExp";
            this.toggleButtonExp.Size = new System.Drawing.Size(46, 22);
            this.toggleButtonExp.TabIndex = 8;
            this.toggleButtonExp.Text = "toggleButtonExp";
            this.toggleButtonExp.UseVisualStyleBackColor = true;
            this.toggleButtonExp.CheckedChanged += new System.EventHandler(this.toggleButtonExp_CheckedChanged);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(56, 47);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(144, 136);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 16;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(229, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 16);
            this.panel4.TabIndex = 4;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.materialFlatButton1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(793, 575);
            this.panelContainer.TabIndex = 5;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialFlatButton1.BackgroundImage")));
            this.materialFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(184, 189);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(8, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelScreen.Controls.Add(this.panelHeroSettings);
            this.panelScreen.Controls.Add(this.panelContainer);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(229, 70);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(793, 575);
            this.panelScreen.TabIndex = 5;
            // 
            // backgroundWorkerDlcChecker
            // 
            this.backgroundWorkerDlcChecker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDlcChecker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1022, 661);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeftMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vampire Survivors Changer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeroSettings.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonStHeroes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHeroSettings;
        private CustomControls.MoreControls.ToggleButton toggleButtonHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomControls.MoreControls.ToggleButton toggleButtonMovespeed;
        private System.Windows.Forms.Label label8;
        private CustomControls.MoreControls.ToggleButton toggleButtonRegen;
        private System.Windows.Forms.Label label7;
        private CustomControls.MoreControls.ToggleButton toggleButtonLuck;
        private System.Windows.Forms.Label label6;
        private CustomControls.MoreControls.ToggleButton toggleButtonGems;
        private System.Windows.Forms.Label label5;
        private CustomControls.MoreControls.ToggleButton toggleButtonExp;
        private System.Windows.Forms.Label label4;
        private CustomControls.MoreControls.ToggleButton toggleButtonProjectiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserData;
        public System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton iconButtonSecHeroes;
        private FontAwesome.Sharp.IconButton iconButtonDLC1;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonDLC2;
        public System.Windows.Forms.Panel panelScreen;
        private FontAwesome.Sharp.IconButton iconButtonGenerate;
        private System.Windows.Forms.Label labelChangeAll;
        private CustomControls.MoreControls.ToggleButton toggleButtonChangeAll;
        private System.Windows.Forms.Label labelUnlocked;
        private CustomControls.MoreControls.ToggleButton toggleButtonUnlock;
        private System.Windows.Forms.Label label2;
        private CustomControls.MoreControls.ToggleButton toggleButtonUnlockAll;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDlcChecker;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

