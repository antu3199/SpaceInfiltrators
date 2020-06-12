namespace Space_Infiltrators
{
    partial class Instructions
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
            this.KeyInd = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Ndesc = new System.Windows.Forms.Label();
            this.Pdesc = new System.Windows.Forms.Label();
            this.Sdesc = new System.Windows.Forms.Label();
            this.Tdesc = new System.Windows.Forms.Label();
            this.TEnemy = new System.Windows.Forms.PictureBox();
            this.SEnemy = new System.Windows.Forms.PictureBox();
            this.PEnemy = new System.Windows.Forms.PictureBox();
            this.NEnemy = new System.Windows.Forms.PictureBox();
            this.Key2 = new System.Windows.Forms.PictureBox();
            this.Key1 = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Sshot = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackB)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyInd
            // 
            this.KeyInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyInd.Location = new System.Drawing.Point(275, 634);
            this.KeyInd.Name = "KeyInd";
            this.KeyInd.Size = new System.Drawing.Size(131, 23);
            this.KeyInd.TabIndex = 5;
            this.KeyInd.Text = "Left and Right Arrows";
            this.KeyInd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(575, 524);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(168, 91);
            this.Description.TabIndex = 6;
            this.Description.Text = "Moves the player left or right";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ndesc
            // 
            this.Ndesc.Location = new System.Drawing.Point(297, 63);
            this.Ndesc.Name = "Ndesc";
            this.Ndesc.Size = new System.Drawing.Size(422, 60);
            this.Ndesc.TabIndex = 11;
            this.Ndesc.Text = "The Normal Enemy. Has 2 health and shoots bullets that deal 15 damage.";
            this.Ndesc.Visible = false;
            // 
            // Pdesc
            // 
            this.Pdesc.Location = new System.Drawing.Point(297, 184);
            this.Pdesc.Name = "Pdesc";
            this.Pdesc.Size = new System.Drawing.Size(422, 60);
            this.Pdesc.TabIndex = 12;
            this.Pdesc.Text = "The Power Enemy. Has 3 health and shoots slightly faster bullets that deal 30 dam" +
                "age.";
            this.Pdesc.Visible = false;
            // 
            // Sdesc
            // 
            this.Sdesc.Location = new System.Drawing.Point(297, 298);
            this.Sdesc.Name = "Sdesc";
            this.Sdesc.Size = new System.Drawing.Size(422, 60);
            this.Sdesc.TabIndex = 13;
            this.Sdesc.Text = "The Speed Enemy. Has 3 health and shoots very fast bullets that deal 15 damage.";
            this.Sdesc.Visible = false;
            // 
            // Tdesc
            // 
            this.Tdesc.Location = new System.Drawing.Point(297, 422);
            this.Tdesc.Name = "Tdesc";
            this.Tdesc.Size = new System.Drawing.Size(422, 60);
            this.Tdesc.TabIndex = 14;
            this.Tdesc.Text = "The Tank Enemy. Has 7 health and shoots bullets that deal 25 damage.";
            this.Tdesc.Visible = false;
            // 
            // TEnemy
            // 
            this.TEnemy.Image = global::Space_Infiltrators.Properties.Resources.TEnemy;
            this.TEnemy.Location = new System.Drawing.Point(144, 422);
            this.TEnemy.Name = "TEnemy";
            this.TEnemy.Size = new System.Drawing.Size(82, 73);
            this.TEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TEnemy.TabIndex = 10;
            this.TEnemy.TabStop = false;
            this.TEnemy.Visible = false;
            // 
            // SEnemy
            // 
            this.SEnemy.Image = global::Space_Infiltrators.Properties.Resources.SEnemy;
            this.SEnemy.Location = new System.Drawing.Point(144, 298);
            this.SEnemy.Name = "SEnemy";
            this.SEnemy.Size = new System.Drawing.Size(82, 73);
            this.SEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SEnemy.TabIndex = 9;
            this.SEnemy.TabStop = false;
            this.SEnemy.Visible = false;
            // 
            // PEnemy
            // 
            this.PEnemy.Image = global::Space_Infiltrators.Properties.Resources.PEnemy;
            this.PEnemy.Location = new System.Drawing.Point(144, 171);
            this.PEnemy.Name = "PEnemy";
            this.PEnemy.Size = new System.Drawing.Size(82, 73);
            this.PEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PEnemy.TabIndex = 8;
            this.PEnemy.TabStop = false;
            this.PEnemy.Visible = false;
            // 
            // NEnemy
            // 
            this.NEnemy.Image = global::Space_Infiltrators.Properties.Resources.NormalE;
            this.NEnemy.Location = new System.Drawing.Point(144, 63);
            this.NEnemy.Name = "NEnemy";
            this.NEnemy.Size = new System.Drawing.Size(82, 73);
            this.NEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NEnemy.TabIndex = 7;
            this.NEnemy.TabStop = false;
            this.NEnemy.Visible = false;
            // 
            // Key2
            // 
            this.Key2.Image = global::Space_Infiltrators.Properties.Resources.RightKey;
            this.Key2.Location = new System.Drawing.Point(363, 524);
            this.Key2.Name = "Key2";
            this.Key2.Size = new System.Drawing.Size(100, 102);
            this.Key2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Key2.TabIndex = 4;
            this.Key2.TabStop = false;
            // 
            // Key1
            // 
            this.Key1.Image = global::Space_Infiltrators.Properties.Resources.LeftArrow;
            this.Key1.Location = new System.Drawing.Point(214, 524);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(103, 102);
            this.Key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Key1.TabIndex = 3;
            this.Key1.TabStop = false;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Image = global::Space_Infiltrators.Properties.Resources.ArrowR;
            this.Next.Location = new System.Drawing.Point(826, 524);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(135, 115);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Next.TabIndex = 2;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Image = global::Space_Infiltrators.Properties.Resources.ArrowL;
            this.Back.Location = new System.Drawing.Point(34, 524);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(135, 115);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 1;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Sshot
            // 
            this.Sshot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sshot.Image = global::Space_Infiltrators.Properties.Resources.S0;
            this.Sshot.Location = new System.Drawing.Point(70, 12);
            this.Sshot.Name = "Sshot";
            this.Sshot.Size = new System.Drawing.Size(757, 483);
            this.Sshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sshot.TabIndex = 0;
            this.Sshot.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(53, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 508);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BackB
            // 
            this.BackB.Image = global::Space_Infiltrators.Properties.Resources.BackB;
            this.BackB.Location = new System.Drawing.Point(852, 240);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(133, 77);
            this.BackB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackB.TabIndex = 17;
            this.BackB.TabStop = false;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.Tdesc);
            this.Controls.Add(this.Sdesc);
            this.Controls.Add(this.Pdesc);
            this.Controls.Add(this.Ndesc);
            this.Controls.Add(this.TEnemy);
            this.Controls.Add(this.SEnemy);
            this.Controls.Add(this.PEnemy);
            this.Controls.Add(this.NEnemy);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.KeyInd);
            this.Controls.Add(this.Key2);
            this.Controls.Add(this.Key1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sshot);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.Shown += new System.EventHandler(this.Instructions_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Instructions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Sshot;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Key1;
        private System.Windows.Forms.PictureBox Key2;
        private System.Windows.Forms.Label KeyInd;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox NEnemy;
        private System.Windows.Forms.PictureBox PEnemy;
        private System.Windows.Forms.PictureBox SEnemy;
        private System.Windows.Forms.PictureBox TEnemy;
        private System.Windows.Forms.Label Ndesc;
        private System.Windows.Forms.Label Pdesc;
        private System.Windows.Forms.Label Sdesc;
        private System.Windows.Forms.Label Tdesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BackB;
    }
}