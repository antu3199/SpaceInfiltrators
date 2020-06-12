//Anthony Tu
//January 21, 2013
//Space Infiltators game
//This is the Instructions. Includes 2 clickable back/forth buttons with screenshots and the ability to go back to the main menu.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Space_Infiltrators
{
    public partial class Instructions : Form
    {
        //Variable that allows to advance slides
        int advancetext = 0;
      

        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Shown(object sender, EventArgs e)
        {
            //Centers to screen
            this.CenterToScreen();
         //Allows to advance through slides
            advancetext = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //Maximum of 6 slides
            if (advancetext + 1 < 6)
            {
                advancetext += 1;
            }
          //When slide = 0
            if (advancetext == 0)
              {
                //Show picture 2
                  Key2.Visible = true;
                //Change images to Arrow keys
                  Key1.Image = Space_Infiltrators.Properties.Resources.LeftArrow;
                  Key2.Image = Space_Infiltrators.Properties.Resources.RightKey;
                  Key1.Location = new Point(215, Key1.Location.Y);
                //Change screen shot
                  Sshot.Image = Space_Infiltrators.Properties.Resources.S0; ;

              }
            //When slide = 1
            if (advancetext == 1 )
              {
                 //Hide Key2
                  Key2.Visible = false;
                //Change image of key
                  Key1.Image = Space_Infiltrators.Properties.Resources.ZKey;
                  Key1.Location = new Point(290, Key1.Location.Y);
                //Change text
                  KeyInd.Text = "Z Key";
                  Description.Text = "Shoots a bullet dealing 1 damage to enemies.";
                  //Change screen shot
                  Sshot.Image = Space_Infiltrators.Properties.Resources.S1; ;
              }
            //When slide = 2
            if (advancetext == 2 )
            {
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.XKey;
                //Change text
                KeyInd.Text = "X Key";
                Description.Text = "Shoots charging blast dealing 2 damage to enemies over a larger area. NOTE: The blast can be used simultaneously with the bullet.";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S2; ;
            }
            //When slide = 3
            if (advancetext == 3 )
            {
                Key1.Location = new Point(290, Key1.Location.Y);
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.CKey;
                //Change text
                KeyInd.Text = "C Key";
                Description.Text = "Shoots a massive laser dealing 2 damage per 300 miliseconds to the enemies under the beam. Can only be used when the laser bar is filled completely.";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S3 ;
            }
            //When slide = 4
            if (advancetext == 4 )
            {
                Key1.Size = new Size(355, Key1.Size.Height);
                Key1.Location = new Point(215, Key1.Location.Y);
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.SpaceKey;
                //Change text
                KeyInd.Text = "Space Key";
                Description.Text = "Releases an explosion that destroys all enemies on the screen. (Except for bosses, where it deals 10 damage)";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S4 ;
            }
            //When slide = 5
            if (advancetext == 5 )
            {
                //Disable all pictures and descriptions
                pictureBox1.Visible = false;
                Sshot.Visible = false;
                Key1.Image = null;
                KeyInd.Text = null;
                Description.Text = null;
                Sshot.Image = null;
                //Enable only the enemy descriptions
                NEnemy.Visible = true;
                PEnemy.Visible = true;
                SEnemy.Visible = true;
                TEnemy.Visible = true;
                Ndesc.Visible = true;
                Pdesc.Visible = true;
                Sdesc.Visible = true;
                Tdesc.Visible = true;
             
             
            }
           


        }

   

        private void Back_Click(object sender, EventArgs e)
        {
            //Minimum of 0 slides
            if (advancetext > 0)
            {
                advancetext -= 1;
            }
            //When slide = 0
            if (advancetext == 0 )
            {
             
                Key2.Visible = true;
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.LeftArrow;
                Key2.Image = Space_Infiltrators.Properties.Resources.RightKey;
                Key1.Location = new Point(215, Key1.Location.Y);
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S0 ;

            }
            //When slide = 1
            if (advancetext == 1)
            {
              
                Key2.Visible = false;
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.ZKey;
                Key1.Location = new Point(290, Key1.Location.Y);
                //Change text
                KeyInd.Text = "Z Key";
                Description.Text = "Shoots a bullet dealing 1 damage to enemies.";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S1 ;
            }
            //When slide = 2
            if (advancetext == 2)
            {
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.XKey;
                //Change text
                KeyInd.Text = "X Key";
                Description.Text = "Shoots charging blast dealing 2 damage to enemies over a larger area. NOTE: The blast can be used simultaneously with the bullet.";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S2 ;
            }
            //When slide = 3
            if (advancetext == 3 )
            {
                Key1.Size = new Size(103, Key1.Size.Height);
                Key1.Location = new Point(290, Key1.Location.Y);
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.CKey;
                //Change text
                KeyInd.Text = "C Key";
                Description.Text = "Shoots a massive laser dealing 2 damage per 300 miliseconds to the enemies under the beam. Can only be used when the laser bar is filled completely.";
                //Change screen shot
                Sshot.Image = Space_Infiltrators.Properties.Resources.S3 ;
            }
            //When slide = 4
            if (advancetext == 4 )
            {
                //Re-enable all from slide 5
                pictureBox1.Visible = true;
                Sshot.Visible = true;
                NEnemy.Visible = false;
                PEnemy.Visible = false;
                SEnemy.Visible = false;
                TEnemy.Visible = false;
                Ndesc.Visible = false;
                Pdesc.Visible = false;
                Sdesc.Visible = false;
                Tdesc.Visible = false;

                Key1.Size = new Size(355, Key1.Size.Height);
                Key1.Location = new Point(215, Key1.Location.Y);
                //Change image of key
                Key1.Image = Space_Infiltrators.Properties.Resources.SpaceKey;
                //Change text
                KeyInd.Text = "Space Key";
                Description.Text = "Releases an explosion that destroys all enemies on the screen. (Except for bosses, where it deals 10 damage)";
                Sshot.Image = Space_Infiltrators.Properties.Resources.S4; ;

            }

        }
        //Close entire application when x is clicked
        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            //Go back to main menu when back is clicked
            //Reset all variables and images
            advancetext = 0;
            Key2.Visible = true;
            Key1.Image = Space_Infiltrators.Properties.Resources.LeftArrow;
            Key2.Image = Space_Infiltrators.Properties.Resources.RightKey;
            Key1.Location = new Point(215, Key1.Location.Y);
            Sshot.Image = Space_Infiltrators.Properties.Resources.S0;
            //Change forms
            this.Hide();
            MainMenu frmMenu = new MainMenu();
            frmMenu.Show();
        }
        //Close entire application when x is clicked
        private void Instructions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
