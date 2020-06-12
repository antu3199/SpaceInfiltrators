//Anthony Tu
//January 21, 2013
//Space Infiltators game
//What happens when you lose all lives. Text is displayed over time with sad music.

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
    public partial class Winner2 : Form
    {
        int advance = 0;
        public Winner2()
        {
            InitializeComponent();
        }
        //MUsic
        WMPLib.WindowsMediaPlayer mplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer mplayer2 = new WMPLib.WindowsMediaPlayer();
        private void Lose_Shown(object sender, EventArgs e)
        {
            //Center to screen
            this.CenterToScreen();
            //Enable text timer
            Advance.Enabled = true;
          
            //Set music USL
            mplayer.URL = "E:\\TEJ3\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SadSong.mp3";
            mplayer2.URL = "C:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SadSong.mp3";
           // mplayer2.URL = "F:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SadSong.mp3";
            mplayer.controls.play();
            mplayer2.controls.play();
        }
     

        private void Advance_Tick(object sender, EventArgs e)
        {
          //Advance text over time
                advance += 1;
            
            //Label 1 display
            if (advance == 1)
                 {
                     label1.Visible = true;
                 }
            //Label 2 display
            if (advance == 2)
            {
                label2.Visible = true;
            }
            //Label 3 display
            if (advance == 3)
            {
                label3.Visible = true;
            }
            //Label 4 display
            if (advance == 4)
            {
                label4.Visible = true;
            }
            //Calculate final score and rank
            if (advance == 5)
            {
                label5.Text = "Your final score is: " + Convert.ToString(Infiltrators.score);
               label5.Visible = true;
                //Calculate rank
               if (Infiltrators.score < 0)
               {
                   label6.Text = "How is this even possible?";
               }
               if (Infiltrators.score < 30000 && Infiltrators.score > 0)
               {
                   label6.Text = "Horrible";
               }
               if (Infiltrators.score > 30000)
               {
                   label6.Text = "Try Harder!";
               }
               if (Infiltrators.score > 120000)
               {
                   label6.Text = "Not Bad";
               }
               if (Infiltrators.score > 170000)
               {
                   label6.Text = "K";
               }
               if (Infiltrators.score > 230000)
               {
                   label6.Text = "Acceptable";
               }
               if (Infiltrators.score > 300000)
               {
                   label6.Text = "Getting better!";
               }
               if (Infiltrators.score > 350000)
               {
                   label6.Text = "Okay";
               }
               if (Infiltrators.score > 450000)
               {
                   label6.Text = "Alright";
               }
               if (Infiltrators.score > 500000)
               {
                   label6.Text = "Good";
               }
               if (Infiltrators.score > 550000)
               {
                   label6.Text = "Great!";
               }
               if (Infiltrators.score > 600000)
               {
                   label6.Text = "Pretty good!";
               }
               if (Infiltrators.score > 650000)
               {
                   label6.Text = "Space Infiltrators Pro";
               }
             
               label6.Visible = true;
              
            }
   

        }

        private void Lose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
  
    }
}
