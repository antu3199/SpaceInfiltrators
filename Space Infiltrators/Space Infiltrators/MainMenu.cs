//Anthony Tu
//January 21, 2013
//Space Infiltators game
//This is the main menu. Starting screen. Includes a start game and an instructions button.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Space_Infiltrators
{
    public partial class MainMenu : Form
    {
        //Change forms
        Infiltrators frminfiltrators = new Infiltrators();
     PickStage frmpickstage = new PickStage();
     Instructions frminstructions = new Instructions();

      

    //Music stuff
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
       public static int musicvalue = 0; 
      
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
       
            //Center to screen
            this.CenterToScreen();
            //Set music URL
            wplayer.URL = "E:\\TEJ3\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
            wplayer2.URL = "C:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
           // wplayer2.URL = "F:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
           
                wplayer.controls.play();
                wplayer2.controls.play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //When clicked START, go to select stage
            this.Hide();
            frmpickstage.Show();
          
        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            //Repeat music over time
            if (PickStage.activestage == false)
            {
                musicvalue += 1;
            }
       
            //After a certain amount of time, repeat music
            if (musicvalue > 2250)
            {
                //Play music again
                musicvalue = 0;
                wplayer.controls.stop();
                wplayer.controls.play();

            }
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {

        }
    
        private void instructions_Click_1(object sender, EventArgs e)
        {
            //if instructinos are clicked, show instructions
            this.Hide();
            frminstructions.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If x is clicked, close application
            Application.Exit();
        }
 
    }
}
