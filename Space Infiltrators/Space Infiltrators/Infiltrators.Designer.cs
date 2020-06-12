namespace Space_Infiltrators
{
    partial class Infiltrators
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infiltrators));
            this.InvaderTimer = new System.Windows.Forms.Timer(this.components);
            this.ubullettmr = new System.Windows.Forms.Timer(this.components);
            this.picUser = new System.Windows.Forms.PictureBox();
            this.ebulletdelay = new System.Windows.Forms.Timer(this.components);
            this.ebullettmr = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserHealth = new System.Windows.Forms.ProgressBar();
            this.movet = new System.Windows.Forms.Timer(this.components);
            this.Universal = new System.Windows.Forms.Timer(this.components);
            this.ubullettmr2 = new System.Windows.Forms.Timer(this.components);
            this.ubulletdelaytmr = new System.Windows.Forms.Timer(this.components);
            this.ebulletdelay2 = new System.Windows.Forms.Timer(this.components);
            this.ebulletdelay3 = new System.Windows.Forms.Timer(this.components);
            this.PicBombBar = new System.Windows.Forms.PictureBox();
            this.PicLive1 = new System.Windows.Forms.PictureBox();
            this.PicLive2 = new System.Windows.Forms.PictureBox();
            this.PicLive3 = new System.Windows.Forms.PictureBox();
            this.PicLaserBar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spawntmr = new System.Windows.Forms.Timer(this.components);
            this.BossHP = new System.Windows.Forms.ProgressBar();
            this.EpicText = new System.Windows.Forms.Label();
            this.BossTimer = new System.Windows.Forms.Timer(this.components);
            this.Warning8 = new System.Windows.Forms.PictureBox();
            this.Warning7 = new System.Windows.Forms.PictureBox();
            this.Warning6 = new System.Windows.Forms.PictureBox();
            this.Warning5 = new System.Windows.Forms.PictureBox();
            this.Warning4 = new System.Windows.Forms.PictureBox();
            this.Warning3 = new System.Windows.Forms.PictureBox();
            this.Warning2 = new System.Windows.Forms.PictureBox();
            this.Warning1 = new System.Windows.Forms.PictureBox();
            this.LaserDelay = new System.Windows.Forms.Timer(this.components);
            this.uBlastDelaytmr = new System.Windows.Forms.Timer(this.components);
            this.ublasttmr = new System.Windows.Forms.Timer(this.components);
            this.BossExplosion = new System.Windows.Forms.Timer(this.components);
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            this.Boss2eSpawn = new System.Windows.Forms.Timer(this.components);
            this.uLaserTimer = new System.Windows.Forms.Timer(this.components);
            this.uBombTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBombBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLaserBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning1)).BeginInit();
            this.SuspendLayout();
            // 
            // InvaderTimer
            // 
            this.InvaderTimer.Interval = 2250;
            this.InvaderTimer.Tick += new System.EventHandler(this.InvaderTimer_Tick);
            // 
            // ubullettmr
            // 
            this.ubullettmr.Interval = 30;
            this.ubullettmr.Tick += new System.EventHandler(this.ubullettmr_Tick_1);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = global::Space_Infiltrators.Properties.Resources.Battlecruiser;
            this.picUser.Location = new System.Drawing.Point(469, 503);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(60, 65);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 10;
            this.picUser.TabStop = false;
            // 
            // ebulletdelay
            // 
            this.ebulletdelay.Interval = 2500;
            this.ebulletdelay.Tick += new System.EventHandler(this.ebulletdelay_Tick);
            // 
            // ebullettmr
            // 
            this.ebullettmr.Interval = 30;
            this.ebullettmr.Tick += new System.EventHandler(this.ebullettmr_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 184);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // UserHealth
            // 
            this.UserHealth.Location = new System.Drawing.Point(15, 590);
            this.UserHealth.Name = "UserHealth";
            this.UserHealth.Size = new System.Drawing.Size(766, 23);
            this.UserHealth.TabIndex = 18;
            this.UserHealth.Value = 100;
            // 
            // movet
            // 
            this.movet.Interval = 30;
            this.movet.Tick += new System.EventHandler(this.movet_Tick);
            // 
            // Universal
            // 
            this.Universal.Interval = 30;
            this.Universal.Tick += new System.EventHandler(this.Universal_Tick);
            // 
            // ubullettmr2
            // 
            this.ubullettmr2.Interval = 30;
            this.ubullettmr2.Tick += new System.EventHandler(this.ubullettmr2_Tick);
            // 
            // ubulletdelaytmr
            // 
            this.ubulletdelaytmr.Interval = 500;
            this.ubulletdelaytmr.Tick += new System.EventHandler(this.ubulletdelaytmr_Tick);
            // 
            // ebulletdelay2
            // 
            this.ebulletdelay2.Interval = 2000;
            this.ebulletdelay2.Tick += new System.EventHandler(this.ebulletdelay2_Tick);
            // 
            // ebulletdelay3
            // 
            this.ebulletdelay3.Interval = 3500;
            this.ebulletdelay3.Tick += new System.EventHandler(this.ebulletdelay3_Tick);
            // 
            // PicBombBar
            // 
            this.PicBombBar.Image = global::Space_Infiltrators.Properties.Resources.bluebar;
            this.PicBombBar.Location = new System.Drawing.Point(15, 630);
            this.PicBombBar.Name = "PicBombBar";
            this.PicBombBar.Size = new System.Drawing.Size(766, 20);
            this.PicBombBar.TabIndex = 21;
            this.PicBombBar.TabStop = false;
            // 
            // PicLive1
            // 
            this.PicLive1.Image = ((System.Drawing.Image)(resources.GetObject("PicLive1.Image")));
            this.PicLive1.Location = new System.Drawing.Point(784, 585);
            this.PicLive1.Name = "PicLive1";
            this.PicLive1.Size = new System.Drawing.Size(60, 65);
            this.PicLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLive1.TabIndex = 22;
            this.PicLive1.TabStop = false;
            // 
            // PicLive2
            // 
            this.PicLive2.Image = ((System.Drawing.Image)(resources.GetObject("PicLive2.Image")));
            this.PicLive2.Location = new System.Drawing.Point(850, 585);
            this.PicLive2.Name = "PicLive2";
            this.PicLive2.Size = new System.Drawing.Size(60, 65);
            this.PicLive2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLive2.TabIndex = 23;
            this.PicLive2.TabStop = false;
            // 
            // PicLive3
            // 
            this.PicLive3.Image = ((System.Drawing.Image)(resources.GetObject("PicLive3.Image")));
            this.PicLive3.Location = new System.Drawing.Point(912, 585);
            this.PicLive3.Name = "PicLive3";
            this.PicLive3.Size = new System.Drawing.Size(60, 65);
            this.PicLive3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLive3.TabIndex = 24;
            this.PicLive3.TabStop = false;
            // 
            // PicLaserBar
            // 
            this.PicLaserBar.Image = global::Space_Infiltrators.Properties.Resources.redbar;
            this.PicLaserBar.Location = new System.Drawing.Point(15, 666);
            this.PicLaserBar.Name = "PicLaserBar";
            this.PicLaserBar.Size = new System.Drawing.Size(766, 20);
            this.PicLaserBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLaserBar.TabIndex = 25;
            this.PicLaserBar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Health:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bomb:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 653);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "Laser:";
            // 
            // spawntmr
            // 
            this.spawntmr.Interval = 30;
            this.spawntmr.Tick += new System.EventHandler(this.spawntmr_Tick);
            // 
            // BossHP
            // 
            this.BossHP.Location = new System.Drawing.Point(-1, 1);
            this.BossHP.Name = "BossHP";
            this.BossHP.Size = new System.Drawing.Size(782, 23);
            this.BossHP.TabIndex = 33;
            this.BossHP.Value = 50;
            this.BossHP.Visible = false;
            // 
            // EpicText
            // 
            this.EpicText.BackColor = System.Drawing.Color.SlateGray;
            this.EpicText.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpicText.Location = new System.Drawing.Point(780, 1);
            this.EpicText.Name = "EpicText";
            this.EpicText.Size = new System.Drawing.Size(204, 23);
            this.EpicText.TabIndex = 34;
            this.EpicText.Text = "Boss: StarShip";
            this.EpicText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EpicText.Visible = false;
            // 
            // BossTimer
            // 
            this.BossTimer.Interval = 30;
            this.BossTimer.Tick += new System.EventHandler(this.BossTimer_Tick);
            // 
            // Warning8
            // 
            this.Warning8.BackColor = System.Drawing.Color.Transparent;
            this.Warning8.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning8.Location = new System.Drawing.Point(867, 527);
            this.Warning8.Name = "Warning8";
            this.Warning8.Size = new System.Drawing.Size(119, 38);
            this.Warning8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning8.TabIndex = 35;
            this.Warning8.TabStop = false;
            this.Warning8.Visible = false;
            // 
            // Warning7
            // 
            this.Warning7.BackColor = System.Drawing.Color.Transparent;
            this.Warning7.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning7.Location = new System.Drawing.Point(743, 527);
            this.Warning7.Name = "Warning7";
            this.Warning7.Size = new System.Drawing.Size(119, 38);
            this.Warning7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning7.TabIndex = 36;
            this.Warning7.TabStop = false;
            this.Warning7.Visible = false;
            // 
            // Warning6
            // 
            this.Warning6.BackColor = System.Drawing.Color.Transparent;
            this.Warning6.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning6.Location = new System.Drawing.Point(618, 527);
            this.Warning6.Name = "Warning6";
            this.Warning6.Size = new System.Drawing.Size(119, 38);
            this.Warning6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning6.TabIndex = 37;
            this.Warning6.TabStop = false;
            this.Warning6.Visible = false;
            // 
            // Warning5
            // 
            this.Warning5.BackColor = System.Drawing.Color.Transparent;
            this.Warning5.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning5.Location = new System.Drawing.Point(486, 527);
            this.Warning5.Name = "Warning5";
            this.Warning5.Size = new System.Drawing.Size(119, 38);
            this.Warning5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning5.TabIndex = 38;
            this.Warning5.TabStop = false;
            this.Warning5.Visible = false;
            // 
            // Warning4
            // 
            this.Warning4.BackColor = System.Drawing.Color.Transparent;
            this.Warning4.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning4.Location = new System.Drawing.Point(361, 527);
            this.Warning4.Name = "Warning4";
            this.Warning4.Size = new System.Drawing.Size(119, 38);
            this.Warning4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning4.TabIndex = 39;
            this.Warning4.TabStop = false;
            this.Warning4.Visible = false;
            // 
            // Warning3
            // 
            this.Warning3.BackColor = System.Drawing.Color.Transparent;
            this.Warning3.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning3.Location = new System.Drawing.Point(236, 527);
            this.Warning3.Name = "Warning3";
            this.Warning3.Size = new System.Drawing.Size(119, 38);
            this.Warning3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning3.TabIndex = 40;
            this.Warning3.TabStop = false;
            this.Warning3.Visible = false;
            // 
            // Warning2
            // 
            this.Warning2.BackColor = System.Drawing.Color.Transparent;
            this.Warning2.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning2.Location = new System.Drawing.Point(111, 527);
            this.Warning2.Name = "Warning2";
            this.Warning2.Size = new System.Drawing.Size(119, 38);
            this.Warning2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning2.TabIndex = 41;
            this.Warning2.TabStop = false;
            this.Warning2.Visible = false;
            // 
            // Warning1
            // 
            this.Warning1.BackColor = System.Drawing.Color.Transparent;
            this.Warning1.Image = global::Space_Infiltrators.Properties.Resources.Warning;
            this.Warning1.Location = new System.Drawing.Point(-14, 527);
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(119, 38);
            this.Warning1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning1.TabIndex = 42;
            this.Warning1.TabStop = false;
            this.Warning1.Visible = false;
            // 
            // LaserDelay
            // 
            this.LaserDelay.Interval = 300;
            this.LaserDelay.Tick += new System.EventHandler(this.LaserDelay_Tick);
            // 
            // uBlastDelaytmr
            // 
            this.uBlastDelaytmr.Interval = 2000;
            this.uBlastDelaytmr.Tick += new System.EventHandler(this.uBlastDelaytmr_Tick);
            // 
            // ublasttmr
            // 
            this.ublasttmr.Interval = 30;
            this.ublasttmr.Tick += new System.EventHandler(this.ublasttmr_Tick);
            // 
            // BossExplosion
            // 
            this.BossExplosion.Interval = 30;
            this.BossExplosion.Tick += new System.EventHandler(this.BossExplosion_Tick);
            // 
            // MusicTimer
            // 
            this.MusicTimer.Interval = 30;
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // Boss2eSpawn
            // 
            this.Boss2eSpawn.Interval = 2000;
            this.Boss2eSpawn.Tick += new System.EventHandler(this.Boss2eSpawn_Tick);
            // 
            // uLaserTimer
            // 
            this.uLaserTimer.Interval = 30;
            this.uLaserTimer.Tick += new System.EventHandler(this.uLaserTimer_Tick);
            // 
            // uBombTimer
            // 
            this.uBombTimer.Interval = 30;
            this.uBombTimer.Tick += new System.EventHandler(this.uBombTimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.SlateGray;
            this.lblScore.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(107, 574);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(674, 13);
            this.lblScore.TabIndex = 50;
            this.lblScore.Text = "SCORE:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Infiltrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Infiltrators.Properties.Resources.stars1;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.EpicText);
            this.Controls.Add(this.BossHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PicLaserBar);
            this.Controls.Add(this.PicLive3);
            this.Controls.Add(this.PicLive2);
            this.Controls.Add(this.PicLive1);
            this.Controls.Add(this.PicBombBar);
            this.Controls.Add(this.UserHealth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Warning1);
            this.Controls.Add(this.Warning2);
            this.Controls.Add(this.Warning3);
            this.Controls.Add(this.Warning4);
            this.Controls.Add(this.Warning5);
            this.Controls.Add(this.Warning6);
            this.Controls.Add(this.Warning7);
            this.Controls.Add(this.Warning8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Infiltrators";
            this.Text = "Space Infiltrators";
            this.Shown += new System.EventHandler(this.Infiltrators_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Infiltrators_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBombBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLive3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLaserBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Timer InvaderTimer;
        private System.Windows.Forms.Timer ubullettmr;
        private System.Windows.Forms.Timer ebulletdelay;
        private System.Windows.Forms.Timer ebullettmr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar UserHealth;
        private System.Windows.Forms.Timer movet;
        private System.Windows.Forms.Timer Universal;
        private System.Windows.Forms.Timer ubullettmr2;
        private System.Windows.Forms.Timer ubulletdelaytmr;
        private System.Windows.Forms.Timer ebulletdelay2;
        private System.Windows.Forms.Timer ebulletdelay3;
        private System.Windows.Forms.PictureBox PicBombBar;
        private System.Windows.Forms.PictureBox PicLive1;
        private System.Windows.Forms.PictureBox PicLive2;
        private System.Windows.Forms.PictureBox PicLive3;
        private System.Windows.Forms.PictureBox PicLaserBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer spawntmr;
        private System.Windows.Forms.ProgressBar BossHP;
        private System.Windows.Forms.Label EpicText;
        private System.Windows.Forms.Timer BossTimer;
        private System.Windows.Forms.PictureBox Warning8;
        private System.Windows.Forms.PictureBox Warning7;
        private System.Windows.Forms.PictureBox Warning6;
        private System.Windows.Forms.PictureBox Warning5;
        private System.Windows.Forms.PictureBox Warning4;
        private System.Windows.Forms.PictureBox Warning3;
        private System.Windows.Forms.PictureBox Warning2;
        private System.Windows.Forms.PictureBox Warning1;
        private System.Windows.Forms.Timer LaserDelay;
        private System.Windows.Forms.Timer uBlastDelaytmr;
        private System.Windows.Forms.Timer ublasttmr;
        private System.Windows.Forms.Timer BossExplosion;
        private System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.Timer Boss2eSpawn;
        private System.Windows.Forms.Timer uLaserTimer;
        private System.Windows.Forms.Timer uBombTimer;
        private System.Windows.Forms.Label lblScore;
    }
}

