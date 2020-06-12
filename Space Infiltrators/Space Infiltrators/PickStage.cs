//Anthony Tu
//January 21, 2013
//Space Infiltators game
//Pick the stage form. Stages don't have to be picked in order but I would strongly recommend it.

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
    public partial class PickStage : Form
    {
       public static bool activestage = false;
        Infiltrators frminfiltrators = new Infiltrators();
     
        public PickStage()
        {
            InitializeComponent();
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 1
            stage1();
        }
           private void Cube1_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 1
            stage1();
        }
    

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
           //Restart music after time
            if (MainMenu.musicvalue > 2250)
            {
                MainMenu.wplayer.URL = "E:\\TEJ3\\ComputerTech\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
               // MainMenu.wplayer2.URL = "D:\\ComputerTech\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
                MainMenu.wplayer2.URL = "C:\\ComputerTech\\Space Infiltrators\\Space Infiltrators\\Properties\\Menu.mp3";
                MainMenu.musicvalue = 0;
                MainMenu.wplayer.controls.stop();
                MainMenu.wplayer.controls.play();
                MainMenu.wplayer2.controls.stop();
                MainMenu.wplayer2.controls.play();

            }
        }

        private void PickStage_Shown(object sender, EventArgs e)
        {
            //Center form to screen
            this.CenterToScreen();
           
        }

     

        private void Cube2_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 2
            stage2();
        }

        private void bStage2_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 2
           stage2();
        }
        //Code to start stage 1:
        private void stage1()
        {
            //Start stage, set timer and play different music
            activestage = true;
            Infiltrators.wavenumber = 1;
            this.Hide();
            frminfiltrators.Show();
            MainMenu frmMainmenu = new MainMenu();
   
            frmMainmenu.MusicTimer.Enabled = false;
            MainMenu.wplayer.controls.stop();
            MainMenu.wplayer2.controls.stop();
            MainMenu.musicvalue = 0;
            MainMenu.wplayer.enabled = false;
        }
        //Code to start stage 2:
        private void stage2()
        {
            //Start stage, set timer and play different music
            activestage = true;
            Infiltrators.wavenumber = 11;
            this.Hide();
            frminfiltrators.Show();
            MainMenu frmMainmenu = new MainMenu();
            frmMainmenu.MusicTimer.Enabled = false;
            MainMenu.wplayer.controls.stop();
            MainMenu.wplayer2.controls.stop();
            MainMenu.musicvalue = 0;
            MainMenu.wplayer.enabled = false;
           
        }
        //Code to start stage 3:
        private void stage3()
        {
            //Start stage, set timer and play different music
            activestage = true;
            Infiltrators.wavenumber = 21;
            this.Hide();
            frminfiltrators.Show();
            MainMenu frmMainmenu = new MainMenu();
            frmMainmenu.MusicTimer.Enabled = false;
            MainMenu.wplayer.controls.stop();
            MainMenu.wplayer2.controls.stop();
            MainMenu.musicvalue = 0;
            MainMenu.wplayer.enabled = false;
           
        }

        private void bStage3_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 3
            stage3();
        }

        private void Cube3_Click(object sender, EventArgs e)
        {
            //When clicked, start stage 3
            stage3();
        }

        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PickStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Working back button
            MainMenu frmMainMenu = new MainMenu();
            this.Hide();
            frmMainMenu.Show();
        }

  
    }
}
