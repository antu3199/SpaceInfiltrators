//Anthony Tu
//January 21, 2013
//Space Infiltators game
//What happens when you beat boss3. Plays happy music.
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
    public partial class YouWin : Form
    {
        int advance = 0;
        //PLLay music
        WMPLib.WindowsMediaPlayer mplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer mplayer2 = new WMPLib.WindowsMediaPlayer();
        public YouWin()
        {
            InitializeComponent();
        }

        private void YouWin_Shown(object sender, EventArgs e)
        {

            this.CenterToScreen();
            //Advance
            Advance.Enabled = true;
          
            
            //Set music URL
            mplayer.URL = "E:\\TEJ3\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\Winmusic.mp3";
            mplayer2.URL = "C:\\ComputerTech\\Space Infiltrators\\Space Infiltrators\\Properties\\Winmusic.mp3";
            //mplayer2.URL = "F:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\Winmusic.mp3";
            mplayer.controls.play();
            mplayer2.controls.play();
        }

        private void Advance_Tick(object sender, EventArgs e)
        {
            //Advance text
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
                if (Infiltrators.score < 30000)
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
                    label6.Text = "Okay";
                }
                if (Infiltrators.score > 230000)
                {
                    label6.Text = "Acceptable";
                }
                if (Infiltrators.score > 300000)
                {
                    label6.Text = "Getting Good!";
                }
                if (Infiltrators.score > 350000)
                {
                    label6.Text = "Good!";
                }
                if (Infiltrators.score > 450000)
                {
                    label6.Text = "Great!";
                }
                if (Infiltrators.score > 500000)
                {
                    label6.Text = "Magnificent!";
                }
                if (Infiltrators.score > 550000)
                {
                    label6.Text = "Awesome Sauce!";
                }
                if (Infiltrators.score > 600000)
                {
                    label6.Text = "Super Professional";
                }
                if (Infiltrators.score > 650000)
                {
                    label6.Text = "Space Infiltrators Master";
                }
                if (Infiltrators.score > 800000)
                {
                    label6.Text = "Space Infiltrators GrandMaster";
                }
                if (Infiltrators.score > 900000)
                {
                    label6.Text = "Space Infiltrators GrandMaster";
                }
                label6.Visible = true;
            }
        }

        private void YouWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
