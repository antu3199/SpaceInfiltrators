namespace Space_Infiltrators
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Infiltratorstext = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
            this.instructions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Infiltratorstext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).BeginInit();
            this.SuspendLayout();
            // 
            // Infiltratorstext
            // 
            this.Infiltratorstext.BackColor = System.Drawing.Color.Transparent;
            this.Infiltratorstext.Image = global::Space_Infiltrators.Properties.Resources.SpaceInfiltratorstext;
            this.Infiltratorstext.Location = new System.Drawing.Point(12, 23);
            this.Infiltratorstext.Name = "Infiltratorstext";
            this.Infiltratorstext.Size = new System.Drawing.Size(961, 265);
            this.Infiltratorstext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Infiltratorstext.TabIndex = 1;
            this.Infiltratorstext.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Image = global::Space_Infiltrators.Properties.Resources.Startbutton;
            this.StartButton.Location = new System.Drawing.Point(383, 378);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(218, 76);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartButton.TabIndex = 3;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(86, 419);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(8, 8);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MusicTimer
            // 
            this.MusicTimer.Enabled = true;
            this.MusicTimer.Interval = 30;
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Image = global::Space_Infiltrators.Properties.Resources.Instructionsbutton;
            this.instructions.Location = new System.Drawing.Point(338, 492);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(308, 93);
            this.instructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instructions.TabIndex = 9;
            this.instructions.TabStop = false;
            this.instructions.Click += new System.EventHandler(this.instructions_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Infiltratorstext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Infiltratorstext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Infiltratorstext;
        private System.Windows.Forms.PictureBox StartButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.Timer MusicTimer;
        private System.Windows.Forms.PictureBox instructions;
    }
}