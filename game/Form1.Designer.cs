
namespace game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wizard = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.swordsman = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.horizontalPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.magic1 = new System.Windows.Forms.PictureBox();
            this.spear2 = new System.Windows.Forms.PictureBox();
            this.sword2 = new System.Windows.Forms.PictureBox();
            this.none = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wizardBackpack = new System.Windows.Forms.Label();
            this.wizardScore = new System.Windows.Forms.Label();
            this.swordsmanBackpack = new System.Windows.Forms.Label();
            this.swordsmanScore = new System.Windows.Forms.Label();
            this.wizardHealth = new System.Windows.Forms.Label();
            this.swordsmanHealth = new System.Windows.Forms.Label();
            this.wizardMessage = new System.Windows.Forms.Label();
            this.swordsmanMessage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.magic2 = new System.Windows.Forms.PictureBox();
            this.spear1 = new System.Windows.Forms.PictureBox();
            this.sword1 = new System.Windows.Forms.PictureBox();
            this.wizardActiveWeapon = new System.Windows.Forms.Label();
            this.swordsmanActiveWeapon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordsman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(8, 925);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1033, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // wizard
            // 
            this.wizard.BackColor = System.Drawing.Color.Transparent;
            this.wizard.Image = ((System.Drawing.Image)(resources.GetObject("wizard.Image")));
            this.wizard.Location = new System.Drawing.Point(27, 856);
            this.wizard.Name = "wizard";
            this.wizard.Size = new System.Drawing.Size(53, 63);
            this.wizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wizard.TabIndex = 1;
            this.wizard.TabStop = false;
            this.wizard.Tag = "heroes";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // swordsman
            // 
            this.swordsman.BackColor = System.Drawing.Color.Transparent;
            this.swordsman.Image = ((System.Drawing.Image)(resources.GetObject("swordsman.Image")));
            this.swordsman.Location = new System.Drawing.Point(969, 856);
            this.swordsman.Name = "swordsman";
            this.swordsman.Size = new System.Drawing.Size(53, 63);
            this.swordsman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordsman.TabIndex = 3;
            this.swordsman.TabStop = false;
            this.swordsman.Tag = "heroes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(241, 805);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // verticalPlatform
            // 
            this.verticalPlatform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verticalPlatform.Location = new System.Drawing.Point(12, 740);
            this.verticalPlatform.Name = "verticalPlatform";
            this.verticalPlatform.Size = new System.Drawing.Size(227, 30);
            this.verticalPlatform.TabIndex = 5;
            this.verticalPlatform.TabStop = false;
            this.verticalPlatform.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(279, 548);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(525, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // horizontalPlatform
            // 
            this.horizontalPlatform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.horizontalPlatform.Location = new System.Drawing.Point(12, 431);
            this.horizontalPlatform.Name = "horizontalPlatform";
            this.horizontalPlatform.Size = new System.Drawing.Size(207, 30);
            this.horizontalPlatform.TabIndex = 7;
            this.horizontalPlatform.TabStop = false;
            this.horizontalPlatform.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox6.Location = new System.Drawing.Point(501, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(164, 30);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // magic1
            // 
            this.magic1.BackColor = System.Drawing.Color.Transparent;
            this.magic1.Image = ((System.Drawing.Image)(resources.GetObject("magic1.Image")));
            this.magic1.Location = new System.Drawing.Point(932, 658);
            this.magic1.Name = "magic1";
            this.magic1.Size = new System.Drawing.Size(53, 40);
            this.magic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magic1.TabIndex = 9;
            this.magic1.TabStop = false;
            this.magic1.Tag = "weapons";
            // 
            // spear2
            // 
            this.spear2.BackColor = System.Drawing.Color.Transparent;
            this.spear2.Image = ((System.Drawing.Image)(resources.GetObject("spear2.Image")));
            this.spear2.Location = new System.Drawing.Point(343, 759);
            this.spear2.Name = "spear2";
            this.spear2.Size = new System.Drawing.Size(53, 40);
            this.spear2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spear2.TabIndex = 10;
            this.spear2.TabStop = false;
            this.spear2.Tag = "weapons";
            // 
            // sword2
            // 
            this.sword2.BackColor = System.Drawing.Color.Transparent;
            this.sword2.Image = ((System.Drawing.Image)(resources.GetObject("sword2.Image")));
            this.sword2.Location = new System.Drawing.Point(126, 199);
            this.sword2.Name = "sword2";
            this.sword2.Size = new System.Drawing.Size(53, 40);
            this.sword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword2.TabIndex = 11;
            this.sword2.TabStop = false;
            this.sword2.Tag = "weapons";
            // 
            // none
            // 
            this.none.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.none.Location = new System.Drawing.Point(8, 10);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(202, 23);
            this.none.TabIndex = 12;
            this.none.Text = "Wizard:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(210, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Swordsman:";
            // 
            // wizardBackpack
            // 
            this.wizardBackpack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wizardBackpack.Location = new System.Drawing.Point(8, 41);
            this.wizardBackpack.Name = "wizardBackpack";
            this.wizardBackpack.Size = new System.Drawing.Size(341, 29);
            this.wizardBackpack.TabIndex = 14;
            this.wizardBackpack.Text = "Backpack: empty";
            // 
            // wizardScore
            // 
            this.wizardScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wizardScore.Location = new System.Drawing.Point(8, 125);
            this.wizardScore.Name = "wizardScore";
            this.wizardScore.Size = new System.Drawing.Size(144, 25);
            this.wizardScore.TabIndex = 15;
            this.wizardScore.Text = "Score: 0";
            // 
            // swordsmanBackpack
            // 
            this.swordsmanBackpack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swordsmanBackpack.Location = new System.Drawing.Point(703, 41);
            this.swordsmanBackpack.Name = "swordsmanBackpack";
            this.swordsmanBackpack.Size = new System.Drawing.Size(330, 29);
            this.swordsmanBackpack.TabIndex = 16;
            this.swordsmanBackpack.Text = "Backpack: empty";
            // 
            // swordsmanScore
            // 
            this.swordsmanScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swordsmanScore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.swordsmanScore.Location = new System.Drawing.Point(703, 125);
            this.swordsmanScore.Name = "swordsmanScore";
            this.swordsmanScore.Size = new System.Drawing.Size(198, 25);
            this.swordsmanScore.TabIndex = 17;
            this.swordsmanScore.Text = "Score: 0";
            // 
            // wizardHealth
            // 
            this.wizardHealth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wizardHealth.Location = new System.Drawing.Point(8, 99);
            this.wizardHealth.Name = "wizardHealth";
            this.wizardHealth.Size = new System.Drawing.Size(144, 26);
            this.wizardHealth.TabIndex = 18;
            this.wizardHealth.Text = "Helath:";
            // 
            // swordsmanHealth
            // 
            this.swordsmanHealth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swordsmanHealth.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.swordsmanHealth.Location = new System.Drawing.Point(703, 99);
            this.swordsmanHealth.Name = "swordsmanHealth";
            this.swordsmanHealth.Size = new System.Drawing.Size(172, 26);
            this.swordsmanHealth.TabIndex = 19;
            this.swordsmanHealth.Text = "Helath:";
            // 
            // wizardMessage
            // 
            this.wizardMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wizardMessage.ForeColor = System.Drawing.Color.Red;
            this.wizardMessage.Location = new System.Drawing.Point(8, 160);
            this.wizardMessage.Name = "wizardMessage";
            this.wizardMessage.Size = new System.Drawing.Size(474, 36);
            this.wizardMessage.TabIndex = 20;
            // 
            // swordsmanMessage
            // 
            this.swordsmanMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swordsmanMessage.ForeColor = System.Drawing.Color.Red;
            this.swordsmanMessage.Location = new System.Drawing.Point(604, 160);
            this.swordsmanMessage.Name = "swordsmanMessage";
            this.swordsmanMessage.Size = new System.Drawing.Size(441, 36);
            this.swordsmanMessage.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(94, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 30);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox5.Location = new System.Drawing.Point(739, 330);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(302, 30);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox7.Location = new System.Drawing.Point(717, 704);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(290, 30);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // magic2
            // 
            this.magic2.BackColor = System.Drawing.Color.Transparent;
            this.magic2.Image = ((System.Drawing.Image)(resources.GetObject("magic2.Image")));
            this.magic2.Location = new System.Drawing.Point(582, 235);
            this.magic2.Name = "magic2";
            this.magic2.Size = new System.Drawing.Size(53, 40);
            this.magic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magic2.TabIndex = 25;
            this.magic2.TabStop = false;
            this.magic2.Tag = "weapons";
            // 
            // spear1
            // 
            this.spear1.BackColor = System.Drawing.Color.Transparent;
            this.spear1.Image = ((System.Drawing.Image)(resources.GetObject("spear1.Image")));
            this.spear1.Location = new System.Drawing.Point(969, 284);
            this.spear1.Name = "spear1";
            this.spear1.Size = new System.Drawing.Size(53, 40);
            this.spear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spear1.TabIndex = 26;
            this.spear1.TabStop = false;
            this.spear1.Tag = "weapons";
            // 
            // sword1
            // 
            this.sword1.BackColor = System.Drawing.Color.Transparent;
            this.sword1.Image = ((System.Drawing.Image)(resources.GetObject("sword1.Image")));
            this.sword1.Location = new System.Drawing.Point(669, 492);
            this.sword1.Name = "sword1";
            this.sword1.Size = new System.Drawing.Size(53, 40);
            this.sword1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword1.TabIndex = 27;
            this.sword1.TabStop = false;
            this.sword1.Tag = "weapons";
            // 
            // wizardActiveWeapon
            // 
            this.wizardActiveWeapon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wizardActiveWeapon.Location = new System.Drawing.Point(5, 70);
            this.wizardActiveWeapon.Name = "wizardActiveWeapon";
            this.wizardActiveWeapon.Size = new System.Drawing.Size(205, 26);
            this.wizardActiveWeapon.TabIndex = 28;
            this.wizardActiveWeapon.Text = "Activ weapon:";
            // 
            // swordsmanActiveWeapon
            // 
            this.swordsmanActiveWeapon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swordsmanActiveWeapon.Location = new System.Drawing.Point(703, 70);
            this.swordsmanActiveWeapon.Name = "swordsmanActiveWeapon";
            this.swordsmanActiveWeapon.Size = new System.Drawing.Size(250, 26);
            this.swordsmanActiveWeapon.TabIndex = 29;
            this.swordsmanActiveWeapon.Text = "Active weapon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1057, 954);
            this.Controls.Add(this.swordsmanActiveWeapon);
            this.Controls.Add(this.wizardActiveWeapon);
            this.Controls.Add(this.sword1);
            this.Controls.Add(this.spear1);
            this.Controls.Add(this.magic2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.swordsmanMessage);
            this.Controls.Add(this.wizardMessage);
            this.Controls.Add(this.swordsmanHealth);
            this.Controls.Add(this.wizardHealth);
            this.Controls.Add(this.swordsmanScore);
            this.Controls.Add(this.swordsmanBackpack);
            this.Controls.Add(this.wizardScore);
            this.Controls.Add(this.wizardBackpack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.none);
            this.Controls.Add(this.sword2);
            this.Controls.Add(this.spear2);
            this.Controls.Add(this.magic1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.horizontalPlatform);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.verticalPlatform);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.swordsman);
            this.Controls.Add(this.wizard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Game Platform";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordsman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox wizard;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox swordsman;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox verticalPlatform;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox horizontalPlatform;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox magic1;
        private System.Windows.Forms.PictureBox spear2;
        private System.Windows.Forms.PictureBox sword2;
        private System.Windows.Forms.Label none;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wizardBackpack;
        private System.Windows.Forms.Label wizardScore;
        private System.Windows.Forms.Label swordsmanBackpack;
        private System.Windows.Forms.Label swordsmanScore;
        private System.Windows.Forms.Label wizardHealth;
        private System.Windows.Forms.Label swordsmanHealth;
        private System.Windows.Forms.Label wizardMessage;
        private System.Windows.Forms.Label swordsmanMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox magic2;
        private System.Windows.Forms.PictureBox spear1;
        private System.Windows.Forms.PictureBox sword1;
        private System.Windows.Forms.Label wizardActiveWeapon;
        private System.Windows.Forms.Label swordsmanActiveWeapon;
    }
}

