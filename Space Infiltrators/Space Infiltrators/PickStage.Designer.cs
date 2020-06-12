namespace Space_Infiltrators
{
    partial class PickStage
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
            this.bStage1 = new System.Windows.Forms.PictureBox();
            this.Cube1 = new System.Windows.Forms.PictureBox();
            this.Cube2 = new System.Windows.Forms.PictureBox();
            this.Cube3 = new System.Windows.Forms.PictureBox();
            this.bStage2 = new System.Windows.Forms.PictureBox();
            this.bStage3 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bStage1
            // 
            this.bStage1.Image = global::Space_Infiltrators.Properties.Resources.Stage1;
            this.bStage1.Location = new System.Drawing.Point(52, 304);
            this.bStage1.Name = "bStage1";
            this.bStage1.Size = new System.Drawing.Size(221, 71);
            this.bStage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bStage1.TabIndex = 1;
            this.bStage1.TabStop = false;
            this.bStage1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Cube1
            // 
            this.Cube1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cube1.Image = global::Space_Infiltrators.Properties.Resources.BlueSquare;
            this.Cube1.Location = new System.Drawing.Point(12, 201);
            this.Cube1.Name = "Cube1";
            this.Cube1.Size = new System.Drawing.Size(306, 277);
            this.Cube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cube1.TabIndex = 0;
            this.Cube1.TabStop = false;
            this.Cube1.Click += new System.EventHandler(this.Cube1_Click);
            // 
            // Cube2
            // 
            this.Cube2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cube2.Image = global::Space_Infiltrators.Properties.Resources.BlueSquare;
            this.Cube2.Location = new System.Drawing.Point(340, 201);
            this.Cube2.Name = "Cube2";
            this.Cube2.Size = new System.Drawing.Size(306, 277);
            this.Cube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cube2.TabIndex = 2;
            this.Cube2.TabStop = false;
            this.Cube2.Click += new System.EventHandler(this.Cube2_Click);
            // 
            // Cube3
            // 
            this.Cube3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cube3.Image = global::Space_Infiltrators.Properties.Resources.BlueSquare;
            this.Cube3.Location = new System.Drawing.Point(666, 201);
            this.Cube3.Name = "Cube3";
            this.Cube3.Size = new System.Drawing.Size(306, 277);
            this.Cube3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cube3.TabIndex = 3;
            this.Cube3.TabStop = false;
            this.Cube3.Click += new System.EventHandler(this.Cube3_Click);
            // 
            // bStage2
            // 
            this.bStage2.Image = global::Space_Infiltrators.Properties.Resources.Stage2;
            this.bStage2.Location = new System.Drawing.Point(386, 304);
            this.bStage2.Name = "bStage2";
            this.bStage2.Size = new System.Drawing.Size(221, 71);
            this.bStage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bStage2.TabIndex = 4;
            this.bStage2.TabStop = false;
            this.bStage2.Click += new System.EventHandler(this.bStage2_Click);
            // 
            // bStage3
            // 
            this.bStage3.Image = global::Space_Infiltrators.Properties.Resources.Stage3;
            this.bStage3.Location = new System.Drawing.Point(712, 304);
            this.bStage3.Name = "bStage3";
            this.bStage3.Size = new System.Drawing.Size(221, 71);
            this.bStage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bStage3.TabIndex = 5;
            this.bStage3.TabStop = false;
            this.bStage3.Click += new System.EventHandler(this.bStage3_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = global::Space_Infiltrators.Properties.Resources.BackB;
            this.BackButton.Location = new System.Drawing.Point(857, 640);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 60);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 6;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PickStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Infiltrators.Properties.Resources.Universe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.bStage3);
            this.Controls.Add(this.bStage2);
            this.Controls.Add(this.Cube3);
            this.Controls.Add(this.Cube2);
            this.Controls.Add(this.bStage1);
            this.Controls.Add(this.Cube1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PickStage";
            this.Text = "PickStage";
            this.Shown += new System.EventHandler(this.PickStage_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PickStage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Cube1;
        private System.Windows.Forms.PictureBox bStage1;
        private System.Windows.Forms.PictureBox Cube2;
        private System.Windows.Forms.PictureBox Cube3;
        private System.Windows.Forms.PictureBox bStage2;
        private System.Windows.Forms.PictureBox bStage3;
        private System.Windows.Forms.PictureBox BackButton;
    }
}