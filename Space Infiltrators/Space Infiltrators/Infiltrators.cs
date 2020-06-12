//Anthony Tu
//January 21, 2013
//Space Infiltators game
//This is the Main game code. User must defeat all waves of enemies as well as the boss to win

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

    public partial class Infiltrators : Form
    {
        Winner2 frmlose = new Winner2();
      
        System.Media.SoundPlayer ugethit = new System.Media.SoundPlayer();
        System.Media.SoundPlayer ubullethit = new System.Media.SoundPlayer();
        System.Media.SoundPlayer explosionsound = new System.Media.SoundPlayer();
        System.Media.SoundPlayer lasersound = new System.Media.SoundPlayer();

        int musicvalue = 0;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();

        //Randomize
        Random rnd = new Random();
       
        public static int score = 0;
        //User
        //Movement and Keypress variables
        int move = 0;
        bool left,right, zkey = false;

        //User Bullet Variables
        PictureBox[] userbullet = new PictureBox[2];
        int ubulletspeed = 15;
        bool[] ubulletact = new bool[5];
        bool ubulletdelay = true;

        //Lives and health
        int uhealth = 100;
        int ulives = 3;
        int udeadtime = 0;
        bool userinvincibility = false;

       //Bomb
        PictureBox PicBomb;
        bool bombact = false;
        int bombvalue = 0;
        bool bombexpand = true;
        bool utempbility = false;
        int utemptimer = 0;

        //Laser
        PictureBox PicLaser;
        int laservalue = 0;
        int laseract = 0;
        int lasertimer = 0;
        bool laserdodamage = true;
        int laserdamagelimit = 0;
        int laservaluedivider = 8;
      

        //Blast
        PictureBox PicBlast;
        int ublastact = 0;
        bool ublastdelay = false;
     

        // Enemy waves and enemy numbers
       public static int wavenumber = 1;
        int totalenemies = 5;
        int numberofnenemies = 10;
        int numberofpenemies = 0;
        int numberofsenemies = 0;
        int numberoftenemies = 0;

        bool[] normalenemy = new bool[10];
        bool[] powerenemy = new bool[6];
        bool[] speedenemy = new bool[6];
        bool[] tankenemy = new bool[6];


        //Enemys
        PictureBox[] picPEnemy = new PictureBox[6];
        PictureBox[] picNEnemy = new PictureBox[10];
        PictureBox[] picSEnemy = new PictureBox[6];
        PictureBox[] picTEnemy = new PictureBox[6];

        PictureBox[] ebulletn = new PictureBox[10];
        PictureBox[] ebulletp = new PictureBox[6];
        PictureBox[] ebullets = new PictureBox[6];
        PictureBox[] ebullett = new PictureBox[6];

        int[] enhealth = new int[10];
        int[] ephealth = new int[10];
        int[] eshealth = new int[10];
        int[] ethealth = new int[10];

        //Enemy Bullets
        int[] rndntimer = new int[10];
        int[] rndptimer = new int[10];
        int[] rndstimer = new int[10];
        int[] rndttimer = new int[10];

        bool[] ebulletnact = new bool[10];
        bool[] ebulletpact = new bool[10];
        bool[] ebulletsact = new bool[10];
        bool[] ebullettact = new bool[10];

        int[] etargetny = new int[10];
        int[] etargetpy = new int[10];
        int[] etargetsy = new int[10];
        int[] etargetty = new int[10];

        double[] ebulletnspeed = new double[10];
        double[] ebulletpspeed = new double[10];
        double[] ebulletsspeed = new double[10];
        double[] ebullettspeed = new double[10];

        int[] randebdelay = new int[10];

        //Dead Enemy
        bool[] deadnenemy = new bool[10];
        bool[] deadpenemy = new bool[10];
        bool[] deadsenemy = new bool[10];
        bool[] deadtenemy = new bool[10];

        //Boss Variables
        //Boss1
        PictureBox Boss1Enemy;
        PictureBox boss1bullet;
        int boss1health = 100;
        int boss1decidemove = 0;
        bool boss1doaction = true;
        int boss1leftorright = 0;
        bool deadboss1 = false;
        //Boss1bullet
        bool boss1bulletact = false;
        int boss1targety = 0;
        //Boss1 Glitch stoppers
        double boss1bulletspeed = 0;
        int boss1attackdelay = 0;
        int boss1nodoubles = 0;
         int boss1hitonce = 0;
        bool activateultiiflowhp = true;
      //Boss1 ultimate attack
        int boss1ultiact = 0;
        int boss1ultileftorright = 0;
        int bossexplosionvalue = 0;
        

        //Boss 2
        PictureBox Boss2Enemy;
        PictureBox boss2bullet;
        int boss2health = 100;
        int boss2randomspawn = 0;
        bool deadboss2 = false;
      //Boss2 Bullet
        bool boss2bulletact = false;
        double boss2bulletspeed = 0;
        int boss2targety = 0;
     
        //Boss2Spawning minion variables
        bool boss2e1 = false;
        bool boss2e2 = false;
        bool boss2e3 = false;
        bool boss2e4 = false;
        bool boss2p1, boss2s1, boss2t1 = false;
        bool boss2p2, boss2s2, boss2t2 = false;
        bool boss2p3, boss2s3, boss2t3 = false;
        bool boss2p4, boss2s4, boss2t4 = false;
        bool boss2spawnable = true;
        bool boss2useulti = true;
        bool boss2useulti2 = true;
        int boss2ultiact = 0;

        //Boss 3
        PictureBox Boss3Enemy;
        PictureBox boss3bullet;
        PictureBox boss3BulletExplosion;
        int boss3health = 125;
        int boss3leftorright = 1;
        int boss3decidemove = 1;
        int boss3decidemove2 = 1;
        bool boss3doaction = false;

        //Boss 3 bullet
        bool boss3bulletact = false;
        double boss3bulletspeed = 0;
        int boss3targety = 0;
        bool deadboss3 = false;
        //Boss3BulletExplosion
        int boss3bulletexpact = 0;
        int boss3bulletexpt = 0;
        bool boss3bulletexphit = false;

        //Boss3 Movement patterns
        bool boss3move = true;
        bool boss3p1 = true;
        bool boss3p2 = false;
        bool boss3p3 = true;
        bool boss3bnactivate = true;
        int boss3b2act = 0;
        int boss3b2timer = 0;

        //Boss3 bullet2
        PictureBox[] boss3bullet2 = new PictureBox[2];
        PictureBox[] boss3BulletExplosion2 = new PictureBox[2];
        bool[] boss3bulletact2 = new bool[2]; // false
        double[] boss3bulletspeed2 = new double [2]; 
        int[] boss3targety2 =  new int[2];
        int[] boss3bulletexpact2 =  new int [2];
        int[] boss3bulletexpt2 = new int[2];
        bool[] boss3bulletexphit2 = new bool[2]; // false

        //Boss3 bulletn
        PictureBox[] boss3bulletn = new PictureBox[2];
        bool[] boss3bulletactn = new bool[2];
        double[] boss3bulletspeedn = new double[2];
        int[] boss3targetyn = new int[2];
        int[] boss3bulletexpactn = new int[2];
        int[] boss3bulletexptn = new int[2];
        bool[] boss3bulletexphitn = new bool[2]; // false

        //Boss3 Huge Explosion
        int boss3Hexplosionact = 0;
        int boss3HEleftorright = 0;
        int boss3HEcount = 0;

        int countdead = 0;
      

        public Infiltrators()
        {
            InitializeComponent();
        }
        private void Infiltrators_Shown(object sender, EventArgs e)
        {
 
            #region Initialize

            this.CenterToScreen();
            totalenemies = numberofnenemies;
            MusicTimer.Enabled = true;
            //Enable Timers
            InvaderTimer.Enabled = false;
            ebulletdelay.Enabled = true;
            ebulletdelay2.Enabled = true;
            ebulletdelay3.Enabled = true;
            ubulletdelaytmr.Enabled = true;
            Universal.Enabled = true;
            picUser.Location = new Point(469, 503);
            //Score
            lblScore.Text = "SCORE: " + score;

            //Music and sound timer and set location
            MusicTimer.Enabled = true;
            wplayer.URL = "E:\\TEJ3\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SpaceMusic.mp3";
            wplayer2.URL = "C:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SpaceMusic.mp3";
            //wplayer2.URL = "F:\\AnthonyInfiltrators\\Space Infiltrators\\Space Infiltrators\\Properties\\SpaceMusic.mp3";

            ugethit.Stream = Properties.Resources.invaderkilled;
            ubullethit.Stream = Properties.Resources.shoot;
            explosionsound.Stream = Properties.Resources.explosion;
            lasersound.Stream = Properties.Resources.Lasersound;

            //Set Picture Blast
            PicBlast = new PictureBox();
            PicBlast.Size = new Size(10, 10);
            PicBlast.Image = Space_Infiltrators.Properties.Resources.ExplosionBallWithFlames;
            PicBlast.Location = new Point(picUser.Left - 25, picUser.Top);
            PicBlast.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBlast.BackColor = Color.Transparent;
            PicBlast.Visible = false;
            this.Controls.Add(PicBlast);

            //Set picture Bomb
            PicBombBar.Size = new Size(0, 20);
            PicBomb = new PictureBox();
            PicBomb.Size = new Size(20, 20);
            PicBomb.Image = Space_Infiltrators.Properties.Resources.ExplosionBall;
            PicBomb.Location = new Point(picUser.Left + 15, picUser.Bottom);
         PicBomb.SizeMode = PictureBoxSizeMode.StretchImage;
       PicBomb.BackColor = Color.Transparent;
       PicBomb.Visible = false;
       this.Controls.Add(PicBomb);

            //Set picture Laser
       PicLaserBar.Size = new Size(0, 20);
       PicLaser = new PictureBox();
       PicLaser.Size = new Size(200, 0);
       PicLaser.Location = new Point(picUser.Left - 65, picUser.Top);
       PicLaser.Image = Space_Infiltrators.Properties.Resources.ExplosionBall;
  
       PicLaser.SizeMode = PictureBoxSizeMode.StretchImage;
       PicLaser.BackColor = Color.Transparent;
       PicLaser.Visible = false;
       this.Controls.Add(PicLaser);


            //User bullet variables
            for (int i = 0; i <= 1; i++)
            {
                ubulletact[i] = true;
                userbullet[i] = new PictureBox();
                userbullet[i].Size = new Size(20, 20);
                userbullet[i].Image = Space_Infiltrators.Properties.Resources.qdR8p;
                userbullet[i].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                userbullet[i].SizeMode = PictureBoxSizeMode.Zoom;
                userbullet[i].BackColor = Color.Transparent;
                userbullet[i].Visible = false;
                this.Controls.Add(userbullet[i]);
            }

            //Set enemy variables
            #region NormalEnemy
            for (int i = 0; i <= 9; i++)
            {
                normalenemy[i] = true;
            
                enhealth[i] = 2;
                deadnenemy[i] = false;
                //Enemy PictureBox
                picNEnemy[i] = new PictureBox();
                picNEnemy[i].Visible = false;
                picNEnemy[i].Size = new Size(60, 60);
                picNEnemy[i].Image = Space_Infiltrators.Properties.Resources.NormalE;
                picNEnemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picNEnemy[i].BackColor = Color.Transparent;
                this.Controls.Add(picNEnemy[i]);
                //Bullet Picturebox
                ebulletn[i] = new PictureBox();
                ebulletn[i].Size = new Size(20, 20);
                ebulletn[i].Image = Space_Infiltrators.Properties.Resources.qdR8p;
                ebulletn[i].Location = new Point(picNEnemy[0].Location.X + 8, picNEnemy[0].Bottom);
                ebulletn[i].SizeMode = PictureBoxSizeMode.Zoom;
                ebulletn[i].BackColor = Color.Transparent;
                ebulletn[i].Visible = false;
                this.Controls.Add(ebulletn[i]);


            }

            #endregion

            #region PowerEnemy
            for (int i = 0; i <= 5; i++)
            {
                powerenemy[i] = true;

                ephealth[i] = 3;
                deadpenemy[i] = false;
                //Enemy PictureBox
                picPEnemy[i] = new PictureBox();
                picPEnemy[i].Visible = false;
                picPEnemy[i].Size = new Size(60, 60);
                picPEnemy[i].Image = Space_Infiltrators.Properties.Resources.PEnemy;
                picPEnemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picPEnemy[i].BackColor = Color.Transparent;
                this.Controls.Add(picPEnemy[i]);
                //Bullet Picturebox
                ebulletp[i] = new PictureBox();
                ebulletp[i].Size = new Size(50, 50);
                ebulletp[i].Image = Space_Infiltrators.Properties.Resources.PBullet;
                ebulletp[i].Location = new Point(picNEnemy[0].Location.X + 8, picNEnemy[0].Bottom);
                ebulletp[i].SizeMode = PictureBoxSizeMode.Zoom;
                ebulletp[i].BackColor = Color.Transparent;
                ebulletp[i].Visible = false;
                this.Controls.Add(ebulletp[i]);
            }
            #endregion
            #region SpeedEnemy
            for (int i = 0; i <= 5; i++)
            {
                speedenemy[i] = true;
                eshealth[i] = 3;
                deadsenemy[i] = false;

                //Enemy PictureBox
                picSEnemy[i] = new PictureBox();
                picSEnemy[i].Visible = false;
                picSEnemy[i].Size = new Size(60, 60);
                picSEnemy[i].Image = Space_Infiltrators.Properties.Resources.SEnemy;

                picSEnemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picSEnemy[i].BackColor = Color.Transparent;
                this.Controls.Add(picSEnemy[i]);
                //Bullet Picturebox
                ebullets[i] = new PictureBox();
                ebullets[i].Size = new Size(20, 20);
                ebullets[i].Image = Space_Infiltrators.Properties.Resources.qdR8p;
                ebullets[i].Location = new Point(picSEnemy[0].Location.X + 8, picSEnemy[0].Bottom);
                ebullets[i].SizeMode = PictureBoxSizeMode.Zoom;
                ebullets[i].BackColor = Color.Transparent;
                ebullets[i].Visible = false;
                this.Controls.Add(ebullets[i]);


            }
            #endregion

            #region TankEnemy

            for (int i = 0; i <= 5; i++)
            {

                tankenemy[i] = true;
                ethealth[i] = 7;
                deadtenemy[i] = false;
                //Enemy PictureBox
                picTEnemy[i] = new PictureBox();
                picTEnemy[i].Visible = false;
                picTEnemy[i].Size = new Size(100, 100);
                picTEnemy[i].Image = Space_Infiltrators.Properties.Resources.TEnemy;
                picTEnemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picTEnemy[i].BackColor = Color.Transparent;
                this.Controls.Add(picTEnemy[i]);
                //Bullet picturebox
                ebullett[i] = new PictureBox();
                ebullett[i].Size = new Size(20, 20);
                ebullett[i].Image = Space_Infiltrators.Properties.Resources.qdR8p;
                ebullett[i].Location = new Point(picSEnemy[0].Location.X + 8, picSEnemy[0].Bottom);
                ebullett[i].SizeMode = PictureBoxSizeMode.Zoom;
                ebullett[i].BackColor = Color.Transparent;
                ebullett[i].Visible = false;
                this.Controls.Add(ebullett[i]);


            }
            #endregion

            #endregion

            #region Boss1Variables
            //Enemy PictureBox
            Boss1Enemy = new PictureBox();
            Boss1Enemy.Visible = false;
            Boss1Enemy.Size = new Size(190, 190);
            Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.boss1;
            Boss1Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Boss1Enemy.BackColor = Color.Transparent;
            this.Controls.Add(Boss1Enemy);
            //Bullet PictureBox
            boss1bullet = new PictureBox();
            boss1bullet.Size = new Size(50, 50);
            boss1bullet.Image = Space_Infiltrators.Properties.Resources.PBullet;
            boss1bullet.Location = new Point(Boss1Enemy.Location.X + 70, Boss1Enemy.Location.Y);
            boss1bullet.SizeMode = PictureBoxSizeMode.Zoom;
            boss1bullet.BackColor = Color.Transparent;
            boss1bullet.Visible = false;
            this.Controls.Add(boss1bullet);
            Boss1Enemy.Location = new Point(410, -200);
            boss1bullet.Location = new Point(Boss1Enemy.Location.X + 70, Boss1Enemy.Bottom - 30);
            #endregion
            #region Boss2Variables
            //Enemy PictureBox
            Boss2Enemy = new PictureBox();
            Boss2Enemy.Visible = false;
            Boss2Enemy.Size = new Size(235, 180);
            Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.boss2;
            Boss2Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Boss2Enemy.BackColor = Color.Transparent;
            this.Controls.Add(Boss2Enemy);
            //Bullet picturebox
            boss2bullet = new PictureBox();
            boss2bullet.Size = new Size(50, 50);
            boss2bullet.Image = Space_Infiltrators.Properties.Resources.qdR8p;
            boss2bullet.Location = new Point(Boss2Enemy.Location.X + 115, Boss2Enemy.Location.Y);
            boss2bullet.SizeMode = PictureBoxSizeMode.Zoom;
            boss2bullet.BackColor = Color.Transparent;
            boss2bullet.Visible = false;


            this.Controls.Add(boss2bullet);

            Boss2Enemy.Location = new Point(395, -200);


            boss2bullet.Location = new Point(Boss2Enemy.Location.X + 115, Boss2Enemy.Location.Y);
            #endregion
            #region Boss3Variables
            //Enemy PictureBox
            Boss3Enemy = new PictureBox();
            Boss3Enemy.Visible = false;
            Boss3Enemy.Size = new Size(170, 210);
            Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.boss3;
            Boss3Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Boss3Enemy.BackColor = Color.Transparent;
            this.Controls.Add(Boss3Enemy);
            //Bullet Picturebox
            boss3bullet = new PictureBox();
            boss3bullet.Size = new Size(50, 50);
            boss3bullet.Image = Space_Infiltrators.Properties.Resources.boss3bullet;
            boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Location.Y);
            boss3bullet.SizeMode = PictureBoxSizeMode.Zoom;
            boss3bullet.BackColor = Color.Transparent;
            boss3bullet.Visible = false;
            this.Controls.Add(boss3bullet);
            //Bullet explosion picturebox
            boss3BulletExplosion = new PictureBox();
            boss3BulletExplosion.Size = new Size(195, 170);
            boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion1;
            boss3BulletExplosion.Location = new Point(boss3bullet.Location.X - 70, boss3bullet.Location.Y - 55);
            boss3BulletExplosion.SizeMode = PictureBoxSizeMode.StretchImage;
            boss3BulletExplosion.BackColor = Color.Transparent;
            boss3BulletExplosion.Visible = false;
            this.Controls.Add(boss3BulletExplosion);
            //Other Bullet pictureboxes
            for (int i = 0; i <= 1; i++)
            {
                boss3bulletn[i] = new PictureBox();
                boss3bulletn[i].Size = new Size(20, 20);
                boss3bulletn[i].Image = Space_Infiltrators.Properties.Resources.qdR8p;
                boss3bulletn[i].Location = new Point(Boss3Enemy.Location.X + 75, Boss3Enemy.Bottom);
                boss3bulletn[i].SizeMode = PictureBoxSizeMode.Zoom;
                boss3bulletn[i].BackColor = Color.Transparent;
                boss3bulletn[i].Visible = false;
                this.Controls.Add(boss3bulletn[i]);
                boss3bulletactn[i] = false;
            }
            //Double bomb bullet picturebox
            for (int i = 0; i <= 1; i++)
            {
                boss3bullet2[i] = new PictureBox();
                boss3bullet2[i].Size = new Size(50, 50);
                boss3bullet2[i].Image = Space_Infiltrators.Properties.Resources.boss3bullet;
                boss3bullet2[i].Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Location.Y);
                boss3bullet2[i].SizeMode = PictureBoxSizeMode.Zoom;
                boss3bullet2[i].BackColor = Color.Transparent;
                boss3bullet2[i].Visible = false;
                this.Controls.Add(boss3bullet2[i]);

                boss3BulletExplosion2[i] = new PictureBox();
                boss3BulletExplosion2[i].Size = new Size(195, 170);
                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion1;
                boss3BulletExplosion2[i].Location = new Point(boss3bullet.Location.X - 70, boss3bullet.Location.Y - 55);
                boss3BulletExplosion2[i].SizeMode = PictureBoxSizeMode.StretchImage;
                boss3BulletExplosion2[i].BackColor = Color.Transparent;
                boss3BulletExplosion2[i].Visible = false;
                this.Controls.Add(boss3BulletExplosion2[i]);


                boss3bulletact2[i] = false;
                boss3bulletexphit2[i] = false;
            }
            Boss3Enemy.Location = new Point(410, -200);
            boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Location.Y);
#endregion
            #region SendWarningsToBack
            //Makes sure that all warnings are Behind everything else
            Warning1.SendToBack();
            Warning2.SendToBack();
            Warning3.SendToBack();
            Warning4.SendToBack();
            Warning5.SendToBack();
            Warning6.SendToBack();
            Warning7.SendToBack();
            Warning8.SendToBack();
            #endregion

           //  countdead = 11;
          // wavenumber = 25;
           // checknewwave();

            checknewwave();

        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            #region BulletPress
            //Activate bullet on Z press
            if (e.KeyCode == Keys.Z && ubulletact[0] == true || e.KeyCode == Keys.Z && ubulletact[1] == true)
            {
                //Activate bullet (zkey stops too many keypresses at once)
                zkey = true;
            }

            if (zkey == true && ubulletact[0] == true && ubulletdelay == false && uhealth != 0)
            {
                //Reset bullet location
                userbullet[0].Location = new Point(picUser.Location.X + ((picUser.Right - picUser.Left) / 2 - 10), picUser.Top - 25);
                //Enabled bullet timer
                ubullettmr.Enabled = true;
                //Bullet visible
                userbullet[0].Visible = true;
                //Unable to activate another bullet 1
                ubulletact[0] = false;
                //Restart bullet delay
                ubulletdelay = true;
                ubulletdelaytmr.Stop();
                ubulletdelaytmr.Start();

                ubulletdelaytmr.Enabled = true;
            }

            if (zkey == true && ubulletact[1] == true && ubulletdelay == false && uhealth != 0 && uhealth != 0)
            {
                //Reset bullet location
                userbullet[1].Location = new Point(picUser.Location.X + ((picUser.Right - picUser.Left) / 2 - 10), picUser.Top - 25);
                //Bullet visible
                userbullet[1].Visible = true;
                //Unable to activate another bullet 2
                ubulletact[1] = false;
                //Enabled bullet timer
                ubullettmr2.Enabled = true;
                //Restart bullet delay
                ubulletdelay = true;
                ubulletdelaytmr.Stop();
                ubulletdelaytmr.Start();


            }
            #endregion

            #region MoveLeftRight
            //Move 1 is left, Move 2 is Right when it is pressed once, 
            //move is changed to 3 or 4 to lower latency problems by only changing
            //the image once
            if (e.KeyCode == Keys.Left && move != 3 && udeadtime == 0)
            {
                //Move Left
                move = 1;
            }

            else if (e.KeyCode == Keys.Right && move != 4 && udeadtime == 0)
            {
                //Move Right
                move = 2;
            }

            if (move == 1 && udeadtime == 0)
            {
                //Avoid latency problems
                move = 3;
                //Set to Move left
                left = true;
                //Set to Not move right
                right = false;
                //Change image to Moving Left
                picUser.Image = null;
                picUser.Image = Space_Infiltrators.Properties.Resources.BattlecruiserLeft;
                //Enabled moving timer to move the actual image
                movet.Enabled = true;

            }
            else if (move == 2 && udeadtime == 0)
            {   
                //Avoid latency problems
                move = 4;
                //Change image to Moving Right
                picUser.Image = null;
                picUser.Image = Space_Infiltrators.Properties.Resources.BattlecruiserRight;
                //Set to Move right
                right = true;
                //Set to not Move left
                left = false;

                movet.Enabled = true;
            }
            #endregion

            #region BombPress
            if (e.KeyCode == Keys.Space && bombact == false && PicBombBar.Size.Width >= 766 && uhealth != 0 && laseract == 0)
            {
                //Set Bomb location
                PicBomb.Location = new Point(picUser.Left + 15, picUser.Bottom);
                //Expand the bomb
                bombexpand = true;
                //Activate Bomb timer
                uBombTimer.Enabled = true;
                //Activate bomb
                bombact = true;
                //Reduce bomb bar to 0
                bombvalue = 0;
                //Play explosion sound
                explosionsound.Play();
            }
            #endregion

            #region BlastPress
            if (e.KeyCode == Keys.X && ublastact == 0 && ublastdelay == false && uhealth != 0)
            {
                //Send blast to back to avoid layering problems
                PicBlast.SendToBack();
                userbullet[0].SendToBack();
                userbullet[1].SendToBack();
                //Activate delay
                ublastdelay = true;
                //Activate the blast
                ublastact = 1;
                //Enabled blast timer
                ublasttmr.Enabled = true;
                //Reset Blast location and size
                PicBlast.Size = new Size(10, 10);
                PicBlast.Location = new Point(picUser.Left + 25, picUser.Top+25);
                //Make it Visible
                PicBlast.Visible = true;
                //Start blast delay timer
                uBlastDelaytmr.Enabled = true;
                //Reset Blast timer
                uBlastDelaytmr.Stop();
                uBlastDelaytmr.Start();

            }
            #endregion

            #region LaserPress
            if (e.KeyCode == Keys.C && laseract == 0 && PicLaserBar.Size.Width >= 766 && uhealth != 0 && bombact == false)
            {
              // Reset the laser location
                PicLaser.Location = new Point(picUser.Left - 65, picUser.Top);
                //Laser visible
                PicLaser.Visible = true;
                //Activate Laser
                laseract = 1;
                //Reset laser values
                laservalue = 0;
                lasertimer = 0;
                //Enable laser timers
                LaserDelay.Enabled = true;
                uLaserTimer.Enabled = true;
                //Play laser sounds
                lasersound.Play();

            }
            #endregion
        }

        private void movet_Tick(object sender, EventArgs e)
        {
            #region MoveLeftRight
            //Move Right
            if (right == true && picUser.Right < 980)
            {
                picUser.Location = new Point(picUser.Location.X + 10, picUser.Location.Y);
                //Blast follows if active
                if (ublastact == 1)
                {
                    PicBlast.Location = new Point(PicBlast.Location.X + 10, PicBlast.Location.Y);
                }
            }
                //Move left
            else if (left == true && picUser.Left > 0)
            {
                picUser.Location = new Point(picUser.Location.X - 10, picUser.Location.Y);
                //Blast follows if active
                if (ublastact == 1)
                {
                    PicBlast.Location = new Point(PicBlast.Location.X - 10, PicBlast.Location.Y);
                }
            }
            #endregion

        }
        //User Bullet timer

        private void ubullettmr_Tick_1(object sender, EventArgs e)
        {
            //Collision detection
            ucollision();
            //Set bullet initial location
            userbullet[0].Location = new Point(userbullet[0].Location.X, userbullet[0].Location.Y - ubulletspeed);

        }
        private void ubullettmr2_Tick(object sender, EventArgs e)
        {
            //Collision detection
            ucollision();
            //Set bullet initial location
            userbullet[1].Location = new Point(userbullet[1].Location.X, userbullet[1].Location.Y - ubulletspeed);

        }

        private void ubulletdelaytmr_Tick(object sender, EventArgs e)
        {
            //Allow bullet to be shot
            ubulletdelay = false;
        }

        //BULLET TO ENEMY COLLISION
        private void ucollision()
        {
            #region BulletToNEnemyCollision
            //Bullet to End of screen
            if (userbullet[0].Bottom < 0)
            {
                ubulletact[0] = true;
                ubullettmr.Enabled = false;

            }
            //Bullet 2 to End of screen
            if (userbullet[1].Bottom < 0)
            {
                ubulletact[1] = true;
                ubullettmr2.Enabled = false;

            }

            //Bullet1 to Normal enemy
            for (int i = 0; i <= numberofnenemies - 1; i++)
            {
                //If Enemy is not already dead
                if (deadnenemy[i] == false)
                {
                    //Collision
                    if (userbullet[0].Top < picNEnemy[i].Bottom && userbullet[0].Bottom > picNEnemy[i].Top && userbullet[0].Right > picNEnemy[i].Left && userbullet[0].Left < picNEnemy[i].Right && normalenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower health
                        enhealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }
                    //Bullet2 to Normal enemy
                    if (userbullet[1].Top < picNEnemy[i].Bottom && userbullet[1].Bottom > picNEnemy[i].Top && userbullet[1].Right > picNEnemy[i].Left && userbullet[1].Left < picNEnemy[i].Right && normalenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower health
                        enhealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }

                    //If bullet damage results in death
                    if (enhealth[i] <= 0)
                    {
                        //Disable enemy
                        picNEnemy[i].Visible = false;
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, -35);
                        normalenemy[i] = false;
                        deadnenemy[i] = true;
                        //Increase score
                        score += 1000;
                        lblScore.Text = "SCORE: " + score;
                        //Counts number of dead enemies
                        countdead += 1;
                        //Check new wave
                        checknewwave();
                        //Boss 2 Respawn enemy
                        if (wavenumber == 16)
                        {
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                        }
                    }
                }
            }
            #endregion

            #region BulletToPEnemyCollision

            //POWER
            //Bullet 1 Collision
            for (int i = 0; i <= numberofpenemies - 1; i++)
            {
                //If enemy is not already dead
                if (deadpenemy[i] == false)
                {
                    //Collsion detect
                    if (userbullet[0].Top < picPEnemy[i].Bottom && userbullet[0].Bottom > picPEnemy[i].Top && userbullet[0].Right > picPEnemy[i].Left && userbullet[0].Left < picPEnemy[i].Right && powerenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower health
                        ephealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }
                    //Bullet2 to enemy
                    if (userbullet[1].Top < picPEnemy[i].Bottom && userbullet[1].Bottom > picPEnemy[i].Top && userbullet[1].Right > picPEnemy[i].Left && userbullet[1].Left < picPEnemy[i].Right && powerenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower health
                        ephealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound
                        ubullethit.Play();
                    }

                    //If damage results in death
                    if (ephealth[i] <= 0)
                    {
                        //Disable Enemy
                        picPEnemy[i].Visible = false;
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, -35);
                        powerenemy[i] = false;
                        deadpenemy[i] = true;

                        //Increase score
                        score += 3000;
                        lblScore.Text = "SCORE: " + score;
                        //Counts number of dead enemies
                        countdead += 1;

                       //Check for new wave
                        checknewwave();

                        #region Boss2StuffP
                        //Allows for enemy to respawn
                        //Spawning position # 1
                        if (wavenumber == 16 && boss2p1 == true && i == 0)
                        {
                            //Reset Spawning timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e1 = false;
                            boss2p1 = false;
                        }
                        //Spawning position # 2
                        if (wavenumber == 16 && boss2p2 == true && i == 1)
                        {
                            //Reset Spawning timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e2 = false;
                            boss2p2 = false;
                        }
                        //Spawning position # 3
                        if (wavenumber == 16 && boss2p3 == true && i == 2)
                        {
                            //Reset Spawning timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e3 = false;
                            boss2p3 = false;
                        }
                        //Spawning position # 4
                        if (wavenumber == 16 && boss2p4 == true && i == 3)
                        {
                            //Reset Spawning timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e4 = false;
                            boss2p4 = false;


                        }
                        #endregion

                    }

                }
            }
            #endregion
            #region BulletToSEnemyCollision
           
            for (int i = 0; i <= numberofsenemies - 1; i++)
            {
                //If enemy is not already dead
                if (deadsenemy[i] == false)
                {
                    //Bullet1 Collision
                    if (userbullet[0].Top < picSEnemy[i].Bottom && userbullet[0].Bottom > picSEnemy[i].Top && userbullet[0].Right > picSEnemy[i].Left && userbullet[0].Left < picSEnemy[i].Right && speedenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Decrease health
                        eshealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }
                    //Bullet2 to enemy 
                    if (userbullet[1].Top < picSEnemy[i].Bottom && userbullet[1].Bottom > picSEnemy[i].Top && userbullet[1].Right > picSEnemy[i].Left && userbullet[1].Left < picSEnemy[i].Right && speedenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower health
                        eshealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }

                    //If damage results in death
                    if (eshealth[i] <= 0)
                    {
                        //Disable enemy
                        picSEnemy[i].Visible = false;
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, -35);
                        speedenemy[i] = false;
                        deadsenemy[i] = true;
                        //Increase score
                        score += 3000;
                        lblScore.Text = "SCORE: " + score;
                        //Counts number of dead enemies
                        countdead += 1;
                        //Check for new wave
                        checknewwave();


                        #region Boss2StuffS
                        //Respawns enemies
                        //Respawn enemy 1
                        if (wavenumber == 16 && boss2s1 == true && i == 0)
                        {
                            //Reset timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e1 = false;
                            boss2s1 = false;
                        }
                        //Respawn enemy 2
                        if (wavenumber == 16 && boss2s2 == true && i == 1)
                        {
                            //Reset timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e2 = false;
                            boss2s2 = false;
                        }
                        //Respawn enemy 3
                        if (wavenumber == 16 && boss2s3 == true && i == 2)
                        {
                            //Reset timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e3 = false;
                            boss2s3 = false;
                        }
                        //Respawn enemy 4
                        if (wavenumber == 16 && boss2s4 == true && i == 3)
                        {
                            //Reset timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e4 = false;
                            boss2s4 = false;


                        }
                        #endregion


                    }

                }
            }
            #endregion
            #region BulletToTEnemyCollision

            for (int i = 0; i <= numberoftenemies - 1; i++)
            {
                //If enemy is not already dead
                if (deadtenemy[i] == false)
                {
                    //Enemy to bullet 1
                    if (userbullet[0].Top < picTEnemy[i].Bottom && userbullet[0].Bottom > picTEnemy[i].Top && userbullet[0].Right > picTEnemy[i].Left && userbullet[0].Left < picTEnemy[i].Right && tankenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower health
                        ethealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }
                    //Enemy to bullet 2
                    if (userbullet[1].Top < picTEnemy[i].Bottom && userbullet[1].Bottom > picTEnemy[i].Top && userbullet[1].Right > picTEnemy[i].Left && userbullet[1].Left < picTEnemy[i].Right && tankenemy[i] == true)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower health
                        ethealth[i] -= 1;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }

                    //If damage results enemy in death
                    if (ethealth[i] <= 0)
                    {
                        //Disable enemy
                        picTEnemy[i].Visible = false;
                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, -35);
                        tankenemy[i] = false;
                        deadtenemy[i] = true;
                        //Increase score
                        score += 7000;
                        lblScore.Text = "SCORE: " + score;
                        //Count number of dead enemiees
                        countdead += 1;
                        //Check for new wave
                        checknewwave();

                        #region Boss2StuffT
                        //Respawn Enemies
                        //Respawn location 1
                        if (wavenumber == 16 && boss2t1 == true && i == 0)
                        {
                            //Restart timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e1 = false;
                            boss2t1 = false;
                        }
                        //Respawn location 2
                        if (wavenumber == 16 && boss2t2 == true && i == 1)
                        {
                            //Restart timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e2 = false;
                            boss2t2 = false;

                        }
                        //Respawn location 3
                        if (wavenumber == 16 && boss2t3 == true && i == 2)
                        {
                            //Restart timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e3 = false;
                            boss2t3 = false;
                        }
                        //Respawn location 4
                        if (wavenumber == 16 && boss2t4 == true && i == 3)
                        {
                            //Restart timer
                            Boss2eSpawn.Stop();
                            Boss2eSpawn.Start();
                            boss2e4 = false;
                            boss2t4 = false;
                        }
                        #endregion
                    }

                }
            }
            #endregion

            #region BulletToBoss1Collision

            if (wavenumber == 7)
            {
                //If boss is not already dead
                if (deadboss1 == false)
                {
                    //Bullet 1 collision
                    if (userbullet[0].Top < Boss1Enemy.Bottom && userbullet[0].Bottom > Boss1Enemy.Top && userbullet[0].Right > Boss1Enemy.Left && userbullet[0].Left < Boss1Enemy.Right)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower boss1 health
                        boss1health -= 1;
                        if (boss1health <= 0)
                        {
                            boss1health = 0;
                        }
                        BossHP.Value = boss1health;
                        //Increase laser value
                        laservalue += 75;
                        // Play sound
                        ubullethit.Play();

                    }
                    //Bullet2 to enemy
                    if (userbullet[1].Top < Boss1Enemy.Bottom && userbullet[1].Bottom > Boss1Enemy.Top && userbullet[1].Right > Boss1Enemy.Left && userbullet[1].Left < Boss1Enemy.Right)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower boss1 health
                        boss1health -= 1;
                        if (boss1health <= 0)
                        {
                            boss1health = 0;
                        }
                        BossHP.Value = boss1health;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }
                }
                //If damage results in death of boss1
                if (boss1health <= 0 && deadboss1 == false)
                {
                    //Increase score
                    score += 75000;
                    lblScore.Text = "SCORE: " + score;
                    //Set boss1 as dead
                    deadboss1 = true;
                }

            }
            #endregion

            #region BulletToBoss2Collision

            if (wavenumber == 16)
            {
                //If deadboss2 is not already dead
                if (deadboss2 == false)
                {
                    //Bullet1 collision
                    if (userbullet[0].Top < Boss2Enemy.Bottom && userbullet[0].Bottom > Boss2Enemy.Top && userbullet[0].Right > Boss2Enemy.Left && userbullet[0].Left < Boss2Enemy.Right)
                    {
                        //Resets bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower boss2 health
                        boss2health -= 1;
                        if (boss2health <= 0)
                        {
                            boss2health = 0;
                        }
                        BossHP.Value = boss2health;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }
                    //Bullet 2 collision
                    if (userbullet[1].Top < Boss2Enemy.Bottom && userbullet[1].Bottom > Boss2Enemy.Top && userbullet[1].Right > Boss2Enemy.Left && userbullet[1].Left < Boss2Enemy.Right)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower boss2 health
                        boss2health -= 1;
                        if (boss2health <= 0)
                        {
                            boss2health = 0;
                        }
                        BossHP.Value = boss2health;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }
                }
                //If damage results in death of boss2
                if (boss2health <= 0 && deadboss2 == false)
                {
                    //Increase score
                    score += 100000;
                    lblScore.Text = "SCORE: " + score;
                    //Set boss2 as dead
                    deadboss2 = true;
                }

            }
            #endregion

            #region BulletToBoss3Collision

            if (wavenumber == 26)
            {
                //If boss3 is not already dead
                if (deadboss3 == false)
                {
                    //Bullet 1 collision
                    if (userbullet[0].Top < Boss3Enemy.Bottom && userbullet[0].Bottom > Boss3Enemy.Top && userbullet[0].Right > Boss3Enemy.Left && userbullet[0].Left < Boss3Enemy.Right)
                    {
                        //Reset bullet
                        userbullet[0].Visible = false;
                        userbullet[0].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[0] = true;
                        ubullettmr.Enabled = false;
                        //Lower boss3 health
                        boss3health -= 1;
                        if (boss3health <= 0)
                        {
                            boss3health = 0;
                        }
                        BossHP.Value = boss3health;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();
                    }
                    //Bullet2 collision
                    if (userbullet[1].Top < Boss3Enemy.Bottom && userbullet[1].Bottom > Boss3Enemy.Top && userbullet[1].Right > Boss3Enemy.Left && userbullet[1].Left < Boss3Enemy.Right)
                    {
                        //Reset bullet
                        userbullet[1].Visible = false;
                        userbullet[1].Location = new Point(picUser.Location.X + 15, picUser.Top - 25);
                        ubulletact[1] = true;
                        ubullettmr2.Enabled = false;
                        //Lower boss3 health
                        boss3health -= 1;
                        if (boss3health <= 0)
                        {
                            boss3health = 0;
                        }
                        BossHP.Value = boss3health;
                        //Increase laser value
                        laservalue += 75;
                        //Play sound effect
                        ubullethit.Play();

                    }
                }
                //If damage results in death of boss3
                if (boss3health <= 0 && deadboss3 == false)
                {
                    //Increase score
                    score += 150000;
                    lblScore.Text = "SCORE: " + score;
                    //Set boss3 as dead
                    deadboss3 = true;
                }

            }
            #endregion

        }

        private void uBlastDelaytmr_Tick(object sender, EventArgs e)
        {
            //Allow for a blast after a set time
            ublastdelay = false;
        }

        private void ublasttmr_Tick(object sender, EventArgs e)
        {
           //When blast is activated
            #region BlastCode
            if (ublastact == 1)
            {
                //Charge the blast
                if (PicBlast.Size.Height < 95)
                {
                    PicBlast.Size = new Size(PicBlast.Size.Width + 2, PicBlast.Size.Height + 2);
                    PicBlast.Location = new Point(PicBlast.Location.X - 1, PicBlast.Location.Y - 2);
                }
                else
                {
                    //After a certain point, blast is released
                    ublastact = 2;
                }
            }
            //When the blast is released
            if (ublastact == 2)
            {
                //Blast goes up
                PicBlast.Location = new Point(PicBlast.Location.X, PicBlast.Location.Y - 25);
                //Blast collision to enemies

                #region BlastToNormalEnemy
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadnenemy[i] == false)
                    {
                        //Collision
                        if (PicBlast.Top < picNEnemy[i].Bottom && PicBlast.Bottom > picNEnemy[i].Top && PicBlast.Right > picNEnemy[i].Left && PicBlast.Left < picNEnemy[i].Right && normalenemy[i] == true)
                        {
                            //Blast and blast timer resets
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Enemy Health is lowered 
                            enhealth[i] -= 2;
                            //Gain Laser bar value
                            laservalue += 100;
                            //Play sound effect
                            ubullethit.Play();
                        }
                        //If the blast results in the death of enemy 
                        if (enhealth[i] <= 0)
                        {
                            //Disable enemy
                            picNEnemy[i].Visible = false;
                            picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, -35);
                            normalenemy[i] = false;
                            deadnenemy[i] = true;
                            //Raise score
                            score += 1000;
                            lblScore.Text = "SCORE: " + score;
                            //Counts number of dead enemies
                            countdead += 1;
                            //Checks new wave
                            checknewwave();
                        }
                    }
                }
                #endregion
                #region BlastToPowerEnemy
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                   // If enemy is not already dead
                    if (deadpenemy[i] == false)
                    {
                        //Collision
                        if (PicBlast.Top < picPEnemy[i].Bottom && PicBlast.Bottom > picPEnemy[i].Top && PicBlast.Right > picPEnemy[i].Left && PicBlast.Left < picPEnemy[i].Right && powerenemy[i] == true)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Lower enemy health
                            ephealth[i] -= 2;
                     //Add laser bar value
                            laservalue += 100;
                            //Play sound effect
                            ubullethit.Play();
                        }

                        //If collision causes death of enemy
                        if (ephealth[i] <= 0)
                        {
                            //Disable enemy
                            picPEnemy[i].Visible = false;
                            picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, -35);
                            powerenemy[i] = false;
                            deadpenemy[i] = true;
                            //Raise score
                            score += 3000;
                            lblScore.Text = "SCORE: " + score;
                            //Count number of dead enemies
                            countdead += 1;
                         //Chech new wave
                            checknewwave();
                            #region Boss2StuffP
                            //Allows for another Enemy to spawn
                            //Spawning position 1
                            if (wavenumber == 16 && boss2p1 == true && i == 0)
                            {
                                //Reset spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2p1 = false;
                            }
                            //Spawning position 2
                            if (wavenumber == 16 && boss2p2 == true && i == 1)
                            {
                                //Reset spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2p2 = false;
                            }
                            //Spawning position 3
                            if (wavenumber == 16 && boss2p3 == true && i == 2)
                            {
                                //Reset spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2p3 = false;
                            }
                            //Spawning position 4
                            if (wavenumber == 16 && boss2p4 == true && i == 3)
                            {
                                //Reset spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2p4 = false;
                            }
                            #endregion

                        }
                    }
                }
                #endregion
                #region BlastToSpeedEnemy
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadsenemy[i] == false)
                    {
                        //Collision
                        if (PicBlast.Top < picSEnemy[i].Bottom && PicBlast.Bottom > picSEnemy[i].Top && PicBlast.Right > picSEnemy[i].Left && PicBlast.Left < picSEnemy[i].Right && speedenemy[i] == true)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Lower health
                            eshealth[i] -= 2;
                      //Add laser value
                            laservalue += 100;
                            //Play sound effect
                            ubullethit.Play();
                        }
                        //If damage results in death of enemy
                        if (eshealth[i] <= 0)
                        {
                            //Disable enemy
                            picSEnemy[i].Visible = false;
                            picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, -35);
                            speedenemy[i] = false;
                            deadsenemy[i] = true;
                            //Increase score
                            score += 3000;
                            lblScore.Text = "SCORE: " + score;
                            //Counts number of dead enemies
                            countdead += 1;

                            checknewwave();
                            #region Boss2StuffS
                            //Allows for another Enemy to spawn
                            //Spawning position 1
                            if (wavenumber == 16 && boss2s1 == true && i == 0)
                            {
                                //Restart Spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2s1 = false;
                            }
                            //Spawning position 2
                            if (wavenumber == 16 && boss2s2 == true && i == 1)
                            {
                                //Restart Spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2s2 = false;
                            }
                            //Spawning position 3
                            if (wavenumber == 16 && boss2s3 == true && i == 2)
                            {
                                //Restart Spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2s3 = false;



                            }
                            //Spawning position 4
                            if (wavenumber == 16 && boss2s4 == true && i == 3)
                            {
                                //Restart Spawning delay
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2s4 = false;
                            }
                            #endregion

                        }
                    }
                }
                #endregion
                #region BlastToTankEnemy
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadtenemy[i] == false)
                    {
                        //Collision
                        if (PicBlast.Top < picTEnemy[i].Bottom && PicBlast.Bottom > picTEnemy[i].Top && PicBlast.Right > picTEnemy[i].Left && PicBlast.Left < picTEnemy[i].Right && tankenemy[i] == true)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Lower health
                            ethealth[i] -= 2;
                            //Increase Laser value
                            laservalue += 100;
                            //Play sound effect
                            ubullethit.Play();
                        }
                        //If damage results enemy in death
                        if (ethealth[i] <= 0)
                        {
                            //Disable enemy
                            picTEnemy[i].Visible = false;
                            picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, -35);
                            tankenemy[i] = false;
                            deadtenemy[i] = true;
                            //Score increase
                            score += 7000;
                            lblScore.Text = "SCORE: " + score;
                            //Counts number of dead enemies
                            countdead += 1;
                            //Check new wave

                            checknewwave();
                            #region Boss2StuffT
                            //Allows for another Enemy to spawn
                            //Spawning position 1
                            if (wavenumber == 16 && boss2t1 == true && i == 0)
                            {
                                //Restarts spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2t1 = false;
                            }
                            //Spawning position 2
                            if (wavenumber == 16 && boss2t2 == true && i == 1)
                            {
                                //Restarts spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2t2 = false;
                            }
                            //Spawning position 3
                            if (wavenumber == 16 && boss2t3 == true && i == 2)
                            {
                                //Restarts spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2t3 = false;
                            }
                            //Spawning position 4
                            if (wavenumber == 16 && boss2t4 == true && i == 3)
                            {
                                //Restarts spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2t4 = false;
                            }
                            #endregion
                        }
                    }
                }
                #endregion

                #region BlastToBoss1Enemy
                if (wavenumber == 7)
                {
                    //If boss1 is not already dead
                    if (deadboss1 == false)
                    {
                        //Collision
                        if (PicBlast.Top < Boss1Enemy.Bottom && PicBlast.Bottom > Boss1Enemy.Top && PicBlast.Right > Boss1Enemy.Left && PicBlast.Left < Boss1Enemy.Right)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Decrease boss1 health
                            boss1health -= 2;
                            
                            if (boss1health <= 0)
                            {
                                boss1health = 0;
                            }
                            BossHP.Value = boss1health;
                            //Increase laser value
                            laservalue += 100;
                            ubullethit.Play();
                        }
                        //If blast results in win
                        if (boss1health <= 0 && deadboss1 == false)
                        {
                            //Increase score
                            score += 75000;
                            lblScore.Text = "SCORE: " + score;
                            // Sets boss1 as dead
                            deadboss1 = true;
                           
                        }
                    }
                }
               
                #endregion

                #region BlastToBoss2Enemy
                if (wavenumber == 16)
                {
                    // If boss2 is not already dead
                    if (deadboss2 == false)
                    {
                        //Collision
                        if (PicBlast.Top < Boss2Enemy.Bottom && PicBlast.Bottom > Boss2Enemy.Top && PicBlast.Right > Boss2Enemy.Left && PicBlast.Left < Boss2Enemy.Right)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Decrease boss2 health
                            boss2health -= 2;
                            if (boss2health <= 0)
                            {
                                boss2health = 0;
                            }
                            BossHP.Value = boss2health;
                            //Increase laser value
                            laservalue += 100;
                            //Play sound effect
                            ubullethit.Play();
                        }
                        //If blast results in dead of boss2
                        if (boss2health <= 0 && deadboss2 == false)
                        {
                            //Increase score
                            score += 100000;
                            lblScore.Text = "SCORE: " + score;
                         //Set boss2 as dead
                            deadboss2 = true;

                        }
                    }
                }

                #endregion

                #region BlastToBoss3Enemy
                if (wavenumber == 26)
                {
                    //If boss3 is not already dead
                    if (deadboss3 == false)
                    {
                        //Collision
                        if (PicBlast.Top < Boss3Enemy.Bottom && PicBlast.Bottom > Boss3Enemy.Top && PicBlast.Right > Boss3Enemy.Left && PicBlast.Left < Boss3Enemy.Right)
                        {
                            //Reset blast
                            PicBlast.Visible = false;
                            PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                            ublastact = 0;
                            ublasttmr.Enabled = false;
                            //Decrease boss health
                            boss3health -= 2;
                       
                            if (boss3health <= 0)
                            {
                                boss3health = 0;
                            }
                            BossHP.Value = boss3health;
                            //Increase laser value
                            laservalue += 100;
                            // Play sound effect
                            ubullethit.Play();
                        }
                        //If damage results in death of boss3
                        if (boss3health <= 0 && deadboss3 == false)
                        {
                            //Increase score
                            score += 150000;
                            lblScore.Text = "SCORE: " + score;
                            //Deadboss3 is true
                            deadboss3 = true;

                        }
                    }
                }

                #endregion

                if (PicBlast.Bottom < -100)
                {
                    ublastact = 0;
                    PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                   PicBlast.Visible = false;
                    ublasttmr.Enabled = false;
                }

            }
            #region SendToBack
            if (ublastact == 1 || ublastact == 2)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].SendToBack();
                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].SendToBack();
                }
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].SendToBack();
                }
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebullett[i].SendToBack();
                }
                if (wavenumber == 7)
                {
                    boss1bullet.SendToBack();
                }
                if (wavenumber == 16)
                {
                    boss2bullet.SendToBack();
                }

            }
            #endregion
#endregion
        }

        private void InvaderTimer_Tick(object sender, EventArgs e)
        {
            //The invaders come closer to you over timer
            //Speed chart (Y)
            //N = 20
            //P = 15
            //S = 25
            //T = 10
            #region InvadersWave1
            //Wave 1
            if (wavenumber == 1)
            {
                for (int i = 0; i <= numberofnenemies-1; i++)
                {
                    //Move Normal enemy down
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);
                    }

                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
            
                }

            }
            #endregion
            #region InvadersWave2
                //Wave 2
            else if (wavenumber == 2)
                    {
                        //Move Normal enemy down
                        for (int i = 0; i <= numberofnenemies - 1; i++)
                        {
                            if (normalenemy[i] == true)
                            {
                                picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);
                               
                            }
                            //Disable timer if below a certain point
                            if (picNEnemy[i].Bottom > 350)
                            {
                                InvaderTimer.Enabled = false;
                           }

                        }

                        //Move Power enemy down
                        for (int i = 0; i <= numberofpenemies - 1; i++)
                        {
                            if (powerenemy[i] == true)
                            {
                                picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 15);
                            }
                            //Disable timer if below a certain point
                            if (picPEnemy[i].Bottom > 350)
                            {
                                InvaderTimer.Enabled = false;
                            }
                        }



                    }
            #endregion
            #region InvadersWave3
                //Wave 3
            else if (wavenumber == 3)
            {
                //Move normal enemy down
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);
                    }

                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }

            }


            #endregion
            #region InvadersWave4
                //Wave 4
            else if (wavenumber == 4)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //Move normal enemy down
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 10);

                    }
                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move Power enemy down
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 10);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
            }
            #endregion
            #region InvadersWave5
                //Wave number 5
            else if (wavenumber == 5)
            {
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    //Move Speed enemy down
                    if (speedenemy[i] == true)
                    {
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 25);

                    }
                    //Disable timer if below a certain point
                    if (picSEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }

              
            }
            #endregion
            #region InvadersWave6
                //Wave 6
            else if (wavenumber == 6)
            {
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    //Move tank enemy down
                    if (tankenemy[i] == true)
                    {
                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, picTEnemy[i].Location.Y + 10);

                    }
                    //Disable timer if below a certain point
                    if (picTEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }


            }
            #endregion

            //Stage 2
           
                #region Invaders Wave 12
            //Wave number 12 
            if (wavenumber == 12)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //Move normal enemy down
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);

                    }
                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }
            }
                #endregion
          
          
                #region Invaders Wave 13
                //Wave number 13
            else if (wavenumber == 13)
            {
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //Move Power enemy down
                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
            }
            #endregion
            #region Invaders Wave 14
                //Wave number 14
            else if (wavenumber == 14)
            {
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    //Move speed enemy down
                    if (speedenemy[i] == true)
                    {
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picSEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
            }
            #endregion
            #region Invaders Wave 15
                //Wave number 15
            else if (wavenumber == 15)
            { 
                //Move tank enemy down
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    if (tankenemy[i] == true)
                    {
                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, picTEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picTEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
            }
            #endregion

            //Stage 3
                 #region Invaders Wave 21
            //Wave 21
            if (wavenumber == 21)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //Move normal enemy down
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);

                    }
                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }

                //Move power enemy down
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }



            }
#endregion

            #region InvadersWave22
                //Wave number 22
            else if (wavenumber == 22)
            {
                //Move speed enemy down
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    if (speedenemy[i] == true)
                    {
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 25);

                    }
                    //Disable timer if below a certain point
                    if (picSEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move tank enemy down
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {

                    if (tankenemy[i] == true)
                    {
                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, picTEnemy[i].Location.Y + 20);

                    }
                    //Disable timer if below a certain point
                    if (picTEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }


            }
            #endregion

            #region InvadersWave23
                //Wave 23
            else if (wavenumber == 23)
            {
                //Move speed enemy down
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    if (speedenemy[i] == true)
                    {
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picSEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move power enemy down
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move normal enemy down
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);
                    }

                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }
           


            }
            #endregion
            #region Invaders Wave 24
                //Wave 24
            else if (wavenumber == 24)
            {
                //Move speed enemy down
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {

                    if (speedenemy[i] == true)
                    {
                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 25);
                    }
                    //Disable timer if below a certain point
                    if (picSEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move normal enemy down
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 20);
                    }

                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }
                //Move power enemy down
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {

                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 15);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;

                    }
                }


            }
            #endregion
            #region Invaders Wave 25
                //Wave number 25
            else if (wavenumber == 25)
            {
                //Move power enemy down
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    if (powerenemy[i] == true)
                    {
                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 10);
                    }
                    //Disable timer if below a certain point
                    if (picPEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }
                //Move normal enemy down
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (normalenemy[i] == true)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 10);
                    }

                    //Disable timer if below a certain point
                    if (picNEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }

                }
                //Move tank enemy down
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    if (tankenemy[i] == true)
                    {
                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, picTEnemy[i].Location.Y + 10);

                    }
                    //Disable timer if below a certain point
                    if (picTEnemy[i].Bottom > 350)
                    {
                        InvaderTimer.Enabled = false;
                    }
                }


            }
            #endregion

        }

     
     
       // NEW WAVESSSSSSSSSSSSSSSSSSSSSSSSSSSS
        private void checknewwave()
        {

            if (wavenumber == 1 && countdead == 0)
            {

                numberofnenemies = 3;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Visible = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(1100, 100);
                picNEnemy[1].Location = new Point(1100, 100);
                picNEnemy[2].Location = new Point(1100, 100);
                spawntmr.Enabled = true;
                MusicTimer.Enabled = true;

            }

            #region Wave1toWave2 + PEnemy
            if (wavenumber == 1 && countdead == 3)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                    rndntimer[i] = rnd.Next(1, 4);
                }

                countdead = 0;
                wavenumber = 2;

                numberofnenemies = 2;


                //Nenemy
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }

                numberofpenemies = 3;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Visible = true;
                    rndptimer[i] = rnd.Next(1, 4);

                }


                //picNEnemy[0].Location = new Point(330, 60);
                // picNEnemy[1].Location = new Point(470, 60);
                // picNEnemy[2].Location = new Point(620, 60);
                // picNEnemy[3].Location = new Point(190, 60);
                // picNEnemy[4].Location = new Point(760, 60);


                picNEnemy[0].Location = new Point(330, 0);
                picNEnemy[1].Location = new Point(620, 0);

                picPEnemy[0].Location = new Point(190, 0);
                picPEnemy[1].Location = new Point(470, 0);
                picPEnemy[2].Location = new Point(760, 0);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;


            }
            #endregion

            #region Wave2toWave3
            else if (wavenumber == 2 && countdead == 5)
            {
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;

                }



                countdead = 0;
                wavenumber = 3;

                numberofnenemies = 4;

                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    picPEnemy[i].Visible = false;
                    rndptimer[i] = rnd.Next(1, 4);
                }

                numberofpenemies = 0;

                //Nenemy
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(330, 0);
                picNEnemy[1].Location = new Point(620, 0);
                picNEnemy[2].Location = new Point(330, -80);
                picNEnemy[3].Location = new Point(620, -80);


                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;
            }

            #endregion
            #region Wave3toWave4

            else if (wavenumber == 3 && countdead == 4)
            {

                countdead = 0;
                wavenumber = 4;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;

                }

                numberofnenemies = 2;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    rndntimer[i] = rnd.Next(1, 4);
                    // ebulletn[i].Visible = false;
                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);

                }
                numberofpenemies = 2;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picPEnemy[i].Visible = true;
                    deadpenemy[i] = false;
                    ephealth[i] = 3;
                    powerenemy[i] = true;
                    rndptimer[i] = rnd.Next(1, 4);

                }
                picNEnemy[0].Location = new Point(1100, 610);
                picNEnemy[1].Location = new Point(1300, 610);

                picPEnemy[0].Location = new Point(1200, 610);
                picPEnemy[1].Location = new Point(1400, 610);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;

            }
            #endregion


            #region Wave4toWave5 + SEnemy


            else if (wavenumber == 4 && countdead == 4)
            {
                countdead = 0;
                wavenumber = 5;

                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    picPEnemy[i].Visible = false;
                }
                numberofnenemies = 0;
                numberofpenemies = 0;


                numberofsenemies = 3;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    rndstimer[i] = rnd.Next(1, 4);
                    picSEnemy[i].Visible = true;
                }


                picSEnemy[0].Location = new Point(330, -60);
                picSEnemy[1].Location = new Point(470, -60);
                picSEnemy[2].Location = new Point(620, -60);
                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;
            }


            #endregion

            #region Wave5ToWave6 + Tank Enemy
            else if (wavenumber == 5 && countdead == 3)
            {
                countdead = 0;
                wavenumber = 6;

                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                }
                numberofsenemies = 0;


                numberoftenemies = 5;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    picTEnemy[i].Visible = true;
                    rndttimer[i] = rnd.Next(1, 4);

                }

                picTEnemy[0].Location = new Point(-60, 60);
                picTEnemy[1].Location = new Point(330, -60);
                picTEnemy[2].Location = new Point(470, -60);
                picTEnemy[3].Location = new Point(620, -60);
                picTEnemy[4].Location = new Point(1060, 60);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;
            }
            #endregion

            #region Wave6toWave7 + Boss1 Enemy
            else if (wavenumber == 6 && countdead == 5)
            {
                wavenumber = 7;
                countdead = 0;

                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebullett[i].Visible = false;
                }
                numberoftenemies = 0;
                boss1bulletact = false;

                ebullettmr.Enabled = false;
                ebulletdelay.Interval = 1500;
                BossHP.Visible = true;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;
                Boss1Enemy.Visible = true;
                deadboss1 = false;

                BossHP.Maximum = 75;
                BossHP.Value = 75;
                boss1health = 75;
                spawntmr.Enabled = true;
              
                boss1leftorright = 1;
                EpicText.Visible = true;




            }
            #endregion

            //STAGE 2
            #region S2Wave1
            if (wavenumber == 11 && countdead == 0)
            {
                numberofnenemies = 2;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Visible = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }

                numberofpenemies = 1;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Visible = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberofsenemies = 1;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].Visible = true;
                    rndstimer[i] = rnd.Next(1, 4);
                }
                numberoftenemies = 1;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    picTEnemy[i].Visible = true;
                    rndttimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(-100, 200);
                picNEnemy[1].Location = new Point(1100, 200);

                picPEnemy[0].Location = new Point(-100, 140);
                picSEnemy[0].Location = new Point(1100, 140);

                picTEnemy[0].Location = new Point(450, -100);
                //picNEnemy[0].Location = new Point(330, 0);
                //picNEnemy[1].Location = new Point(620, 0);

                // picPEnemy[0].Location = new Point(190, 0);
                //picPEnemy[1].Location = new Point(470, 0);
                //picPEnemy[2].Location = new Point(760, 0);


                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;
                MusicTimer.Enabled = true;
            }
            #endregion
            #region S2Wave1toWave2
            else if (wavenumber == 11 && countdead == 5)
            {
                countdead = 0;
                wavenumber = 12;

                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                }
                numberofnenemies = 0;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                }
                numberofpenemies = 0;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                }
                numberofsenemies = 0;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebullett[i].Visible = false;
                }
                numberoftenemies = 0;


                numberofnenemies = 5;


                //Nenemy
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }



                picNEnemy[0].Location = new Point(330, -100);
                picNEnemy[1].Location = new Point(620, -100);

                picNEnemy[2].Location = new Point(190, -100);
                picNEnemy[3].Location = new Point(470, -100);
                picNEnemy[4].Location = new Point(760, -100);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;


            }
            #endregion
            #region S2Wave2towave3
            else if (wavenumber == 12 && countdead == 5)
            {
                countdead = 0;
                wavenumber = 13;

                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                }
                numberofnenemies = 0;

                numberofpenemies = 5;



                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picPEnemy[i].Visible = true;
                    deadpenemy[i] = false;
                    ephealth[i] = 3;
                    powerenemy[i] = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }



                picPEnemy[0].Location = new Point(330, -100);
                picPEnemy[1].Location = new Point(620, -100);

                picPEnemy[2].Location = new Point(190, -100);
                picPEnemy[3].Location = new Point(470, -100);
                picPEnemy[4].Location = new Point(760, -100);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;

            }
            #endregion
            #region S2Wave3towave4
            else if (wavenumber == 13 && countdead == 5)
            {
                countdead = 0;
                wavenumber = 14;

                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                }
                numberofpenemies = 0;

                numberofsenemies = 5;



                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picSEnemy[i].Visible = true;
                    deadsenemy[i] = false;
                    eshealth[i] = 3;
                    speedenemy[i] = true;
                    rndstimer[i] = rnd.Next(1, 4);
                }



                picSEnemy[0].Location = new Point(330, -100);
                picSEnemy[1].Location = new Point(620, -100);

                picSEnemy[2].Location = new Point(190, -100);
                picSEnemy[3].Location = new Point(470, -100);
                picSEnemy[4].Location = new Point(760, -100);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;

            }
            #endregion
            #region S2Wave4towave5
            else if (wavenumber == 14 && countdead == 5)
            {
                countdead = 0;
                wavenumber = 15;

                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                }
                numberofsenemies = 0;

                numberoftenemies = 5;



                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picTEnemy[i].Visible = true;
                    deadtenemy[i] = false;
                    ethealth[i] = 7;
                    tankenemy[i] = true;
                    rndttimer[i] = rnd.Next(1, 4);
                }



                picTEnemy[0].Location = new Point(330, -100);
                picTEnemy[1].Location = new Point(620, -100);

                picTEnemy[2].Location = new Point(190, -100);
                picTEnemy[3].Location = new Point(470, -100);
                picTEnemy[4].Location = new Point(760, -100);

                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;

            }
            #endregion


            #region S2Wave5toWave6 + Boss2 Enemy
            else if (wavenumber == 15 && countdead == 5)
            {
                wavenumber = 16;
                countdead = 0;

                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebullett[i].Visible = false;
                }
                numberoftenemies = 0;
                numberofpenemies = 4;
                numberofsenemies = 4;
                numberoftenemies = 4;
                BossHP.Visible = true;

                BossHP.Maximum = 100;
                BossHP.Value = 100;
                boss2health = 100;
                ebulletdelay.Interval = 3000;
                ebullettmr.Enabled = false;
                ebulletdelay2.Enabled = true;
                ebulletdelay3.Enabled = true;
                boss2bulletact = false;
                Boss2Enemy.Visible = true;
                deadboss2 = false;
             


                // Boss1Enemy.Location = new Point(410, 30);
                Boss2eSpawn.Enabled = true;
                spawntmr.Enabled = true;


                boss1leftorright = 1;
                EpicText.Text = "Boss: Spawner";
                EpicText.Visible = true;




            }
            #endregion

            //STAGE 3
            #region S3 Wave1
            if (wavenumber == 21 && countdead == 0)
            {
                numberofnenemies = 5;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Visible = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(1100, 150);
                picNEnemy[1].Location = new Point(1100, 150);
                picNEnemy[2].Location = new Point(1100, 150);
                picNEnemy[3].Location = new Point(1100, 150);
                picNEnemy[4].Location = new Point(1100, 150);

                numberofpenemies = 3;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Visible = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                picPEnemy[0].Location = new Point(270, -100);
                picPEnemy[1].Location = new Point(470, -100);
                picPEnemy[2].Location = new Point(670, -100);

                InvaderTimer.Enabled = false; 
                spawntmr.Enabled = true;
                MusicTimer.Enabled = true;


            }
            #endregion
            #region S3 Wave1 to Wave 2
            else if (wavenumber == 21 && countdead == 8)
            {
                countdead = 0;
                    wavenumber = 22;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberofnenemies = 0;
                numberofpenemies = 0;

                numberofsenemies = 3;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {

                    picSEnemy[i].Visible = true;
                    deadsenemy[i] = false;
                    eshealth[i] = 3;
                   speedenemy[i] = true;
                    rndstimer[i] = rnd.Next(1, 4);
                }
                numberoftenemies = 3;

                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                   
                    picTEnemy[i].Visible = true;
                    deadtenemy[i] = false;
                    ethealth[i] = 7;
                    tankenemy[i] = true;
                    rndttimer[i] = rnd.Next(1, 4);
                }

                picSEnemy[0].Location = new Point(270, -100);
                picSEnemy[1].Location = new Point(470, -100);
                picSEnemy[2].Location = new Point(670, -100);

                picTEnemy[0].Location = new Point(1100, 150);
                picTEnemy[1].Location = new Point(1100, 150);
                picTEnemy[2].Location = new Point(1100, 150);

                spawntmr.Enabled = true;
                InvaderTimer.Enabled = false;
            }
            #endregion
            #region S3 Wave2 to Wave 3
            else if (wavenumber == 22 && countdead == 6)
            {
                countdead = 0;
                wavenumber = 23;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                    rndstimer[i] = rnd.Next(1, 4);
                }
                numberofsenemies = 0;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberoftenemies = 0;
                numberofpenemies = 3;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {

                    picPEnemy[i].Visible = true;
                    deadpenemy[i] = false;
                    ephealth[i] = 3;
                    powerenemy[i] = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }

                numberofsenemies = 3;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {

                    picSEnemy[i].Visible = true;
                    deadsenemy[i] = false;
                    eshealth[i] = 3;
                    speedenemy[i] = true;
                    rndstimer[i] = rnd.Next(1, 4);
                }

                numberofnenemies = 2;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {

                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(-100, 100);
                picNEnemy[1].Location = new Point(1100, 100);

                picSEnemy[0].Location = new Point(270, -100);
                picSEnemy[1].Location = new Point(470, -100);
                picSEnemy[2].Location = new Point(670, -100);

                picPEnemy[0].Location = new Point(1100, 150);
                picPEnemy[1].Location = new Point(1100, 150);
                picPEnemy[2].Location = new Point(1100, 150);

               

                spawntmr.Enabled = true;
                InvaderTimer.Enabled = false;
            }
            #endregion

            #region S3Wave3towave4
            else if (wavenumber == 23 && countdead == 8)
            {
                countdead = 0;
                wavenumber = 24;

                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                    rndstimer[i] = rnd.Next(1, 4);
                }
                numberofsenemies = 0;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                numberofpenemies = 0;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                    rndntimer[i] = rnd.Next(1, 4);
                }

                numberofnenemies = 0;


                numberofnenemies = 2;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }

                numberofpenemies = 2;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picPEnemy[i].Visible = true;
                    deadpenemy[i] = false;
                    ephealth[i] = 3;
                    powerenemy[i] = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberofsenemies = 1;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    // ebulletn[i].Visible = false;
                    picSEnemy[i].Visible = true;
                    deadsenemy[i] = false;
                    eshealth[i] = 3;
                    speedenemy[i] = true;
                    rndstimer[i] = rnd.Next(1, 4);
                }

                picNEnemy[0].Location = new Point(190, -100);
                picNEnemy[1].Location = new Point(760, -100);

                picPEnemy[0].Location = new Point(330, -100);
                picPEnemy[1].Location = new Point(620, -100);

              
                picSEnemy[0].Location = new Point(470, -100);
               
                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;

            }
            #endregion
            #region S3Wave4ToWave5
            else if (wavenumber == 24 && countdead == 5)
            {
                countdead = 0;
                wavenumber = 25;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                numberofnenemies = 0;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberofpenemies = 0;
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    ebullets[i].Visible = false;
                    rndstimer[i] = rnd.Next(1, 4);
                }
                numberofsenemies = 0;

                numberofpenemies = 3;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {

                    picPEnemy[i].Visible = true;
                    deadpenemy[i] = false;
                    ephealth[i] = 3;
                    powerenemy[i] = true;
                    rndptimer[i] = rnd.Next(1, 4);
                }



                numberoftenemies = 3;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {

                    picTEnemy[i].Visible = true;
                    deadtenemy[i] = false;
                    ethealth[i] = 7;
                    tankenemy[i] = true;
                    rndttimer[i] = rnd.Next(1, 4);
                }
                numberofnenemies = 5;
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {

                    picNEnemy[i].Visible = true;
                    deadnenemy[i] = false;
                    enhealth[i] = 2;
                    normalenemy[i] = true;
                    rndntimer[i] = rnd.Next(1, 4);
                }
                picNEnemy[0].Location = new Point(190, -100);
                picNEnemy[1].Location = new Point(330, -100);
                picNEnemy[2].Location = new Point(470, -100);
                picNEnemy[3].Location = new Point(620, -100);
                picNEnemy[4].Location = new Point(760, -100);

                picPEnemy[0].Location = new Point(270, -100);
                picPEnemy[1].Location = new Point(470, -100);
                picPEnemy[2].Location = new Point(670, -100);

                picTEnemy[0].Location = new Point(1100, 160);
                picTEnemy[1].Location = new Point(1100, 160);
                picTEnemy[2].Location = new Point(1100, 160);
                InvaderTimer.Enabled = false;
                spawntmr.Enabled = true;
            }
            #endregion
            #region S3Wave5toWave6 + Boss3 Enemy
            else if (wavenumber == 25 && countdead == 11)
            {
                countdead = 0;
                wavenumber = 26;
               for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //ebulletn[i].Visible = false;
                  
                }
                numberofnenemies = 0;
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    rndptimer[i] = rnd.Next(1, 4);
                }
                numberofpenemies = 0;
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    ebullett[i].Visible = false;
                    rndttimer[i] = rnd.Next(1, 4);
                }
                numberoftenemies = 0;
                numberofnenemies = 5;
                for (int i = 0; i <= numberofnenemies - 1; i++ )
                {
                    deadnenemy[i] = true;

                }

                BossHP.Maximum = 150;
                BossHP.Value = 150;
                boss3health = 150;
        
                ebulletdelay.Interval = 1750;
                boss3bulletact = false;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;
                Boss3Enemy.Visible = true;
                BossHP.Visible = true;
                deadboss3 = false;
                // Boss1Enemy.Location = new Point(410, 30);
                spawntmr.Enabled = true;
               
                
                boss3leftorright = 1;
                EpicText.Text = "Boss: Destroyer";
                EpicText.Visible = true;

            }
            #endregion
        }

        
        private void spawntmr_Tick(object sender, EventArgs e)
        {
            #region Wave1Spawning

            if (wavenumber == 1)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (picNEnemy[i].Left > (i + 1) * 250)
                    {
                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X - 20, picNEnemy[i].Location.Y);
                    }
                }
                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Left < 250)
                {
                  
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                }
            }
            #endregion


            #region Wave2Spawning
            else if (wavenumber == 2)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 5);


                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 5);

                }
                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;
                 
                    
                }



            }
            #endregion

            #region Wave3Spawning

            else  if (wavenumber == 3)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 5);

                }
                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Location.Y > 200)
                {
            spawntmr.Enabled = false;

                }
            }
            #endregion


            #region Wave4Spawning
            else if (wavenumber == 4)
            {
                ebulletdelay.Enabled = false;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;

                //Move enemies to place
                    for (int i = 0; i <= numberofnenemies - 1; i++)
                    {
                        if (picNEnemy[i].Location.X > 470)
                        {
                            picNEnemy[i].Location = new Point(picNEnemy[i].Location.X - 20, picNEnemy[i].Location.Y);
                        }
                        if (picPEnemy[i].Location.X > 470)
                        {
                            picPEnemy[i].Location = new Point(picPEnemy[i].Location.X - 20, picPEnemy[i].Location.Y);
                        }

                    }
                    //Move enemies to place
                    if (picNEnemy[0].Location.Y > 10)
                    {
                        picNEnemy[0].Location = new Point(picNEnemy[0].Location.X , picNEnemy[0].Location.Y-20);
                    }
                    if (picPEnemy[0].Location.Y - picNEnemy[0].Location.Y > 60)
                    {
                        picPEnemy[0].Location = new Point(picPEnemy[0].Location.X, picPEnemy[0].Location.Y - 20);
                    }
                    if (picNEnemy[1].Location.Y - picPEnemy[0].Location.Y > 60)
                    {
                        picNEnemy[1].Location = new Point(picNEnemy[1].Location.X, picNEnemy[1].Location.Y - 20);
                    }
                    if (picPEnemy[1].Location.Y - picNEnemy[1].Location.Y > 60)
                    {
                        picPEnemy[1].Location = new Point(picPEnemy[1].Location.X, picPEnemy[1].Location.Y - 20);
                    }
                    //Disable spawn timer after enemy place is set
                if (picPEnemy[1].Location.X <= 470 && picNEnemy[0].Location.Y <= 10)
                {
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                  
                    ebulletdelay.Enabled = true;
                    ebulletdelay2.Enabled = true;
                    ebulletdelay3.Enabled = true;
                }
           
                

              
            }
            #endregion

            #region Wave5Spawning

            else if (wavenumber == 5)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 5);

                }
                //Disable spawn timer after enemy place is set
                if (picSEnemy[0].Location.Y > 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }
            }
            #endregion

            #region Wave6Spawning

            else if (wavenumber == 6)
            {

                //Move enemies to place
                if (picTEnemy[0].Location.X < 150)
                {
                    picTEnemy[0].Location = new Point(picTEnemy[0].Location.X+20, picTEnemy[0].Location.Y);
                }
                if (picTEnemy[1].Location.Y < 20)
                {
                    picTEnemy[1].Location = new Point(picTEnemy[1].Location.X, picTEnemy[1].Location.Y+10);
                    picTEnemy[2].Location = new Point(picTEnemy[2].Location.X, picTEnemy[2].Location.Y + 10);
                    picTEnemy[3].Location = new Point(picTEnemy[3].Location.X, picTEnemy[3].Location.Y + 10);
                }

                if (picTEnemy[4].Location.X > 720)
                {
                    picTEnemy[4].Location = new Point(picTEnemy[4].Location.X - 20, picTEnemy[4].Location.Y);
                }
                //Disable spawn timer after enemy place is set
                if (picTEnemy[0].Location.X >= 150 && picTEnemy[1].Location.Y >= 20 && picTEnemy[4].Location.X <= 720)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;
                }


               // picTEnemy[0].Location = new Point(190, 0);
               // picTEnemy[1].Location = new Point(330, 0);
               // picTEnemy[2].Location = new Point(470, 0);
               // picTEnemy[3].Location = new Point(620, 0);
              //  picTEnemy[4].Location = new Point(760, 0);
            }
            #endregion
            #region Wave7Spawning
            else if (wavenumber == 7)
            {
                //Move enemies to place
                Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y + 5);
                //Disable spawn timer after enemy place is set
                if (Boss1Enemy.Location.Y >= 30)
                {
                    spawntmr.Enabled = false;
                    BossTimer.Enabled = true;
                }
            }
            #endregion


            //STAGE 2
            #region S2Wave1Spawning
            if (wavenumber == 11)
            {
                //Move enemies to place
                if (picNEnemy[0].Location.X <= 190)
                {
                    picNEnemy[0].Location = new Point(picNEnemy[0].Location.X + 10, picNEnemy[0].Location.Y);
                }
                if (picNEnemy[1].Location.X >= 760)
                {
                    picNEnemy[1].Location = new Point(picNEnemy[1].Location.X - 10, picNEnemy[1].Location.Y);
                }

                //Move enemies to place
                if (picPEnemy[0].Location.X <= 330)
                {
                    picPEnemy[0].Location = new Point(picPEnemy[0].Location.X + 10, picPEnemy[0].Location.Y);
                }
                if (picSEnemy[0].Location.X >= 620)
                {
                    picSEnemy[0].Location = new Point(picSEnemy[0].Location.X - 10, picSEnemy[0].Location.Y);
                }

                if (picTEnemy[0].Location.Y <= 20)
                {
                    picTEnemy[0].Location = new Point(picTEnemy[0].Location.X, picTEnemy[0].Location.Y + 10);
                }
                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Location.X >= 190 && picNEnemy[1].Location.X <= 760 && picPEnemy[0].Location.X >= 330 && picSEnemy[0].Location.X <= 620 && picTEnemy[0].Location.Y >= 20)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;
                }


            }
            #endregion
            #region S2Wave2Spawning

            else if (wavenumber == 12)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 5);
                }

                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;
                  
                }

            }
            #endregion
            #region S2Wave3Spawning
            else if (wavenumber == 13)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 5);


                }

                //Disable spawn timer after enemy place is set
                if (picPEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }

            }
            #endregion
            #region S2Wave4Spawning
            else if (wavenumber == 14)
            {
                //Move enemies to place
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 5);
                }

                //Disable spawn timer after enemy place is set
                if (picSEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }

            }
            #endregion
            #region S2Wave5Spawning
            else if (wavenumber == 15)
            {
                //Move enemies to place
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, picTEnemy[i].Location.Y + 5);
                }

                //Disable spawn timer after enemy place is set
                if (picTEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }

            }
            #endregion

            #region Wave6Spawning
            else if (wavenumber == 16)
            {
                //Move enemies to place
                Boss2Enemy.Location = new Point(Boss2Enemy.Location.X, Boss2Enemy.Location.Y + 5);
                //Disable spawn timer after enemy place is set
                if (Boss2Enemy.Location.Y >= 30)
                {
                    spawntmr.Enabled = false;
                    BossTimer.Enabled = true;
                }
            }
            #endregion

            //STAGE 3
            #region S3 Wave 1 Spawning
            if (wavenumber == 21)
            {
                //Move enemies to place
                if (picNEnemy[0].Location.X >= 190)
                {
                    picNEnemy[0].Location = new Point (picNEnemy[0].Location.X-30, 150);
                }
                if (picNEnemy[1].Location.X >= 330)
                {
                    picNEnemy[1].Location = new Point(picNEnemy[1].Location.X - 30, 150);
                }
                if (picNEnemy[2].Location.X >= 470)
                {
                    picNEnemy[2].Location = new Point(picNEnemy[2].Location.X - 30, 150);
                }
                if (picNEnemy[3].Location.X >= 620)
                {
                    picNEnemy[3].Location = new Point(picNEnemy[3].Location.X - 30, 150);
                }
                if (picNEnemy[4].Location.X >= 760)
                {
                    picNEnemy[4].Location = new Point(picNEnemy[4].Location.X - 30, 150);
                }
                //Move enemies to place
                if (picPEnemy[0].Location.Y < 50)
                {
                    picPEnemy[0].Location = new Point(picPEnemy[0].Location.X, picPEnemy[0].Location.Y +10);
                    picPEnemy[1].Location = new Point(picPEnemy[1].Location.X, picPEnemy[1].Location.Y + 10);
                    picPEnemy[2].Location = new Point(picPEnemy[2].Location.X, picPEnemy[2].Location.Y + 10);
                }
                //Disable spawn timer after enemy place is set
                if (picPEnemy[0].Location.Y >= 50 && picNEnemy[0].Location.X <= 190)
                {
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                }

            }
            #endregion
            #region S3Wave2 Spawning
            else if (wavenumber == 22)
            {
                //Move enemies to place
                if (picSEnemy[0].Location.Y < 50)
                {
                    picSEnemy[0].Location = new Point(picSEnemy[0].Location.X, picSEnemy[0].Location.Y + 10);
                    picSEnemy[1].Location = new Point(picSEnemy[1].Location.X, picSEnemy[1].Location.Y + 10);
                    picSEnemy[2].Location = new Point(picSEnemy[2].Location.X, picSEnemy[2].Location.Y + 10);
                }
                //Move enemies to place
                if (picTEnemy[0].Location.X >= 270)
                {
                    picTEnemy[0].Location = new Point(picTEnemy[0].Location.X - 30, 150);
                }
                if (picTEnemy[1].Location.X >= 470)
                {
                    picTEnemy[1].Location = new Point(picTEnemy[1].Location.X - 30, 150);
                }
                if (picTEnemy[2].Location.X >= 670)
                {
                    picTEnemy[2].Location = new Point(picTEnemy[2].Location.X - 30, 150);
                }
                //Disable spawn timer after enemy place is set
                if (picSEnemy[0].Location.Y >= 50 && picTEnemy[0].Location.X <= 270)
                {
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                }

            }

            #endregion
            #region S3Wave3 Spawning
            else if (wavenumber == 23)
            {
                //Move enemies to place
                if (picSEnemy[0].Location.Y < 50)
                {
                    picSEnemy[0].Location = new Point(picSEnemy[0].Location.X, picSEnemy[0].Location.Y + 10);
                    picSEnemy[1].Location = new Point(picSEnemy[1].Location.X, picSEnemy[1].Location.Y + 10);
                    picSEnemy[2].Location = new Point(picSEnemy[2].Location.X, picSEnemy[2].Location.Y + 10);
                }
                //Move enemies to place
                if (picPEnemy[0].Location.X >= 270)
                {
                    picPEnemy[0].Location = new Point(picPEnemy[0].Location.X - 30, 150);
                }
                if (picPEnemy[1].Location.X >= 470)
                {
                    picPEnemy[1].Location = new Point(picPEnemy[1].Location.X - 30, 150);
                }
                if (picPEnemy[2].Location.X >= 670)
                {
                    picPEnemy[2].Location = new Point(picPEnemy[2].Location.X - 30, 150);
                }
                //Move enemies to place
                if (picNEnemy[0].Location.X <= 190)
                {
                    picNEnemy[0].Location = new Point(picNEnemy[0].Location.X + 30, 100);
                }
                if (picNEnemy[1].Location.X >= 760)
                {
                    picNEnemy[1].Location = new Point(picNEnemy[1].Location.X - 30, 100);
                }
                //Disable spawn timer after enemy place is set
                if (picSEnemy[0].Location.Y >= 50 && picPEnemy[0].Location.X <= 270 && picNEnemy[0].Location.X >= 190)
                {
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                }
               // picNEnemy[0].Location = new Point(330, 0);
              //  picNEnemy[1].Location = new Point(620, 0);

              //  picPEnemy[0].Location = new Point(190, 0);
               // picPEnemy[1].Location = new Point(470, 0);
               // picPEnemy[2].Location = new Point(760, 0);
            }

            #endregion

            #region S3Wave4Spawning
            else if (wavenumber == 24)
            {   
                //Move enemies to place
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, picSEnemy[i].Location.Y + 5);

                }
                if (picSEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }
                //Move enemies to place
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, picPEnemy[i].Location.Y + 5);

                }
                if (picPEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }
                //Move enemies to place
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 5);

                }
                //Disable spawn timer after enemy place is set
                if (picNEnemy[0].Location.Y >= 60)
                {
                    InvaderTimer.Enabled = true;
                    spawntmr.Enabled = false;

                }

            }
            #endregion
            #region S3Wave5 Spawning
            else if (wavenumber == 25)
            {
                //Move enemies to place
                if (picPEnemy[0].Location.Y < 100)
                {
                    picPEnemy[0].Location = new Point(picPEnemy[0].Location.X, picPEnemy[0].Location.Y + 10);
                    picPEnemy[1].Location = new Point(picPEnemy[1].Location.X, picPEnemy[1].Location.Y + 10);
                    picPEnemy[2].Location = new Point(picPEnemy[2].Location.X, picPEnemy[2].Location.Y + 10);
                }
                //Move enemies to place
                if (picTEnemy[0].Location.X >= 270)
                {
                    picTEnemy[0].Location = new Point(picTEnemy[0].Location.X - 30, 160);
                }
                if (picTEnemy[1].Location.X >= 470)
                {
                    picTEnemy[1].Location = new Point(picTEnemy[1].Location.X - 30, 160);
                }
                if (picTEnemy[2].Location.X >= 670)
                {
                    picTEnemy[2].Location = new Point(picTEnemy[2].Location.X - 30, 160);
                }
                //Move enemies to place
                 for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    if (picNEnemy[i].Location.Y <= 30)
                    {
                    picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, picNEnemy[i].Location.Y + 10);
                    }
                }
                 //Disable spawn timer after enemy place is set
                if (picPEnemy[0].Location.Y >= 100 && picTEnemy[0].Location.X <= 270 && picNEnemy[2].Location.Y >= 30)
                {
                    spawntmr.Enabled = false;
                    InvaderTimer.Enabled = true;
                }

            }

            #endregion
            #region S3 Wave 6 Spawning
            else if (wavenumber == 26)
            {
                //Move enemies to place
                Boss3Enemy.Location = new Point(Boss3Enemy.Location.X, Boss3Enemy.Location.Y + 5);
                //Disable spawn timer after enemy place is set
                if (Boss3Enemy.Location.Y >= 30)
                {
                    spawntmr.Enabled = false;
                    BossTimer.Enabled = true;
                }
            }
            #endregion
        }

           private void BossTimer_Tick(object sender, EventArgs e)
        {
            if (wavenumber == 7)
            {
                #region deadboss1
                //If boss1 loses all HP
                if (deadboss1 == true)
                {
                    //Deactivate everything and activate explosion timer
                    ebulletdelay.Enabled = false;
                    ebulletdelay2.Enabled = false;
                    ebulletdelay3.Enabled = false;
                    BossTimer.Enabled = false;
                    BossExplosion.Enabled = true;
                    Warning1.Visible = false;
                    Warning2.Visible = false;
                    Warning3.Visible = false;
                    Warning4.Visible = false;
                    Warning5.Visible = false;
                    Warning6.Visible = false;
                    Warning7.Visible = false;
                    Warning8.Visible = false;

                }
                #endregion

                #region Boss1decidemove
                //Do actions but only in certain intervals
                if (Boss1Enemy.Location.X <= 0 && boss1doaction == true && boss1ultiact == 0 && boss1attackdelay == 0 || Boss1Enemy.Location.X == 410 && boss1doaction == true && boss1ultiact == 0 && boss1attackdelay == 0 || Boss1Enemy.Location.X >= 795 && boss1doaction == true && boss1ultiact == 0 && boss1attackdelay == 0)
                {
                    //Generate random move (1-5 = move, 6-8 tackle, 9-10 ultimate move)
                    boss1decidemove = rnd.Next(1, 11);
                }
                //If at low health, use the ultimate at least once
                if (boss1health <= 15 && activateultiiflowhp == true && boss1nodoubles == 0)
                {
                    activateultiiflowhp = false;
                    boss1decidemove = 9;
                }
                #endregion

                #region Boss1MoveLeftorRight
                //Move left or right if decidemove == 1-5
                if (boss1decidemove == 1 || boss1decidemove == 2 || boss1decidemove == 3 || boss1decidemove == 4 || boss1decidemove == 5 || boss1nodoubles == 1 && boss1decidemove == 6)
                {
                    ebulletdelay.Enabled = true;
                    boss1doaction = false;
                    //Move Left if boss1lefttorright = 1
                    if (boss1leftorright == 1 && boss1attackdelay == 0)
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X - 5, Boss1Enemy.Location.Y);
                    }
                    //Move Right if boss1lefttorright = 2
                    else if (boss1leftorright == 2 && boss1attackdelay == 0)
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X + 5, Boss1Enemy.Location.Y);
                    }
                   
                    if (Boss1Enemy.Location.X <= 0)
                    {
                        //Change to right in Boss X location < 0
                        boss1leftorright = 2;
                        //Allow Generate random number for next move
                        boss1doaction = true;
                    }
                   
                    else if (Boss1Enemy.Location.X >= 795)
                    {

                        //Change to left in Boss X location < 0
                        boss1leftorright = 1;
                        //Allow Generate random number for next move
                        boss1doaction = true;
                    }

                    else if (Boss1Enemy.Location.X == 410)
                    {
                        //Allow Generate random number for next move
                        boss1doaction = true;
                        //Stops from doing the same ability twice
                        boss1nodoubles = 0;
                    }


                }
                #endregion

                #region Boss1TackleAttack
                //Tackle attack
                //Tackle ability if decidemove = 6-8
                if (boss1decidemove == 6 && boss1nodoubles == 0 || boss1decidemove == 7 && boss1nodoubles == 0 || boss1decidemove == 8 && boss1nodoubles == 0)
                {
                    //Create Warnings if x location is <= 0
                    if (Boss1Enemy.Location.X <= 0)
                    {
                        Warning1.Visible = true;
                        Warning2.Visible = true;
                        Warning1.SendToBack();
                        Warning2.SendToBack();
                    }
                    //Create Warnings if x location is = 410
                    else if (Boss1Enemy.Location.X == 410)
                    {
                        Warning4.Visible = true;
                        Warning5.Visible = true;
                        Warning4.SendToBack();
                        Warning5.SendToBack();
                    }
                    //Create Warnings if x location is >= 795
                    else if (Boss1Enemy.Location.X >= 795)
                    {
                        Warning7.Visible = true;
                        Warning8.Visible = true;

                        Warning7.SendToBack();
                        Warning8.SendToBack();
                    }
                    //Do not allow to generate new action until finished
                    boss1doaction = false;
                    //Stop boss1 bullet during ability
                    ebulletdelay.Enabled = false;
                    //Pause timer
                    boss1attackdelay += 1;
                    //Rush down after a delay
                    if (boss1attackdelay > 10)
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y + 30);
                    }
                    //Boss1 to User collision of tackle ability
                    if (Boss1Enemy.Right >= picUser.Left && Boss1Enemy.Left <= picUser.Right && Boss1Enemy.Bottom >= picUser.Top && Boss1Enemy.Top <= picUser.Bottom && boss1hitonce == 0)
                    {
                        //Only allow user to get hit once
                        boss1hitonce = 1;

                        if (userinvincibility == false)
                        {
                            //Decrease health
                            uhealth -= 75;
                            //Decease score
                            score -= 2000;
                            lblScore.Text = "SCORE: " + score;
                            //Obtain laser charge
                            laservalue += 750;
                            //Sound effect
                            ugethit.Play();
                        }
                        //Stops health from becoming negative 
                        if (uhealth < 0)
                        {
                            uhealth = 0;
                        }
                        //Display health
                        UserHealth.Value = uhealth;
                        //Death if uhealth is equal to 0
                        if (uhealth == 0 && udeadtime == 0)
                        {
                            udeadtime = 1;
                            ulives -= 1;
                           
                        }
                    }
                    //Once Boss1Enemy is off the screen, return to original position
                    if (Boss1Enemy.Location.Y > 1000)
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, -300);
                    }
                    //After a certain time, and boss1 is back in original position, reset variables
                    if (boss1attackdelay >= 20 && Boss1Enemy.Location.Y == 30)
                    {
                        //Disable warnings
                        Warning1.Visible = false;
                        Warning2.Visible = false;
                        Warning3.Visible = false;
                        Warning4.Visible = false;
                        Warning5.Visible = false;
                        Warning6.Visible = false;
                        Warning7.Visible = false;
                        Warning8.Visible = false;
                        //Allow to do another action
                        boss1doaction = true;
                        //Allow for bullet
                        ebulletdelay.Enabled = true;
                        //Reset delay
                        boss1attackdelay = 0;
                        //Only allow some abilities to be used during some intervals
                        boss1nodoubles = 1;
                        //Reset the hit once variable
                        boss1hitonce = 0;
                    }



                }
                #endregion



                #region Boss1Ultimate move
                //Boss1 Ultimate move
                if (boss1decidemove == 9 && boss1ultiact == 0 && boss1nodoubles == 0 || boss1decidemove == 10 && boss1ultiact == 0 && boss1nodoubles == 0)
                {
                    boss1doaction = false;
                    ebulletdelay.Enabled = false;
                    boss1attackdelay = 0;
                    boss1ultileftorright = rnd.Next(1, 3);
                    if (boss1ultileftorright == 1)
                    {
                        Warning3.Visible = true;
                        Warning4.Visible = true;
                        Warning5.Visible = true;
                        Warning6.Visible = true;
                        Warning7.Visible = true;
                        Warning8.Visible = true;

                    }
                    else
                    {
                        Warning1.Visible = true;
                        Warning2.Visible = true;
                        Warning3.Visible = true;
                        Warning4.Visible = true;
                        Warning5.Visible = true;
                        Warning6.Visible = true;
                    }
                    boss1ultiact = 1;

                }

                if (boss1ultiact == 1)
                {
                    boss1attackdelay += 1;

                    Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 5);
                    if (boss1attackdelay > 40)
                    {
                        boss1attackdelay = 0;
                        boss1ultiact = 2;
                        if (boss1ultileftorright == 1)
                        {
                            Boss1Enemy.Location = new Point(1100, 375);
                            Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.boss1Left;

                        }
                        else
                        {
                            Boss1Enemy.Location = new Point(-100, 375);
                            Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.boss1Right;
                        }


                    }


                }
                if (boss1ultiact == 2)
                {
                    if (boss1ultileftorright == 1)
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X - 30, Boss1Enemy.Location.Y);
                        if (Boss1Enemy.Location.X < 370)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 5);
                        }
                        if (Boss1Enemy.Location.X < 350)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 10);
                        }
                        if (Boss1Enemy.Location.X < 310)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 10);
                        }
                        if (Boss1Enemy.Location.X < 230)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 20);
                        }
                    }
                    else
                    {
                        Boss1Enemy.Location = new Point(Boss1Enemy.Location.X + 30, Boss1Enemy.Location.Y);
                        if (Boss1Enemy.Location.X > 440)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 5);
                        }
                        if (Boss1Enemy.Location.X > 460)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 10);
                        }
                        if (Boss1Enemy.Location.X > 500)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 10);
                        }
                        if (Boss1Enemy.Location.X > 580)
                        {
                            Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y - 20);
                        }
                    }

                    if (Boss1Enemy.Right >= picUser.Left && Boss1Enemy.Left <= picUser.Right && Boss1Enemy.Bottom >= picUser.Top && Boss1Enemy.Top <= picUser.Bottom && boss1hitonce == 0)
                    {
                        boss1hitonce = 1;
                        if (userinvincibility == false)
                        {
                            uhealth -= 75;
                            score -= 2000;
                            lblScore.Text = "SCORE: " + score;
                            laservalue += 750;
                            ugethit.Play();
                        }
                        if (uhealth < 0)
                        {
                            uhealth = 0;

                        }
                        UserHealth.Value = uhealth;
                        if (uhealth == 0 && udeadtime == 0)
                        {
                            udeadtime = 1;
                            ulives -= 1;
                        }
                    }


                    if (Boss1Enemy.Location.Y < -150)
                    {
                        boss1ultiact = 3;
                        Boss1Enemy.Location = new Point(410, -200);
                        Warning1.Visible = false;
                        Warning2.Visible = false;
                        Warning3.Visible = false;
                        Warning4.Visible = false;
                        Warning5.Visible = false;
                        Warning6.Visible = false;
                        Warning7.Visible = false;
                        Warning8.Visible = false;
                        Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.boss1;

                    }
                }
                if (boss1ultiact == 3)
                {

                    Boss1Enemy.Location = new Point(Boss1Enemy.Location.X, Boss1Enemy.Location.Y + 5);
                    if (Boss1Enemy.Location.Y >= 30)
                    {

                        boss1ultiact = 0;

                        boss1doaction = true;
                        ebulletdelay.Enabled = true;
                        boss1attackdelay = 0;
                        boss1nodoubles = 1;
                        boss1hitonce = 0;
                    }
                }
                #endregion
            }
              //Boss 2

            if (wavenumber == 16)
            {
                #region deadboss2
                //If boss2 is set as dead
                if (deadboss2 == true)
                {
                    //Disable everything
                    BossTimer.Enabled = false;
                    ebulletdelay.Enabled = false;
                    ebulletdelay2.Enabled = false;
                    ebulletdelay3.Enabled = false;
                    BossExplosion.Enabled = true;
                    #region Disable all Enemies
                    for (int i = 0; i <= numberofnenemies - 1; i++)
                    {
                        
                        ebulletn[i].Visible = false;
                        picNEnemy[i].Visible = false;
                        deadnenemy[i] = true;
                        normalenemy[i] = false;
                        enhealth[i] = 0;
                    }
                    numberofnenemies = 0;
                    for (int i = 0; i <= numberofpenemies - 1; i++)
                    {
                        ebulletp[i].Visible = false;
                        picPEnemy[i].Visible = false;
                        deadpenemy[i] = true;
                        powerenemy[i] = false;
                        ephealth[i] = 0;
                    }
                    numberofpenemies = 0;
                    for (int i = 0; i <= numberofsenemies - 1; i++)
                    {
                        ebullets[i].Visible = false;
                        picSEnemy[i].Visible = false;
                        deadsenemy[i] = true;
                        speedenemy[i] = false;
                        eshealth[i] = 0;
                    }
                    numberofsenemies = 0;
                    for (int i = 0; i <= numberoftenemies - 1; i++)
                    {
                        ebullett[i].Visible = false;
                        picTEnemy[i].Visible = false;
                        deadtenemy[i] = true;
                        tankenemy[i] = false;
                        ethealth[i] = 0;
                    }
                    numberoftenemies = 0;
                    #endregion

                    #region AreaReplacement
                    boss2e1 = false;
                     boss2e2 = false;
                    boss2e3 = false;
                     boss2e4 = false;
                    boss2p1 = false;
                     boss2s1 = false;
                    boss2t1 = false;
                     boss2p2 = false;
                       boss2s2 = false ; 
                             boss2t2 = false;
                     boss2p3 = false;
                    boss2s3 = false;
                       boss2t3 = false;
                       boss2p4 = false;
                    boss2s4 = false; 
                    boss2t4 = false;
                    boss2spawnable = true;
                     boss2useulti = true;
                     boss2useulti2 = true;
                     boss2ultiact = 0;
                    #endregion

                }
                #endregion
                #region MovePEToPlace
                //Spawn Penemy Location 1
                if (boss2p1 == true && picPEnemy[0].Location.X < 70)
                {
                    picPEnemy[0].Location = new Point (picPEnemy[0].Location.X+10,picPEnemy[0].Location.Y);

                }
                //Spawn Penemy Location 2
                if (boss2p2 == true && picPEnemy[1].Location.X > 860)
                {
                    picPEnemy[1].Location = new Point(picPEnemy[1].Location.X - 10, picPEnemy[1].Location.Y);

                }
                //Spawn Penemy Location 3
                if (boss2p3 == true && picPEnemy[2].Location.X < 270)
                {
                    picPEnemy[2].Location = new Point(picPEnemy[2].Location.X + 20, picPEnemy[2].Location.Y);

                }
                //Spawn Penemy Location 4
                if (boss2p4 == true && picPEnemy[3].Location.X > 690)
                {
                    picPEnemy[3].Location = new Point(picPEnemy[3].Location.X - 20, picPEnemy[3].Location.Y);

                }
                #endregion
                #region MoveSEToPlace
                //Speed
                //Spawn senemy Location 1
                if (boss2s1 == true && picSEnemy[0].Location.X < 70)
                {
                    picSEnemy[0].Location = new Point(picSEnemy[0].Location.X + 10, picSEnemy[0].Location.Y);

                }
                //Spawn senemy Location 1
                if (boss2s2 == true && picSEnemy[1].Location.X > 860)
                {
                    picSEnemy[1].Location = new Point(picSEnemy[1].Location.X - 10, picSEnemy[1].Location.Y);

                }
                //Spawn senemy Location 1
                if (boss2s3 == true && picSEnemy[2].Location.X < 270)
                {
                    picSEnemy[2].Location = new Point(picSEnemy[2].Location.X + 20, picSEnemy[2].Location.Y);

                }
                //Spawn senemy Location 1
                if (boss2s4 == true && picSEnemy[3].Location.X > 690)
                {
                    picSEnemy[3].Location = new Point(picSEnemy[3].Location.X - 20, picSEnemy[3].Location.Y);

                }
                #endregion
                #region MoveTEToPlace
                //Tank
                //Spawn Tenemy Location 1
                if (boss2t1 == true && picTEnemy[0].Location.X < 70)
                {
                    picTEnemy[0].Location = new Point(picTEnemy[0].Location.X + 10, picTEnemy[0].Location.Y);

                }
                //Spawn Tenemy Location 2
                if (boss2t2 == true && picTEnemy[1].Location.X > 860)
                {
                    picTEnemy[1].Location = new Point(picTEnemy[1].Location.X - 10, picTEnemy[1].Location.Y);

                }
                //Spawn Tenemy Location 3
                if (boss2t3 == true && picTEnemy[2].Location.X < 270)
                {
                    picTEnemy[2].Location = new Point(picTEnemy[2].Location.X + 20, picTEnemy[2].Location.Y);

                }
                //Spawn Tenemy Location 4
                if (boss2t4 == true && picTEnemy[3].Location.X > 690)
                {
                    picTEnemy[3].Location = new Point(picTEnemy[3].Location.X - 20, picTEnemy[3].Location.Y);

                }
                //If boss has low health, spawn faster!
                if (boss2useulti2 == true && boss2health <= 20)
                {
                    Boss2eSpawn.Interval = 1125;
                }
                #endregion

                #region Activate Ultimate move
                //Only availible for use once
                if (boss2useulti == true && boss2health <= 40)
                {
                    //Disallow for another time
                    boss2useulti = false;
                    //Activate ultimate move
                    boss2ultiact = 1;
                }
             //When ultimate move is activated
                if (boss2ultiact == 1)
                {
                    //Spawn 9 normal enemies
                    numberofnenemies = 9;
                    //Create the 9 normal enemies
                    for (int i = 0; i <= numberofnenemies - 1; i++)
                    {
                        picNEnemy[i].Visible = true;
                        deadnenemy[i] = false;
                        enhealth[i] = 1;
                        normalenemy[i] = true;

                        rndntimer[i] = rnd.Next(1, 4);
                    }
                    picNEnemy[0].Location = new Point(-100, 280);
                    picNEnemy[1].Location = new Point(-100, 280);
                    picNEnemy[2].Location = new Point(-100, 280);
                    picNEnemy[3].Location = new Point(-100, 280);
                    picNEnemy[4].Location = new Point(-100, 280);

                    picNEnemy[5].Location = new Point(1100, 280);
                    picNEnemy[6].Location = new Point(1100, 280);
                    picNEnemy[7].Location = new Point(1100, 280);
                    picNEnemy[8].Location = new Point(1100, 280);
                    //Move the enemies to place
                    boss2ultiact = 2;

                }
                #endregion

                #region Ulti - Move Enemies
                if (boss2ultiact == 2)
                {
 //Move ALL enemies to place
                    if (picNEnemy[0].Location.X < 35)
                    {
                        picNEnemy[0].Location = new Point(picNEnemy[0].Location.X+20, picNEnemy[0].Location.Y);
                    }
                    if (picNEnemy[1].Location.X < 125)
                    {
                        picNEnemy[1].Location = new Point(picNEnemy[1].Location.X + 20, picNEnemy[1].Location.Y);
                    }
                    if (picNEnemy[2].Location.X < 225)
                    {
                        picNEnemy[2].Location = new Point(picNEnemy[2].Location.X + 20, picNEnemy[2].Location.Y);
                    }
                    if (picNEnemy[3].Location.X < 330)
                    {
                        picNEnemy[3].Location = new Point(picNEnemy[3].Location.X + 20, picNEnemy[3].Location.Y);
                    }
                    if (picNEnemy[4].Location.X < 445) //
                    {
                        picNEnemy[4].Location = new Point(picNEnemy[4].Location.X + 20, picNEnemy[4].Location.Y);
                    }
                    if (picNEnemy[5].Location.X > 545) //
                    {
                        picNEnemy[5].Location = new Point(picNEnemy[5].Location.X - 20, picNEnemy[5].Location.Y);
                    }
                    if (picNEnemy[6].Location.X > 650)
                    {
                        picNEnemy[6].Location = new Point(picNEnemy[6].Location.X - 20, picNEnemy[6].Location.Y);
                    }
                    if (picNEnemy[7].Location.X > 785)
                    {
                        picNEnemy[7].Location = new Point(picNEnemy[7].Location.X - 20, picNEnemy[7].Location.Y);
                    }
                    if (picNEnemy[8].Location.X > 885)
                    {
                        picNEnemy[8].Location = new Point(picNEnemy[8].Location.X - 20, picNEnemy[8].Location.Y);
                    }
                }
                #endregion

            }
               //Boss3
            if (wavenumber == 26)
            {            
                #region deadboss3
                //If boss3 is set to dead
                if (deadboss3 == true)
                {
                    //Deactivate everything
                    ebulletdelay.Enabled = false;
                    ebulletdelay2.Enabled = false;
                    ebulletdelay3.Enabled = false;
                    BossTimer.Enabled = false;
                    BossExplosion.Enabled = true;
                    boss3decidemove = 0;
                    boss3decidemove = 0;
                    boss3move = false;
                    boss3Hexplosionact = 0;
                    boss3b2act = 0;
                    boss3bullet2[0].Visible = false;
                    boss3bullet2[1].Visible = false;
                    boss3bulletn[0].Visible = false;
                    boss3bulletn[1].Visible = false;
                    ebulletdelay.Enabled = false;
                    ebulletdelay2.Enabled = false;
                    ebulletdelay3.Enabled = false;
                    boss3BulletExplosion.Visible = false;
                }

#endregion

                #region Boss3DecideMove
                //Random move if Boss3Enemy.Location.X is == 410
                if (Boss3Enemy.Location.X  == 410 && boss3p2 == true)
                {
                    //Chance of doing special ability
                    if (boss3doaction == false)
                    {
                       boss3decidemove = rnd.Next(1, 5);
                       boss3decidemove2 = rnd.Next(1, 4);
                       //Chance of doing special ability 2
                       if (boss3decidemove2 == 3)
                       {
                           boss3decidemove = 0;
                           boss3move = false;
                           ebulletdelay.Enabled = false;
                        
                       }
                    }
                    //Set location
                    boss3p2 = false;
                    boss3p1 = true;
                    boss3p3 = true;
                 
                }
                //Random move if Boss3Enemy.Location.X is <= 0
                if (Boss3Enemy.Left <= 0  && boss3p1 == true)
                {
                    //Chance of doing special ability
                    if (boss3doaction == false)
                    {
                        boss3decidemove = rnd.Next(1, 5);
                  
                    }
                    //Set location
                        boss3p2 = true;
                    boss3p1 = false;
                    boss3p3 = true;
                
                }
                //Random move if Boss3Enemy.Location.X is >= 795
                if (Boss3Enemy.Left >= 795 && boss3p3 == true)
                {
                    //Chance of doing special ability
                    if (boss3doaction == false)
                    {
                        boss3decidemove = rnd.Next(1, 5);
                    }
                    //Set location
                    boss3p2 = true;
                    boss3p1 = true;
                    boss3p3 = false;

                }
                #endregion
                #region Boss3move
                //Moves the boss back and forth if not doing an ability
                if (boss3move == true)
                {
                    //Move left
                    if (boss3leftorright == 1)
                    {
                        Boss3Enemy.Location = new Point(Boss3Enemy.Location.X - 5, Boss3Enemy.Location.Y);
                    }
                        //Move right
                    else if (boss3leftorright == 2)
                    {
                        Boss3Enemy.Location = new Point(Boss3Enemy.Location.X + 5, Boss3Enemy.Location.Y);
                    }
                    //Change left to right
                    if (Boss3Enemy.Left <= 0 && boss3leftorright == 1)
                    {
                        boss3leftorright = 2;
                    }
                        //Change right to left
                    else if (Boss3Enemy.Location.X >= 815 && boss3leftorright == 2)
                    {
                        boss3leftorright = 1;
                    }

                }
                #endregion
                #region Boss3BulletExplosion
                //Bomb explosion when it hits the ground
                //When it is activated
                if (boss3bulletexpact == 1)
                {
                    //Timer increases by 1
                    boss3bulletexpt += 1;
                    //Picture changes according to the timer
                    if (boss3bulletexpt >= 3)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion1;
                    }
                    if (boss3bulletexpt >= 6)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion2;
                    }
                    if (boss3bulletexpt >= 9)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion3;
                    }
                    if (boss3bulletexpt >= 12)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion4;
                    }
                    if (boss3bulletexpt >= 15)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion5;
                    }
                    if (boss3bulletexpt >= 18)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion6;
                    }
                    if (boss3bulletexpt >= 21)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion7;
                    }
                    if (boss3bulletexpt >= 24)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion8;
                    }
                    if (boss3bulletexpt >= 27)
                    {
                        boss3BulletExplosion.Image = Space_Infiltrators.Properties.Resources.Exploion9;
                    }
                    //When the timer is over 30 (finished)
                    if (boss3bulletexpt >= 30)
                    {
                        //Reset explosion
                        boss3BulletExplosion.Visible = false;
                        boss3BulletExplosion.Location = new Point (0,0);
                        boss3bulletexpact = 0;
                        boss3bulletexpt = 0;
                        boss3bulletexphit = false;
                    }
                    //Explosion collision
                    if (boss3bulletexphit == false && boss3bulletexpt == 1 && boss3BulletExplosion.Right-20 >= picUser.Left && boss3BulletExplosion.Left+20 <= picUser.Right)
                    {
                        //Hit only once
                        boss3bulletexphit = true;

                        if (userinvincibility == false)
                        {
                            //Damage user
                            uhealth -= 30;
                            //Decrease score
                            score -= 1000;
                            lblScore.Text = "SCORE: " + score;
                            //Raise laser value
                            laservalue += 200;

                            //If the explosion is huge
                            if (boss3Hexplosionact != 0)
                            {
                                //Deal extra damage
                                uhealth -= 70;
                                //Decrease score like mad
                                score -= 3500;
                                lblScore.Text = "SCORE: " + score;
                            }

                            //Sound effect
                            ugethit.Play();
                        }
                        // Prevent negetive health
                        if (uhealth < 0)
                        {
                            uhealth = 0;
                        }
                        //set health
                        UserHealth.Value = uhealth;
                        //If damage causes user to die
                        if (uhealth == 0 && udeadtime == 0)
                        {
                            //Decrease lives
                            udeadtime = 1;
                            ulives -= 1;
                        }

                    }
                }
                #endregion
                #region Boss3B2
                if (boss3decidemove == 3 && boss3doaction == false || boss3decidemove == 4 && boss3doaction == false)
                   {
                    //Prevents multiple actions
                    boss3doaction = true;
                    //Activate b2
                    boss3b2act = 1;
                    // Create the b2 bombs
                    for (int i = 0; i <= 1; i++)
                    {
                        if (boss3bulletact2[i] == false && deadboss3 == false)
                        {
                            boss3bullet2[0].Location = new Point(Boss3Enemy.Left+50, Boss3Enemy.Bottom - 50);
                            boss3bullet2[1].Location = new Point(Boss3Enemy.Right-50, Boss3Enemy.Bottom - 50);
                            boss3bulletact2[i] = true;

                            boss3bullet2[i].Visible = true;

                        }
                    }

                   }
          
                    if (boss3b2act == 1)
                    {
                        #region MoveB2ToPlace
                        //Move b2 left or right
                        if (boss3bullet2[0].Location.X > 15)
                        {
                            boss3bullet2[0].Location = new Point(boss3bullet2[0].Location.X - 10, boss3bullet2[0].Location.Y);
                        }
                        if (boss3bullet2[0].Location.Y < 280)
                        {
                            boss3bullet2[0].Location = new Point(boss3bullet2[0].Location.X, boss3bullet2[0].Location.Y+10);
                        }
                        if (boss3bullet2[1].Location.X < 915)
                        {
                            boss3bullet2[1].Location = new Point(boss3bullet2[1].Location.X + 10, boss3bullet2[1].Location.Y);
                        }
                        if (boss3bullet2[1].Location.Y < 280)
                        {
                            boss3bullet2[1].Location = new Point(boss3bullet2[1].Location.X, boss3bullet2[1].Location.Y + 10);
                        }
                          #endregion
                       //Increase b2 timer
                            boss3b2timer += 1;
                        //After a certain time
                            if (boss3b2timer >= 50)
                            {
                                //Advance b2
                                boss3b2timer = 0;
                                boss3b2act = 2;
                                #region Boss3B2Target
                                for (int i = 0; i <= 1; i++)
                                {
                                    //Enable bullet
                                        boss3bulletact2[i] = true;
                                   
                                        boss3bullet2[i].Visible = true;

                                    //Calculate x projectile
                                        boss3targety2[i] = (picUser.Top - boss3bullet2[i].Bottom) / 10;

                                        boss3bulletspeed2[i] = (picUser.Left - boss3bullet2[i].Left) / boss3targety2[i];
                                        if (boss3bulletspeed2[i] > 10)
                                        {
                                            boss3bulletspeed2[i] = 10;
                                        }
                                        else if (boss3bulletspeed2[i] < -10)
                                        {
                                            boss3bulletspeed2[i] = -10;
                                        }
                                      
                                  
                                }
                            
                                #endregion


                            }
                        

                    }
                //B2 phase 2
                    if (boss3b2act == 2)
                    {
                        #region Boss3b2Move
                        //If the bullets are enabled
                        if (boss3bulletact2[0] == true)
                        {
                            boss3bullet2[0].Location = new Point(boss3bullet2[0].Location.X + Convert.ToInt32(boss3bulletspeed2[0]-1), boss3bullet2[0].Location.Y + 10);
                        }
                        if (boss3bulletact2[1] == true)
                        {
                            boss3bullet2[1].Location = new Point(boss3bullet2[1].Location.X + Convert.ToInt32(boss3bulletspeed2[1] + 1), boss3bullet2[1].Location.Y + 10);
                        }
                        for (int i = 0; i <= 1; i++)
                        {
             
                          
                            //Enemy collision

                            //If bomb is lower than lowest point
                            if (boss3bullet2[i].Bottom > picUser.Bottom)
                            {
                                //Play sound
                                explosionsound.Play();
                                //Reset explosion
                                boss3BulletExplosion2[i].Location = new Point(boss3bullet2[i].Location.X - 70, boss3bullet2[i].Location.Y - 55);
                                boss3BulletExplosion2[i].Visible = true;
                                boss3bulletexpact2[i] = 1;

                                //Reset bullet
                                boss3bullet2[i].Visible = false;
                                boss3bulletact2[i] = false;
                                boss3bullet2[i].Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);

                            }
                            //Bullet to user collision
                            if (boss3bullet2[i].Top < picUser.Bottom && boss3bullet2[i].Bottom > picUser.Top && boss3bullet2[i].Right > picUser.Left && boss3bullet2[i].Left < picUser.Right && uhealth > 0)
                            {
                                //Reset bullet
                                boss3BulletExplosion2[i].Location = new Point(boss3bullet2[i].Location.X - 70, boss3bullet2[i].Location.Y - 55);
                                boss3BulletExplosion2[i].Visible = true;
                                boss3bulletexpact2[i] = 1;


                                boss3bullet2[i].Visible = false;
                                boss3bulletact2[i] = false;
                                boss3bullet2[i].Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);


                              //Damage user
                                if (userinvincibility == false)
                                {
                                    uhealth -= 40;
                                    laservalue += 200;
                                    ugethit.Play();
                                }
                                if (uhealth < 0)
                                {
                                    uhealth = 0;
                                }
                                //Set user health to be damaged
                                UserHealth.Value = uhealth;
                                //If health is = 0
                                if (uhealth == 0 && udeadtime == 0)
                                {
                                    //Lose a life
                                    udeadtime = 1;
                                    ulives -= 1;
                                }

                            }
                        }
#endregion
                        //After both bombs are deactivated
                        if (boss3bulletact2[0] == false && boss3bulletact2[1] == false)
                        {
                            //Reset b2act
                            boss3b2act = 0;
                            boss3decidemove = 0;
                           boss3doaction = false;
                            boss3b2timer = 0;
                         
                        }
                    }
                    #region Boss3B2Explosion
                    for (int i = 0; i <= 1; i++)
                    {
                        //Bullet explosion for b2
                        if (boss3bulletexpact2[i] == 1)
                        {
                            //Increase b2 timers
                            boss3bulletexpt2[i] += 1;
                            //Change explosion image over time
                            if (boss3bulletexpt2[i] >= 3)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion1;
                            }
                            if (boss3bulletexpt2[i] >= 6)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion2;
                            }
                            if (boss3bulletexpt2[i] >= 9)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion3;
                            }
                            if (boss3bulletexpt2[i] >= 12)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion4;
                            }
                            if (boss3bulletexpt2[i] >= 15)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion5;
                            }
                            if (boss3bulletexpt2[i] >= 18)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion6;
                            }
                            if (boss3bulletexpt2[i] >= 21)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion7;
                            }
                            if (boss3bulletexpt2[i] >= 24)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion8;
                            }
                            if (boss3bulletexpt2[i] >= 27)
                            {
                                boss3BulletExplosion2[i].Image = Space_Infiltrators.Properties.Resources.Exploion9;
                            }
                            //If b2 timer is greater than 30
                            if (boss3bulletexpt2[i] >= 30)
                            {
                                //Reset explosion
                                boss3BulletExplosion2[i].Visible = false;
                                boss3bulletexpact2[i] = 0;
                                boss3BulletExplosion2[i].Location = new Point(0, 0);
                                boss3bulletexpt2[i] = 0;
                                boss3bulletexphit2[i] = false;
                            }
                            //Explosion to user collision
                            if (boss3bulletexphit2[i] == false && boss3bulletexpt2[i] >= 3 && boss3bulletexpt2[i] <= 5 && boss3BulletExplosion2[i].Right - 20 >= picUser.Left && boss3BulletExplosion2[i].Left + 20 <= picUser.Right)
                            {
                                //Hit only once
                                boss3bulletexphit2[i] = true;
                                if (userinvincibility == false)
                                {
                                    //Decrease health
                                    uhealth -= 30;

                                    //Decrease score
                                    score -= 1000;
                                    lblScore.Text = "SCORE: " + score;
                                    laservalue += 200;
                                    //PLay sound effect
                                    ugethit.Play();
                                }
                                //Prevent health from being negative
                                if (uhealth < 0)
                                {
                                    uhealth = 0;

                                }
                                //Set health
                                UserHealth.Value = uhealth;
                                if (uhealth == 0 && udeadtime == 0)
                                {
                                    udeadtime = 1;
                                    ulives -= 1;
                                }

                            }
                        }
                    }
                    #endregion
                #endregion

                    #region Boss3 Huge Explosion
                //If the huge explosion is activated
                    if (boss3decidemove2 == 3 && boss3Hexplosionact == 0)
                    {
                        //Moves boss3 up
                        if (Boss3Enemy.Bottom > 100)
                        {
                            Boss3Enemy.Location = new Point(Boss3Enemy.Location.X, Boss3Enemy.Location.Y - 5);
                        }
                        else
                        {
                            //After, set bullet variables and advance to next phase
                            boss3Hexplosionact = 1;
                            boss3bullet.Size = new Size(20,20);
                            boss3bullet.Location = new Point(Boss3Enemy.Location.X + 75, Boss3Enemy.Bottom);
                            boss3bullet.Visible = true;
                            //Determine if left or right randomly
                           boss3HEleftorright = rnd.Next(1, 3);
                           
                      
                        }
                    }
                //First phase of Hexplosion
                    if (boss3Hexplosionact == 1)
                    {
                    //Increase bullet size to 150 over time
                        if (boss3bullet.Size.Height < 150)
                        {
                            boss3bullet.Size = new Size(boss3bullet.Size.Width + 2, boss3bullet.Size.Height + 2);
                            boss3bullet.Location = new Point(boss3bullet.Location.X - 1, boss3bullet.Location.Y);

                        }
                        else
                        {
                            //When the size is over 150, advance to new phase
                            boss3Hexplosionact = 2;
                        }
                        //After a delay, shows warning signs
                        if (boss3bullet.Size.Height == 130)
                        {
                            //If Left, show left warnings
                            if (boss3HEleftorright == 1) 
                            {
                                Warning1.Visible = true;
                                Warning2.Visible = true;
                                Warning3.Visible = true;
                                Warning4.Visible = true;
                                Warning5.Visible = true;
                            }
                                //If right, show right symbols
                            else if (boss3HEleftorright == 2)
                            {
                                Warning4.Visible = true;
                                Warning5.Visible = true;
                                Warning6.Visible = true;
                                Warning7.Visible = true;
                                Warning8.Visible = true;
                             
                            }
                        }
                    }
                //Boss3Hexplosion phase 2
                    if (boss3Hexplosionact == 2)
                    {
                        //If left, shoot left
                        if (boss3HEleftorright == 1)
                        {
                            boss3bullet.Location = new Point (boss3bullet.Location.X -10, boss3bullet.Location.Y + 20);
                        }
                            //If right, shoot right
                        else if (boss3HEleftorright == 2)
                        {
                            boss3bullet.Location = new Point(boss3bullet.Location.X + 10, boss3bullet.Location.Y + 20);
                        }
                        //If hits ground
                        if (boss3bullet.Bottom > picUser.Bottom)
                        {
                            //Play explosion
                            explosionsound.Play();
                            //Spawn explosion
                            boss3BulletExplosion.Size = new Size(550, 420);
                            boss3BulletExplosion.Location = new Point(boss3bullet.Location.X - 225, boss3bullet.Location.Y - 280);
                            boss3BulletExplosion.Visible = true;
                            boss3bulletexpact = 1;
                            //Reset bullet
                            boss3bullet.Visible = false;
                            boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom);
                            boss3HEleftorright = 3;
                         
                            //Disable warnings
                            Warning1.Visible = false;
                            Warning2.Visible = false;
                            Warning3.Visible = false;
                            Warning4.Visible = false;
                            Warning5.Visible = false;
                            Warning6.Visible = false;
                            Warning7.Visible = false;
                            Warning8.Visible = false;

                            //Repeat Do 4 times
                            if (boss3HEcount < 3)
                            {
                                //Reset Hexplosion variables for repeat
                                boss3bullet.Visible = true;
                                ebulletdelay.Enabled = false;
                                boss3HEcount += 1;
                                boss3Hexplosionact = 1;
                                boss3bullet.Size = new Size(20, 20);
                                boss3bullet.Location = new Point(Boss3Enemy.Location.X + 75, Boss3Enemy.Bottom);
                                   boss3HEleftorright = rnd.Next(1, 3);
                         
                            }
                            else
                            {
                                //Reset Hexplosion
                                boss3Hexplosionact = 3;
                            }

                        }
                    }
                //Phase 3
                    if (boss3Hexplosionact == 3)
                    {
                        //Reset location
                        Boss3Enemy.Location = new Point(Boss3Enemy.Location.X, Boss3Enemy.Location.Y + 5);
                        if (Boss3Enemy.Location.Y >= 30)
                        {
                            //Reset all Hexplosion variables
                            boss3HEcount = 0;
                            boss3Hexplosionact = 0;
                            boss3HEleftorright = 0;
                            boss3bullet.Size = new Size (50,50);
                            boss3BulletExplosion.Size = new Size(195, 170);
                            boss3doaction = false;
                            boss3decidemove2 = 0;
                            ebulletdelay.Enabled = true;
                            boss3move = true;
                        }
                    }

            }
                    #endregion

            if (boss3bnactivate == true && boss3health <= 50)
            {
                boss3bnactivate = false;
                ebulletdelay.Interval = 1500;
                ebulletdelay2.Enabled = true;
                ebulletdelay3.Enabled = true;
            }
                    


        }

           private void Boss2eSpawn_Tick(object sender, EventArgs e)
           {
               //Spawning timer
               //Allow for spawning
               boss2spawnable = true;
               #region SpawnArea1
               //If spawn area is open
               if (boss2e1 == false && boss2spawnable == true)
               {
                   //Spawn a new random enemy
                   boss2e1 = true;
                   boss2randomspawn = rnd.Next (2,5);
                   Boss2eSpawn1();
                   boss2spawnable = false;

               }
               #endregion
               #region SpawnArea2
               //If spawn area is open
               if (boss2e2 == false && boss2spawnable == true)
               {
                   //Spawn a new random enemy
                   boss2e2 = true;
                   boss2randomspawn = rnd.Next (2,5);
                   Boss2eSpawn2();
                   boss2spawnable = false;


               }
               #endregion
               #region SpawnArea3
               //If spawn area is open
               if (boss2e3 == false && boss2spawnable == true)
               {
                   //Spawn a new random enemy
                   boss2e3 = true;
                   boss2randomspawn = rnd.Next (2,5);
                   Boss2eSpawn3();
                   boss2spawnable = false;


               }
               #endregion
               #region SpawnArea4
               //If spawn area is open
               if (boss2e4 == false && boss2spawnable == true)
               {
                   //Spawn a new random enemy
                   boss2e4 = true;
                   boss2randomspawn = rnd.Next (2,5);
                 
                   Boss2eSpawn4();
                   boss2spawnable = false;


               }
               #endregion
               //Ulti
               #region RespawnNormalEnemiesUlti
               //If ultiact is enabled
               if (boss2ultiact == 2)
               {
                   //If the middle enemy is dead
                   if (deadnenemy[4] == true)
                   {
                       //Respawn another other
                       picNEnemy[4].Visible = true;
                       deadnenemy[4] = false;
                       enhealth[4] = 1;
                       normalenemy[4] = true;

                       rndntimer[4] = rnd.Next(1, 4);

                       picNEnemy[4].Location = new Point(-100, 280);
                   }
                   //If the middle enemy is dead
                   if (deadnenemy[5] == true)
                   {
                       //Respawn another other
                       picNEnemy[5].Visible = true;
                       deadnenemy[5] = false;
                       enhealth[5] = 1;
                       normalenemy[5] = true;
                       rndntimer[5] = rnd.Next(1, 4);
                       picNEnemy[5].Location = new Point(1100, 280);
                   }

               }
               #endregion
           }
           private void Boss2eSpawn1()
           {
               #region SpawnPE1
               if (boss2randomspawn == 2)
               {
                   //Spawn P Enemy at location 1
                   picPEnemy[0].Visible = true;
                   deadpenemy[0] = false;
                   ephealth[0] = 2;
                   powerenemy[0] = true;
                   
                   rndptimer[0] = rnd.Next(1, 4);

                   picPEnemy[0].Location = new Point(-100, 50);
                   boss2p1 = true;
               }
               #endregion
               #region SpawnSE1
               if (boss2randomspawn == 3)
               {
                   //Spawn S Enemy at location 1
                   picSEnemy[0].Visible = true;
                   deadsenemy[0] = false;
                   eshealth[0] = 2;
                   speedenemy[0] = true;

                   rndstimer[0] = rnd.Next(1, 4);

                   picSEnemy[0].Location = new Point(-100, 50);
                   boss2s1 = true;
               }
               #endregion
               #region SpawnTE1
               if (boss2randomspawn == 4)
               {
                   //Spawn T enemy at location 1
                   picTEnemy[0].Visible = true;
                   deadtenemy[0] = false;
                   ethealth[0] = 5;
                  tankenemy[0] = true;

                   rndttimer[0] = rnd.Next(1, 4);

                   picTEnemy[0].Location = new Point(-100, 50);
                   boss2t1 = true;
               }
               #endregion
           }
           private void Boss2eSpawn2()
           {
               #region SpawnPE2
               if (boss2randomspawn == 2)
               {
                //Spawn PEnemy at location 2
                   picPEnemy[1].Visible = true;
                   deadpenemy[1] = false;
                   ephealth[1] = 2;
                   powerenemy[1] = true;

                   rndptimer[1] = rnd.Next(1, 4);

                   picPEnemy[1].Location = new Point(1100, 50);
                   boss2p2 = true;
               }
               #endregion
               #region SpawnSE2
               if (boss2randomspawn == 3)
               {
                   //Spawn Senemy at location 2
                   picSEnemy[1].Visible = true;
                   deadsenemy[1] = false;
                   eshealth[1] = 2;
                   speedenemy[1] = true;

                   rndstimer[1] = rnd.Next(1, 4);

                   picSEnemy[1].Location = new Point(1100, 50);
                   boss2s2 = true;
               }
               #endregion
               #region SpawnPT2
               if (boss2randomspawn == 4)
               {
                   //Spawn Tenemy at location 2
                   picTEnemy[1].Visible = true;
                   deadtenemy[1] = false;
                   ethealth[1] = 5;
                   tankenemy[1] = true;

                   rndttimer[1] = rnd.Next(1, 4);

                   picTEnemy[1].Location = new Point(1100, 50);
                   boss2t2 = true;
               }
               #endregion

           }
           private void Boss2eSpawn3()
           {
               #region SpawnPE3
               if (boss2randomspawn == 2)
               {
                   //Spawn Penemy at location 3
                   picPEnemy[2].Visible = true;
                   deadpenemy[2] = false;
                   ephealth[2] = 2;
                   powerenemy[2] = true;

                   rndptimer[2] = rnd.Next(1, 4);
                  
                   picPEnemy[2].Location = new Point(-100, 195);
                   boss2p3 = true;
               }
               #endregion
               #region SpawnSE3
               if (boss2randomspawn == 3)
               {
                   //Spawn Senemy at location 3
                   picSEnemy[2].Visible = true;
                   deadsenemy[2] = false;
                   eshealth[2] = 2;
                   speedenemy[2] = true;

                   rndstimer[2] = rnd.Next(1, 4);

                   picSEnemy[2].Location = new Point(-100, 195);
                   boss2s3 = true;
               }
               #endregion
               #region SpawnTE3
               if (boss2randomspawn == 4)
               {
                   //Spawn Tenemy at location 3
                   picTEnemy[2].Visible = true;
                   deadtenemy[2] = false;
                   ethealth[2] = 5;
                   tankenemy[2] = true;

                   rndttimer[2] = rnd.Next(1, 4);

                   picTEnemy[2].Location = new Point(-100, 155);
                   boss2t3 = true;
               }
               #endregion
           }

           private void Boss2eSpawn4()
           {
               #region SpawnPE4
               if (boss2randomspawn == 2)
               {

                   //Spawn Penemy at location 4
                   picPEnemy[3].Visible = true;
                   deadpenemy[3] = false;
                   ephealth[3] = 2;
                   powerenemy[3] = true;

                   rndptimer[3] = rnd.Next(1, 4);
               
                   picPEnemy[3].Location = new Point(1100, 195);
                   boss2p4 = true;
               }
               #endregion
               #region SpawnSE4
               if (boss2randomspawn == 3)
               {
                   //Spawn Senemy at location 4
                   picSEnemy[3].Visible = true;
                   deadsenemy[3] = false;
                   eshealth[3] = 2;
                   speedenemy[3] = true;

                   rndstimer[3] = rnd.Next(1, 4);

                   picSEnemy[3].Location = new Point(1100, 195);
                   boss2s4 = true;
               }
               #endregion
               #region SpawnTE4
               if (boss2randomspawn == 4)
               {
                   //Spawn Tenemy at location 4
                   picTEnemy[3].Visible = true;
                   deadtenemy[3] = false;
                   ethealth[3] = 5;
                   tankenemy[3] = true;

                   rndttimer[3] = rnd.Next(1, 4);

                   picTEnemy[3].Location = new Point(1100, 155);
                   boss2t4 = true;
               }
               #endregion
           }



           private void BossExplosion_Tick(object sender, EventArgs e)
           {
               #region Boss1 Explosion
               if (wavenumber == 7)
               {
                   //Timer for explosion
                   bossexplosionvalue += 1;
                   if (bossexplosionvalue == 1)
                   {
                       //Play explosion sound
                       explosionsound.Play();

                   }
                   //Change explosion based on explosion timer
                   if (bossexplosionvalue >= 0)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion0;
                   }
                   if (bossexplosionvalue >= 7)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion1;
                   }
                   if (bossexplosionvalue >= 14)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion2;
                   }
                   if (bossexplosionvalue >= 21)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion3;
                   }
                   if (bossexplosionvalue >= 28)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion4;
                   }
                   if (bossexplosionvalue >= 35)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion5;
                   }
                   if (bossexplosionvalue >= 42)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion6;
                   }
                   if (bossexplosionvalue >= 49)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion7;
                   }
                   if (bossexplosionvalue >= 56)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion8;
                   }
                   if (bossexplosionvalue >= 63)
                   {
                       Boss1Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion9;
                   }
                   if (bossexplosionvalue >= 70)
                   {
                       Boss1Enemy.Image = null;
                   }
                   //After explosion timer > 80
                   if (bossexplosionvalue >= 80)
                   {
                       //Reset everything
                       picUser.Location = new Point(469, 503);
                       laservaluedivider = 8;
                       BossHP.Visible = false;
                       EpicText.Visible = false;
                       Boss1Enemy.Visible = false;
                       countdead = 0;
                       bossexplosionvalue = 0;
                       BossExplosion.Enabled = false;
                       ebulletdelay.Interval = 2500;
                       ebulletdelay.Enabled = false;
                       ebulletdelay2.Enabled = false;
                       ebulletdelay3.Enabled = false;
                       boss1health = 50;
                     
                       BossHP.Value = 50;
                       //Stop music
                       musicvalue = 0;
                       wplayer.controls.stop();
                       wplayer2.controls.stop();
                       MusicTimer.Enabled = false;
                       //Change forms
                       this.Hide();
                       PickStage frmpick = new PickStage();
             
                       frmpick.Show();
                       //Reset lives
                       ulives = 3;
                       PicLive1.Visible = true;
                       PicLive2.Visible = true;
                       PicLive3.Visible = true;

                   }
               }

               #endregion

               #region Boss2Explosion
               if (wavenumber == 16)
               {
                   //Timer for explosion
                   bossexplosionvalue += 1;

                   if (bossexplosionvalue == 1)
                   {
                       //Play sound
                       explosionsound.Play();
                       //Make enemies = 0
                       numberofnenemies = 0;
                       numberofpenemies = 0;
                       numberofsenemies = 0;
                       numberoftenemies = 0;
                   }
                   //Change explosion image according to timer value
                   if (bossexplosionvalue >= 0)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion0;
                   }
                   if (bossexplosionvalue >= 7)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion1;
                   }
                   if (bossexplosionvalue >= 14)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion2;
                   }
                   if (bossexplosionvalue >= 21)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion3;
                   }
                   if (bossexplosionvalue >= 28)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion4;
                   }
                   if (bossexplosionvalue >= 35)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion5;
                   }
                   if (bossexplosionvalue >= 42)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion6;
                   }
                   if (bossexplosionvalue >= 49)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion7;
                   }
                   if (bossexplosionvalue >= 56)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion8;
                   }
                   if (bossexplosionvalue >= 63)
                   {
                       Boss2Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion9;
                   }
                   if (bossexplosionvalue >= 70)
                   {
                       Boss2Enemy.Image = null;
                   }
                   //If value is over 80
                   if (bossexplosionvalue >= 80)
                   {
                       //Reset everything
                       numberofnenemies = 0;
                       numberofpenemies = 0;
                       numberofsenemies = 0;
                       numberoftenemies = 0;

                       picUser.Location = new Point(469, 503);
                       laservaluedivider = 8;
                       BossHP.Visible = false;
                       EpicText.Visible = false;
                       Boss2Enemy.Visible = false;
                       countdead = 0;
                       bossexplosionvalue = 0;
                       BossExplosion.Enabled = false;
                       ebulletdelay.Interval = 2500;
                       ebulletdelay.Enabled = false;
                       ebulletdelay2.Enabled = false;
                       ebulletdelay3.Enabled = false;
                       boss2health = 80;
                    
                       BossHP.Value = 80;
                       //Disable music
                       MusicTimer.Enabled = false;
                       musicvalue = 0;
                       wplayer.controls.stop();
                       wplayer2.controls.stop();
                       //Change form
                       this.Hide();
                       PickStage frmpick = new PickStage();
                      
                       frmpick.Show();
                       //Lives
                       ulives = 3;
                       PicLive1.Visible = true;
                       PicLive2.Visible = true;
                       PicLive3.Visible = true;
                   }
               }
               #endregion

               #region Boss3Explosion
               if (wavenumber == 26)
               {
                   //Explosion timer
                   bossexplosionvalue += 1;
                   if (bossexplosionvalue == 1)
                   {
                       //Play explosion sound
                       explosionsound.Play();
                   }
                   //Change image according to timer
                   if (bossexplosionvalue >= 0)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion0;
                   }
                   if (bossexplosionvalue >= 7)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion1;
                   }
                   if (bossexplosionvalue >= 14)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion2;
                   }
                   if (bossexplosionvalue >= 21)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion3;
                   }
                   if (bossexplosionvalue >= 28)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion4;
                   }
                   if (bossexplosionvalue >= 35)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion5;
                   }
                   if (bossexplosionvalue >= 42)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion6;
                   }
                   if (bossexplosionvalue >= 49)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion7;
                   }
                   if (bossexplosionvalue >= 56)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion8;
                   }
                   if (bossexplosionvalue >= 63)
                   {
                       Boss3Enemy.Image = Space_Infiltrators.Properties.Resources.Exploion9;
                   }
                   if (bossexplosionvalue >= 70)
                   {
                       Boss3Enemy.Image = null;
                   }
                   //If explosion value is greater than 80
                   if (bossexplosionvalue >= 80)
                   {
                       laservaluedivider = 8;
                       //Reset everything
                       picUser.Location = new Point(469, 503);
                       BossHP.Visible = false;
                       EpicText.Visible = false;
                       Boss3Enemy.Visible = false;
                       countdead = 0;
                       bossexplosionvalue = 0;
                       BossExplosion.Enabled = false;
                       ebulletdelay.Interval = 2500;
                       ebulletdelay.Enabled = false;
                       ebulletdelay2.Enabled = false;
                       MusicTimer.Enabled = false;
                       ebulletdelay3.Enabled = false;
                       boss3health = 125;
                       BossHP.Value = 125;
                       numberofnenemies = 0;
                       numberofpenemies = 0;
                       numberofsenemies = 0;
                       numberoftenemies = 0;
                     //Change form to you win!
                       YouWin frmwin = new YouWin();
                       musicvalue = 0;
                       this.Hide();
                       boss3bnactivate = true;
                      //Reset lives
                       ulives = 3;
                       PicLive1.Visible = true;
                       PicLive2.Visible = true;
                       PicLive3.Visible = true;
                  
                       wplayer.controls.stop();
                       wplayer2.controls.stop();
                       frmwin.Show();


                   }
               }
               #endregion

           }

        private void ebulletdelay_Tick(object sender, EventArgs e)
        {
            #region EnemyNormalBulletDelay1
            for (int i = 0; i <= numberofnenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletnact[i] == false && picUser.Left - picNEnemy[i].Left < 400) && deadnenemy[i] == false && picUser.Left - picNEnemy[i].Left > -400 && rndntimer[i] == 1)
                {
                    //Set bullet
                    ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);
                    ebulletnact[i] = true;
                    ebullettmr.Enabled = true;
                    //Bullet angle calculations
                    ebulletn[i].Visible = true;
                 
                    etargetny[i] = (picUser.Top - ebulletn[i].Bottom) / 10;

                    ebulletnspeed[i] = (picUser.Left - ebulletn[i].Left) / etargetny[i];
                    if (ebulletnspeed[i] > 10)
                    {
                        ebulletnspeed[i] = 10;
                    }
                    else if (ebulletnspeed[i] < -10)
                    {
                        ebulletnspeed[i] = -10;
                    }
                }
            }
            #endregion
            //P Enemy
            #region EnemyPowerBulletDelay1
            for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //If ebullet not currently active and user is in range
                    if ((ebulletpact[i] == false && picUser.Left - picPEnemy[i].Left < 500) && deadpenemy[i] == false && picUser.Left - picPEnemy[i].Left > -500 && rndptimer[i] == 1)
                    {
                        //Set bullet
                        ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);
                        ebulletpact[i] = true;
                        ebullettmr.Enabled = true;

                        ebulletp[i].Visible = true;
                        //Bullet angle calculations
                        etargetpy[i] = (picUser.Top - ebulletp[i].Bottom) / 10;
                      
                        ebulletpspeed[i] = (picUser.Left - ebulletp[i].Left) / etargetpy[i];
                        if (ebulletpspeed[i] > 10)
                        {
                            ebulletpspeed[i] = 10;
                        }
                        else if (ebulletpspeed[i] < -10)
                        {
                            ebulletpspeed[i] = -10;
                        }
                   
                }
                }
            #endregion

            #region EnemySpeedBulletDelay1
            for (int i = 0; i <= numberofsenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletsact[i] == false && picUser.Left - picSEnemy[i].Left < 500) && deadsenemy[i] == false && picUser.Left - picSEnemy[i].Left > -500 && rndstimer[i] == 1)
                {
                    //Set bullet
                    ebullets[i].Location = new Point(picSEnemy[i].Location.X + 8, picSEnemy[i].Bottom);
                    ebulletsact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullets[i].Visible = true;
                    //Bullet angle calculations
                    etargetsy[i] = (picUser.Top - ebullets[i].Bottom) / 15;
                 
                    ebulletsspeed[i] = (picUser.Left - ebullets[i].Left) / etargetsy[i];
                    if (ebulletsspeed[i] > 15)
                    {
                        ebulletsspeed[i] = 15;
                    }
                    else if (ebulletsspeed[i] < -15)
                    {
                        ebulletsspeed[i] = -15;
                    }

                }
            }
            #endregion

            #region EnemyTankBulletDelay1
            for (int i = 0; i <= numberoftenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebullettact[i] == false && picUser.Left - picTEnemy[i].Left < 500) && deadtenemy[i] == false && picUser.Left - picTEnemy[i].Left > -500 && rndttimer[i] == 1)
                {
                    //Set bullet
                    ebullett[i].Location = new Point(picTEnemy[i].Location.X + 8, picTEnemy[i].Bottom);
                    ebullettact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullett[i].Visible = true;
                    //Bullet angle calculations
                    etargetty[i] = (picUser.Top - ebullett[i].Bottom) / 10;
                   
                    ebullettspeed[i] = (picUser.Left - ebullett[i].Left) / etargetty[i];
                    if (ebullettspeed[i] > 10)
                    {
                        ebullettspeed[i] = 10;
                    }
                    else if (ebullettspeed[i] < -10)
                    {
                        ebullettspeed[i] = -10;
                    }

                }
            }
            #endregion

            #region EnemyBoss1BulletDelay
            if (wavenumber == 7)
            {
                //If ebullet not currently active
                if (boss1bulletact == false && deadboss1 == false )
                {
                   boss1bullet.Location = new Point(Boss1Enemy.Location.X + 70, Boss1Enemy.Bottom-30);
                    boss1bulletact = true;
                    ebullettmr.Enabled = true;

                    boss1bullet.Visible = true;
                    //Bullet angle calculations
                    boss1targety = (picUser.Top - boss1bullet.Bottom) / 10;
                 
                    boss1bulletspeed = (picUser.Left - boss1bullet.Left) / boss1targety;
                    if (boss1bulletspeed > 10)
                    {
                        boss1bulletspeed = 10;
                    }
                    else if (boss1bulletspeed < -10)
                    {
                        boss1bulletspeed = -10;
                    }

                }
            }
            #endregion
            #region EnemyBoss2BulletDelay
            if (wavenumber == 16)
            {
                //If ebullet not currently active
                if (boss2bulletact == false && deadboss2 == false)
                {
                   
          

                    boss2bullet.Location = new Point(Boss2Enemy.Location.X + 70, Boss2Enemy.Bottom - 30);
                    boss2bulletact = true;
                    ebullettmr.Enabled = true;

                    boss2bullet.Visible = true;

                    boss2targety = (picUser.Top - boss2bullet.Bottom) / 10;

                    boss2bulletspeed = (picUser.Left - boss2bullet.Left) / boss2targety;
                    if (boss2bulletspeed > 10)
                    {
                        boss2bulletspeed = 10;
                    }
                    else if (boss2bulletspeed < -10)
                    {
                        boss2bulletspeed = -10;
                    }

                }
            }
            #endregion
            #region EnemyBoss3BulletDelay
            if (wavenumber == 26 && boss3Hexplosionact == 0)
            {
                //If ebullet not currently active
                if (boss3bulletact == false && deadboss3 == false)
                {
                    boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);
                    boss3bulletact = true;
                    ebullettmr.Enabled = true;

                    boss3bullet.Visible = true;
                    //Bullet angle calculations
                    boss3targety = (picUser.Top - boss3bullet.Bottom) / 10;

                    boss3bulletspeed = (picUser.Left - boss3bullet.Left) / boss3targety;
                    if (boss3bulletspeed > 10)
                    {
                        boss3bulletspeed = 10;
                    }
                    else if (boss3bulletspeed < -10)
                    {
                        boss3bulletspeed = -10;
                    }

                }
               

            }
            #endregion

        }

        private void ebulletdelay2_Tick(object sender, EventArgs e)
        {
            #region EnemyNormalBulletDelay2
            for (int i = 0; i <= numberofnenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletnact[i] == false && picUser.Left - picNEnemy[i].Left < 400) && deadnenemy[i] == false && picUser.Left - picNEnemy[i].Left > -400 && rndntimer[i] == 2)
                {
                    //Set bullet
                    ebulletn[i].Visible = true;
                    ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);
                    ebulletnact[i] = true;
                    ebullettmr.Enabled = true;


                    //Bullet angle calculations
                    etargetny[i] = (picUser.Top - ebulletn[i].Bottom) / 10;

                    ebulletnspeed[i] = (picUser.Left - ebulletn[i].Left) / etargetny[i];
                    if (ebulletnspeed[i] > 10)
                    {
                        ebulletnspeed[i] = 10;
                    }
                    else if (ebulletnspeed[i] < -10)
                    {
                        ebulletnspeed[i] = -10;
                    }
                }
            }
            #endregion
            //P Enemy
            #region EnemyPowerBulletDelay2
            for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //If ebullet not currently active and user is in range
                    if ((ebulletpact[i] == false && picUser.Left - picPEnemy[i].Left < 450) && deadpenemy[i] == false && picUser.Left - picPEnemy[i].Left > -450 && rndptimer[i] == 2)
                    {
                        //Set bullet
                        ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);
                        ebulletpact[i] = true;
                        ebullettmr.Enabled = true;

                        ebulletp[i].Visible = true;
                        //Bullet angle calculations
                        etargetpy[i] = (picUser.Top - ebulletp[i].Bottom) / 10;
                
                        ebulletpspeed[i] = (picUser.Left - ebulletp[i].Left) / etargetpy[i];
                        if (ebulletpspeed[i] > 10)
                        {
                            ebulletpspeed[i] = 10;
                        }
                        else if (ebulletpspeed[i] < -10)
                        {
                            ebulletpspeed[i] = -10;
                        }
                    }

                }
            #endregion

            #region EnemySpeedBulletDelay2
            for (int i = 0; i <= numberofsenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletsact[i] == false && picUser.Left - picSEnemy[i].Left < 500) && deadsenemy[i] == false && picUser.Left - picSEnemy[i].Left > -500 && rndstimer[i] == 2)
                {
                    //Set bullet
                    ebullets[i].Location = new Point(picSEnemy[i].Location.X + 8, picSEnemy[i].Bottom);
                    ebulletsact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullets[i].Visible = true;
                    //Bullet angle calculations
                    etargetsy[i] = (picUser.Top - ebullets[i].Bottom) / 15;

                    ebulletsspeed[i] = (picUser.Left - ebullets[i].Left) / etargetsy[i];
                    if (ebulletsspeed[i] > 15)
                    {
                        ebulletsspeed[i] = 15;
                    }
                    else if (ebulletsspeed[i] < -15)
                    {
                        ebulletsspeed[i] = -15;
                    }

                }
            }
            #endregion

            #region EnemyTankBulletDelay2
            for (int i = 0; i <= numberoftenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebullettact[i] == false && picUser.Left - picTEnemy[i].Left < 450) && deadtenemy[i] == false && picUser.Left - picTEnemy[i].Left > -450 && rndttimer[i] == 2)
                {
                    //Set bullet
                    ebullett[i].Location = new Point(picTEnemy[i].Location.X + 8, picTEnemy[i].Bottom);
                    ebullettact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullett[i].Visible = true;
                    //Bullet angle calculations
                    etargetty[i] = (picUser.Top - ebullett[i].Bottom) / 10;

                    ebullettspeed[i] = (picUser.Left - ebullett[i].Left) / etargetty[i];
                    if (ebullettspeed[i] > 10)
                    {
                        ebullettspeed[i] = 10;
                    }
                    else if (ebullettspeed[i] < -10)
                    {
                        ebullettspeed[i] = -10;
                    }

                }
            }
            #endregion
            #region Boss3Extra
            //Extra  bullet when low health
            if (wavenumber == 26 && boss3bnactivate == false)
            {
                //If bullet is not already active
                if (boss3bulletactn[0] == false && deadboss3 == false)
                {
                    //Set bullet location
                    boss3bulletn[0].Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);
                    boss3bulletactn[0] = true;

                    boss3bulletn[0].Visible = true;
                    //Calculate bullet angle
                    boss3targetyn[0] = (picUser.Top - boss3bulletn[0].Bottom) / 10;

                    boss3bulletspeedn[0] = (picUser.Left - boss3bulletn[0].Left) / boss3targetyn[0];
                    if (boss3bulletspeedn[0] > 10)
                    {
                        boss3bulletspeedn[0] = 10;
                    }
                    else if (boss3bulletspeedn[0] < -10)
                    {
                        boss3bulletspeedn[0] = -10;
                    }

                }
            }
            #endregion
        }

        private void ebulletdelay3_Tick(object sender, EventArgs e)
        {
            #region EnemyNormalBulletDelay3
            for (int i = 0; i <= numberofnenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletnact[i] == false && picUser.Left - picNEnemy[i].Left < 400) && deadnenemy[i] == false && picUser.Left - picNEnemy[i].Left > -400 && rndntimer[i] == 3)
                {
                    //Set bullet
                    ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);
                    ebulletnact[i] = true;
                    ebullettmr.Enabled = true;

                    ebulletn[i].Visible = true;
                    //Bullet angle calculations
                    etargetny[i] = (picUser.Top - ebulletn[i].Bottom) / 10;

                    ebulletnspeed[i] = (picUser.Left - ebulletn[i].Left) / etargetny[i];
                    if (ebulletnspeed[i] > 10)
                    {
                        ebulletnspeed[i] = 10;
                    }
                    else if (ebulletnspeed[i] < -10)
                    {
                        ebulletnspeed[i] = -10;
                    }
                }
            }
            #endregion

            //P Enemy
            #region EnemyPowerBulletDelay3
            for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //If ebullet not currently active and user is in range
                    if ((ebulletpact[i] == false && picUser.Left - picPEnemy[i].Left < 450) && deadpenemy[i] == false && picUser.Left - picPEnemy[i].Left > -450 && rndptimer[i] == 3)
                    {
                        //Set bullet
                        ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);
                        ebulletpact[i] = true;
                        ebullettmr.Enabled = true;

                        ebulletp[i].Visible = true;
                        //Bullet angle calculations
                        etargetpy[i] = (picUser.Top - ebulletp[i].Bottom) / 10;

                        ebulletpspeed[i] = (picUser.Left - ebulletp[i].Left) / etargetpy[i];
                        if (ebulletpspeed[i] > 10)
                        {
                            ebulletpspeed[i] = 10;
                        }
                        else if (ebulletpspeed[i] < -10)
                        {
                            ebulletpspeed[i] = -10;
                        }
                    }

                }
            #endregion

            #region EnemySpeedBulletDelay3
            for (int i = 0; i <= numberofsenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebulletsact[i] == false && picUser.Left - picSEnemy[i].Left < 500) && deadsenemy[i] == false && picUser.Left - picSEnemy[i].Left > -500 && rndstimer[i] == 3)
                {
                    //Set bullet
                    ebullets[i].Location = new Point(picSEnemy[i].Location.X + 8, picSEnemy[i].Bottom);
                    ebulletsact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullets[i].Visible = true;
                    //Bullet angle calculations
                    etargetsy[i] = (picUser.Top - ebullets[i].Bottom) / 15;

                    ebulletsspeed[i] = (picUser.Left - ebullets[i].Left) / etargetsy[i];
                    if (ebulletsspeed[i] > 15)
                    {
                        ebulletsspeed[i] = 15;
                    }
                    else if (ebulletsspeed[i] < -20)
                    {
                        ebulletsspeed[i] = -15;
                    }

                }
            }
            #endregion

            #region EnemyTankBulletDelay3
            for (int i = 0; i <= numberoftenemies - 1; i++)
            {
                //If ebullet not currently active and user is in range
                if ((ebullettact[i] == false && picUser.Left - picTEnemy[i].Left < 450) && deadtenemy[i] == false && picUser.Left - picTEnemy[i].Left > -450 && rndttimer[i] == 3)
                {
                    //Set bullet
                    ebullett[i].Location = new Point(picTEnemy[i].Location.X + 8, picTEnemy[i].Bottom);
                    ebullettact[i] = true;
                    ebullettmr.Enabled = true;

                    ebullett[i].Visible = true;
                    //Bullet angle calculations
                    etargetty[i] = (picUser.Top - ebullett[i].Bottom) / 10;

                    ebullettspeed[i] = (picUser.Left - ebullett[i].Left) / etargetty[i];
                    if (ebullettspeed[i] > 10)
                    {
                        ebullettspeed[i] = 10;
                    }
                    else if (ebullettspeed[i] < -10)
                    {
                        ebullettspeed[i] = -10;
                    }

                }
            }
            #endregion

            #region Boss3Extra
            //Extra  bullet when low health
            if (wavenumber == 26 && boss3bnactivate == false)
            {
                if (boss3bulletactn[1] == false && deadboss3 == false)
                {
                    //Set bullet location
                    boss3bulletn[1].Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);
                    boss3bulletactn[1] = true;
                    boss3bulletn[1].Visible = true;
                    //Calculate angle
                    boss3targetyn[1] = (picUser.Top - boss3bulletn[1].Bottom) / 10;

                    boss3bulletspeedn[1] = (picUser.Left - boss3bulletn[1].Left) / boss3targetyn[1];
                    if (boss3bulletspeedn[1] > 10)
                    {
                        boss3bulletspeedn[1] = 10;
                    }
                    else if (boss3bulletspeedn[1] < -10)
                    {
                        boss3bulletspeedn[1] = -10;
                    }

                }
            }
            #endregion

        }

        private void ebullettmr_Tick(object sender, EventArgs e)
        {
            #region EnemyNormalBulletMove
            for (int i = 0; i <= numberofnenemies - 1; i++)
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (ebulletnact[i] == true)
                {
                    ebulletn[i].Location = new Point(ebulletn[i].Location.X + Convert.ToInt32(ebulletnspeed[i]), ebulletn[i].Location.Y + 10);
                }

                //If enemy bullet is below the bottom
                    if (ebulletn[i].Top > picUser.Bottom)
                    {
                        //Reset bullet
                        ebulletn[i].Visible = false;
                        ebulletnact[i] = false;
                        ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);
                    }
                        //If bullet hits user
                    else if (ebulletn[i].Top < picUser.Bottom && ebulletn[i].Bottom > picUser.Top && ebulletn[i].Right > picUser.Left && ebulletn[i].Left < picUser.Right && udeadtime == 0 && uhealth > 0)
                    {
                        //Rest
                        ebulletn[i].Visible = false;
                        ebulletnact[i] = false;
                        ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);

                        if (userinvincibility == false)
                        {
                            //Decrease health
                            uhealth -= 15;
                            //Decrease score
                            score -= 500;
                            lblScore.Text = "SCORE: " + score;
                            //Weaker if spawned by boss2
                            if (wavenumber == 16)
                            {
                                uhealth += 5;
                            }
                            //Increase laser value
                            laservalue += 250;
                            //Play sound effect
                            ugethit.Play();
                        }
                        if (uhealth < 0 && udeadtime == 0 )
                        {
                            uhealth = 0;
                        }
                        //Set health
                        UserHealth.Value = uhealth;
                        if (uhealth == 0 && udeadtime == 0)
                        {
                            //Lose life
                            ulives -= 1;
                            udeadtime = 1;
                        }
                    }

            }
            #endregion
            //POWER
            #region EnemyPowerBulletMove
            for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //If bulllet is enabled, move bullet according to angle in ebulletdelay
                    if (ebulletpact[i] == true)
                    {
                        ebulletp[i].Location = new Point(ebulletp[i].Location.X + Convert.ToInt32(ebulletpspeed[i]), ebulletp[i].Location.Y + 10);
                    }

                    //If enemy bullet is below the bottom
                    if (ebulletp[i].Top > picUser.Bottom)
                    {
                        //Reset bullet
                        ebulletp[i].Visible = false;
                        ebulletpact[i] = false;
                        ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);
                    }
                    //If bullet hits user
                    else if (ebulletp[i].Top < picUser.Bottom && ebulletp[i].Bottom > picUser.Top && ebulletp[i].Right > picUser.Left && ebulletp[i].Left < picUser.Right && uhealth > 0)
                    {
                        //Reset bullet
                        ebulletp[i].Visible = false;
                        ebulletpact[i] = false;
                        ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);

                        /////////////////
                        if (userinvincibility == false)
                        {
                            //Lower health
                            uhealth -= 30;
                            //Decrease score
                            score -= 1000;
                            lblScore.Text = "SCORE: " + score;
                            //Increase laser value
                            laservalue += 500;
                            //Play sound effect
                            ugethit.Play();

                        }
                        if (uhealth < 0)
                        {
                            uhealth = 0;
                        }
                        //Set health
                        UserHealth.Value = uhealth;
                        if (uhealth == 0 && udeadtime == 0)
                        {
                            //Lose life
                            ulives -= 1;
                            udeadtime = 1;
                        }    
           
                }

                }

         
            #endregion

            #region EnemySpeedBulletMove
            for (int i = 0; i <= numberofsenemies - 1; i++)
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (ebulletsact[i] == true)
                {
                    ebullets[i].Location = new Point(ebullets[i].Location.X + Convert.ToInt32(ebulletsspeed[i]), ebullets[i].Location.Y + 15);
                }

                //If enemy bullet is below the bottom
                if (ebullets[i].Top > picUser.Bottom)
                {
                    //Reset bullet
                    ebullets[i].Visible = false;
                    ebulletsact[i] = false;
                    ebullets[i].Location = new Point(picSEnemy[i].Location.X + 8, picSEnemy[i].Bottom);
                }
                //If bullet hits user
                else if (ebullets[i].Top < picUser.Bottom && ebullets[i].Bottom > picUser.Top && ebullets[i].Right > picUser.Left && ebullets[i].Left < picUser.Right && uhealth > 0)
                {
                    //Reset bullet
                    ebullets[i].Visible = false;
                    ebulletsact[i] = false;
                    ebullets[i].Location = new Point(picSEnemy[i].Location.X + 8, picSEnemy[i].Bottom);

                    /////////////////
                    if (userinvincibility == false)
                    {
                        //Decrease health
                        uhealth -= 15;
                        //Decrease score
                        score -= 500;
                        lblScore.Text = "SCORE: " + score;
                        //Easier if spawned by boss2
                        if (wavenumber == 16)
                        {
                            uhealth += 5;
                        }
                        //Increase laservalue
                        laservalue += 200;
                        //Play sound effect
                        ugethit.Play();
                    }
                    if (uhealth < 0)
                    {
                        uhealth = 0;
                    }
                    //Set health
                    UserHealth.Value = uhealth;
                    if (uhealth == 0 && udeadtime == 0)
                    {
                        //Lose life
                        ulives -= 1;
                        udeadtime = 1;
                    }




                }

            }
            #endregion
            #region EnemyTankBulletMove
            for (int i = 0; i <= numberoftenemies - 1; i++)
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (ebullettact[i] == true)
                {
                    ebullett[i].Location = new Point(ebullett[i].Location.X + Convert.ToInt32(ebullettspeed[i]), ebullett[i].Location.Y + 10);
                }

                //If enemy bullet is below the bottom
                if (ebullett[i].Top > picUser.Bottom)
                {
                    //Reset bullet
                    ebullett[i].Visible = false;
                    ebullettact[i] = false;
                    ebullett[i].Location = new Point(picTEnemy[i].Location.X + 8, picTEnemy[i].Bottom);
                }
                //If bullet hits user
                else if (ebullett[i].Top < picUser.Bottom && ebullett[i].Bottom > picUser.Top && ebullett[i].Right > picUser.Left && ebullett[i].Left < picUser.Right && udeadtime == 0 && uhealth > 0)
                {
                    //Reset bullet
                    ebullett[i].Visible = false;
                    ebullettact[i] = false;
                    ebullett[i].Location = new Point(picTEnemy[i].Location.X + 8, picTEnemy[i].Bottom);


                    /////////////////
                    if (userinvincibility == false)
                    {
                        //Decrease health
                        uhealth -= 25;
                        //Decrease score
                        score -= 750;
                        lblScore.Text = "SCORE: " + score;
                        //Easier if spawned by boss2
                        if (wavenumber == 16)
                        {
                            uhealth += 5;
                        }
                        //Increase laser value
                        laservalue += 250;
                        //Play sound effect
                        ugethit.Play();
                    }
                    if (uhealth < 0 && udeadtime == 0)
                    {
                        uhealth = 0;
                    }
                    //Set health
                    UserHealth.Value = uhealth;
                    if (uhealth == 0 && udeadtime == 0)
                    {
                        //Lose life
                        ulives -= 1;
                        udeadtime = 1;
                    }

                }

            }

#endregion
            #region Boss1BulletMove
            if (wavenumber == 7)
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (boss1bulletact == true)
                {
                    boss1bullet.Location = new Point(boss1bullet.Location.X + Convert.ToInt32(boss1bulletspeed), boss1bullet.Location.Y + 10);
                }
                //If enemy bullet is below the bottom
                if (boss1bullet.Top > picUser.Bottom)
                {
                    //Reset bullet
                    boss1bullet.Visible = false;
                    boss1bulletact = false;
                    boss1bullet.Location = new Point(Boss1Enemy.Location.X + 70, Boss1Enemy.Bottom-30);
                }
                //If bullet hits user
                else if (boss1bullet.Top < picUser.Bottom && boss1bullet.Bottom > picUser.Top && boss1bullet.Right > picUser.Left && boss1bullet.Left < picUser.Right && uhealth > 0)
                {
                    //Reset bullet
                    boss1bullet.Visible = false;
                    boss1bulletact = false;
                    boss1bullet.Location = new Point(Boss1Enemy.Location.X + 70, Boss1Enemy.Bottom-30);


                    /////////////////
                    if (userinvincibility == false)
                    {
                        //Decrease health
                        uhealth -= 50;
                        //Decrease score
                        score -= 1500;
                        lblScore.Text = "SCORE: " + score;
                        //Increase laser value
                        laservalue += 500;
                        //Play sound
                        ugethit.Play();
                    }
                    if (uhealth < 0)
                    {
                        uhealth = 0;

                    }
                    //Set score
                    UserHealth.Value = uhealth;
                    if (uhealth == 0 && udeadtime == 0)
                    {
                        //Lower life
                        ulives -= 1;
                        udeadtime = 1;
                    }

                }

            }
            #endregion
            #region Boss2BulletMove
            if (wavenumber == 16)
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (boss2bulletact == true)
                {
                    boss2bullet.Location = new Point(boss2bullet.Location.X + Convert.ToInt32(boss2bulletspeed), boss2bullet.Location.Y + 10);
                }

                //If enemy bullet is below the bottom
                if (boss2bullet.Top > picUser.Bottom)
                {
                    //Reset bullet
                    boss2bullet.Visible = false;
                    boss2bulletact = false;
                    boss2bullet.Location = new Point(Boss2Enemy.Location.X + 70, Boss2Enemy.Bottom - 30);
                }
                //If bullet hits user
                else if (boss2bullet.Top < picUser.Bottom && boss2bullet.Bottom > picUser.Top && boss2bullet.Right > picUser.Left && boss2bullet.Left < picUser.Right && uhealth > 0)
                {
                    //Reset bullet
                    boss2bullet.Visible = false;
                    boss2bulletact = false;
                    boss2bullet.Location = new Point(Boss2Enemy.Location.X + 70, Boss2Enemy.Bottom - 30);


                    /////////////////
                    if (userinvincibility == false)
                    {
                        //Decrease health
                        uhealth -= 30;
                        //Decrease score
                        score -= 1000;
                        lblScore.Text = "SCORE: " + score;
                        //Decrease laservalue
                        laservalue += 300;
                        //Play soundeffect
                        ugethit.Play();
                    }
                    if (uhealth < 0)
                    {
                        uhealth = 0;

                    }
                    //Set user health
                    UserHealth.Value = uhealth;
                    if (uhealth == 0 && udeadtime == 0)
                    {
                        //Lower life
                        ulives -= 1;
                        udeadtime = 1;
                    }

                }

            }
            #endregion
            #region Boss3BulletMove
            if (wavenumber == 26 )
            {
                //If bulllet is enabled, move bullet according to angle in ebulletdelay
                if (boss3bulletact == true)
                {
                    boss3bullet.Location = new Point(boss3bullet.Location.X + Convert.ToInt32(boss3bulletspeed), boss3bullet.Location.Y + 10);
                }
                //If enemy bullet is below the bottom
                if (boss3bullet.Bottom > picUser.Bottom)
                {
                    //Explosionsound
                    explosionsound.Play();
                   //Explosion
                    boss3BulletExplosion.Location = new Point(boss3bullet.Location.X - 70, boss3bullet.Location.Y - 55);
                    boss3BulletExplosion.Visible = true;
                    boss3bulletexpact = 1;
                    //Reset bullet
                    boss3bullet.Visible = false;
                    boss3bulletact = false;
                    boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);
                 
                }
                //If bullet hits user
                else if (boss3bullet.Top < picUser.Bottom && boss3bullet.Bottom > picUser.Top && boss3bullet.Right > picUser.Left && boss3bullet.Left < picUser.Right && uhealth > 0)
                {
                    //Enable explosion
                    boss3BulletExplosion.Location = new Point(boss3bullet.Location.X - 70, boss3bullet.Location.Y - 55);
                    boss3BulletExplosion.Visible = true;
                    boss3bulletexpact = 1; 

                    //Reset boss3bullet
                    boss3bullet.Visible = false;
                    boss3bulletact = false;
                    boss3bullet.Location = new Point(Boss3Enemy.Location.X + 70, Boss3Enemy.Bottom - 30);


                    /////////////////
                    if (userinvincibility == false)
                    {
                        //Decrease health
                        uhealth -= 50;
                        //Decrease score
                        score -= 1500;
                        lblScore.Text = "SCORE: " + score;
                        //Increase laser value
                        laservalue += 400;
                        //Play sound effect
                        ugethit.Play();
                    }
                    if (uhealth < 0)
                    {
                        uhealth = 0;

                    }
                    //Set health
                    UserHealth.Value = uhealth;
                    if (uhealth == 0 && udeadtime == 0)
                    {
                       //Lower life
                        ulives -= 1;
                        udeadtime = 1;
                    }

                }
                #region bn
                if (boss3bnactivate == false)
                {
                    //Extra  bullet when low health
                    for (int i = 0; i <= 1; i++)
                    {
                        //If bullet is active
                        if (boss3bulletactn[i] == true)
                        {
                            //Move bullet
                            boss3bulletn[i].Location = new Point(boss3bulletn[i].Location.X + Convert.ToInt32(boss3bulletspeedn[i]), boss3bulletn[i].Location.Y + 10);
                        }
                        //Reset bullet when under Player
                        if (boss3bulletn[i].Bottom > picUser.Bottom)
                        {
                            boss3bulletn[i].Visible = false;
                            boss3bulletactn[i] = false;
                            boss3bulletn[i].Location = new Point(Boss3Enemy.Location.X + 75, Boss3Enemy.Bottom - 30);

                        }
                            //Bullet collision
                        else if (boss3bulletn[i].Top < picUser.Bottom && boss3bulletn[i].Bottom > picUser.Top && boss3bulletn[i].Right > picUser.Left && boss3bulletn[i].Left < picUser.Right && uhealth > 0)
                        {
                            //Reset bullet
                            boss3bulletn[i].Visible = false;
                            boss3bulletactn[i] = false;
                            boss3bulletn[i].Location = new Point(Boss3Enemy.Location.X + 75, Boss3Enemy.Bottom - 30);


                            /////////////////
                            if (userinvincibility == false)
                            {
                                //Damage User
                                uhealth -= 25;

                                //Lower score
                                score -= 750;
                                //Increase laser
                                laservalue += 200;
                                //Play sound
                                ugethit.Play();
                            }
                            //Set health
                            if (uhealth < 0)
                            {
                                uhealth = 0;

                            }
                            UserHealth.Value = uhealth;
                            //If damage results in death
                            if (uhealth == 0 && udeadtime == 0)
                            {
                                //Lose life
                                ulives -= 1;
                                udeadtime = 1;
                            }

                        }

                    }
                }
                #endregion

            }
            #endregion
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Recognizes when a key is up
            #region MoveKeyUp
            //Key is false if up
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            #endregion

            #region Abilities
            //Key is false if up
            if (e.KeyCode == Keys.Z)
            {
                zkey = false;
            }
            #endregion

            #region PicBattleCruiserStandStill
            //If both left and right are false,
            if (left == false && right == false)
            {
                if (move != 5)
                {
                    move = 0;
                }
            }
            if (move == 0)
            {
                //Change Battlecruiser image to normal
                picUser.Image = null;
                picUser.Image = Space_Infiltrators.Properties.Resources.Battlecruiser;
                movet.Enabled = false;
                move = 5;
            }
            #endregion

        }

        private void Universal_Tick(object sender, EventArgs e)
        {
            //Laser value calculator
            if (PicLaserBar.Size.Width < 766 && laseract == 0)
            {
               // laservalue += 5000; //- for testing laser
            
                PicLaserBar.Size = new Size(Convert.ToInt32(laservalue / laservaluedivider), 20);
                //Avoid over maximum value
                if (PicLaserBar.Size.Width > 766)
                {
                    PicLaserBar.Size = new Size(766, 20);
                }

            }
            //Bomb value calculator
            if (PicBombBar.Size.Width < 766 && bombact == false)
            {
                //Increase bombvalue over time
                //bombvalue += 100; //- for testing bomb
                bombvalue += 1;

                PicBombBar.Size = new Size(Convert.ToInt32(bombvalue / 2), 20);
                //Avoid over maximum value
                if (PicBombBar.Size.Width > 766)
                {
                    PicBombBar.Size = new Size(766, 20);
                }
            }


            //User temporary invincibility (After you die)
            if (utempbility == true)
            {
                //The user will have temporary invincibility for 30 counts of utemp timer
                userinvincibility = true;
                utemptimer += 1;
                if (utemptimer > 30)
                {
                 //After 30 counts, no more invincibility
                    utempbility = false;
                    utemptimer = 0;
                    userinvincibility = false;
                }
            }
         
            #region User Death
            //When User health is 0 at any given point 
            if (uhealth == 0)
            {
                //Disable all timers, and abilities
                utemptimer = 0;
                movet.Enabled = false;
               ubulletact[0] = false;
                ubulletact[1] = false;
                ubulletdelay = true;
                ubulletdelaytmr.Enabled = false;
                ebulletdelay.Enabled = false;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;
               //Disallow blast to keep charging
                if (ublastact == 1)
                {
                    ublastact = 0;
                    PicBlast.Location = new Point(picUser.Left + 25, picUser.Top + 25);
                    PicBlast.Visible = false;
                    ublasttmr.Enabled = false;
                }
                //Advance forward
                udeadtime += 1;

                //Change explosion picture
                if (udeadtime >= 0)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion0;
                }
                if (udeadtime >= 7)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion1;
                }
               if (udeadtime >= 14)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion2;
                }
                 if (udeadtime >= 21)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion3;
                }
                if (udeadtime >= 28)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion4;
                }
                if (udeadtime >= 35)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion5;
                }
                if (udeadtime >= 42)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion6;
                }
                if (udeadtime >= 49)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion7;
                }
                if (udeadtime >= 56)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion8;
                }
                if (udeadtime >= 63)
                {
                    picUser.Image = Space_Infiltrators.Properties.Resources.Exploion9;
                }
                if (udeadtime >= 70)
                {
                    picUser.Image = null;
                }

              
                if (ulives == 2)
                {
                    //Lose live 3
                    PicLive3.Visible = false;
                    //Gain laser value slightly faster
                    laservaluedivider = 7;
                }
                if (ulives == 1)
                {
                    //Lose live 2
                    PicLive2.Visible = false;
                    //Gain laser value slightly faster
                    laservaluedivider = 6;
                }
                if (ulives == 0)
                {
                    //Lose live 1
                    PicLive1.Visible = false;
                    //Gain laser value slightly faster
                    laservaluedivider = 5;
                   
               
                }
                if (udeadtime == 2)
                {
                    //Play explosion sound
                    explosionsound.Play();
                    //Grant Temporary invincibility
                    utempbility = true;
                }

                
                //After the explosion delay,
                if (udeadtime > 75)
                {
                    //If no  more lives are left, lose the game
                    if (ulives == -1)
                    {
                        //Disable all enemies and timers
                        totalenemies = numberofnenemies;
                        InvaderTimer.Enabled = false;
                        ebulletdelay.Enabled = false;
                        ebulletdelay2.Enabled = false;
                        ebulletdelay3.Enabled = false;
                        InvaderTimer.Enabled = false;
                        ubulletdelaytmr.Enabled = false;
                        Universal.Enabled = false;
                        musicvalue = 0;
                        MusicTimer.Enabled = false;
                        wplayer.controls.stop();
                        wplayer2.controls.stop();
                        udeadtime = 0;
                        BossTimer.Enabled = false;
                        //Change to lose screen
                    
                        this.Hide();
                        frmlose.Show();
                    }

                    //Respawn if ulives != -1
                    //Change image back to Battlecruiser
                    picUser.Image = Space_Infiltrators.Properties.Resources.Battlecruiser;
                    //Health back to 100
                    uhealth = 100;
                    UserHealth.Value = uhealth;

                    //Enable all timers and reset deadtime
                        ubulletdelay = false;
                        ubulletact[0] = true;
                        ubulletact[1] = true;
                        ubulletdelaytmr.Enabled = true;
                        udeadtime = 0;
                        ebulletdelay.Enabled = true;
                        ebulletdelay2.Enabled = true;
                        ebulletdelay3.Enabled = true;
                }

            }
            #endregion
        }
        private void LaserDelay_Tick(object sender, EventArgs e)
        {
            //Laser is able to do damage in certain intervals
            laserdodamage = true;
        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            //Music timer
            musicvalue += 1;
 
            //Repeat music after a certain time
            if (musicvalue > 2260)
            {
                musicvalue = 0;
                wplayer.controls.stop();
                wplayer.controls.play();
                wplayer.controls.stop();
                wplayer2.controls.play();

            }
        }

        private void uLaserTimer_Tick(object sender, EventArgs e)
        {

            //Laser
            #region Laser (Graphics and Variables)
            if (PicLaserBar.Size.Width < 766 && laseract == 0)
            {
                // laservalue += 5000;
                //laservalue += 1;
                //  bombvalue += 1;

                PicLaserBar.Size = new Size(Convert.ToInt32(laservalue / laservaluedivider), 20);
                if (PicLaserBar.Size.Width > 766)
                {
                    PicLaserBar.Size = new Size(766, 20);
                }
                // PicBombBar.Size = new Size(Convert.ToInt32(bombvalue/2), 20);
            }
            if (laseract == 1)
            {
                //Grants Invincibility
                userinvincibility = true;
                //Resets laser value
                laservalue = 0;
                PicLaserBar.Size = new Size(Convert.ToInt32(laservalue), 20);
                //Shows laser
                PicLaser.Visible = true;
                //Disable enemy bullets
                ebulletdelay.Enabled = false;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;
                //Makes the laser grow larger over timew
                if (PicLaser.Size.Height <= 1500)
                {
                    PicLaser.Size = new Size(200, PicLaser.Size.Height + 15);
                    PicLaser.Location = new Point(picUser.Left - 65, PicLaser.Location.Y - 15);
                }
                else
                {
                    //After a certain time, stops growing and starts a timer
                    PicLaser.Location = new Point(picUser.Left - 65, PicLaser.Location.Y);
                    lasertimer += 1;
                

                    if (lasertimer > 50)
                    {
                        //After the timer pasts 50, advancce to next laser phase
                        laseract = 2;
                    }


                }

            }
            //LaSER PHASE 2
            if (laseract == 2)
            {
                //Shoots laser up but doesn't follow User anymore
                PicLaser.Location = new Point(PicLaser.Location.X, PicLaser.Location.Y - 30);
                //Once laser passes a certain point
                if (PicLaser.Bottom < -100)
                {
                    //Reset all variables and activate everything again
                    PicLaser.Visible = false;
                    laseract = 0;
                    lasertimer = 0;
                    userinvincibility = false;
                    ebulletdelay.Enabled = true;
                    ebulletdelay2.Enabled = true;
                    ebulletdelay3.Enabled = true;
                    LaserDelay.Enabled = false;
                    laserdamagelimit = 0;
                    ubulletact[0] = true;
                    ubulletact[1] = true;
                    ublastact = 0;
                    PicLaser.Size = new Size(200, 0);
                    PicLaser.Location = new Point(picUser.Left - 65, picUser.Top - 100);
                    uLaserTimer.Enabled = false;

                }
            }
            #endregion


            //Laser Collision
            if (laseract == 1 || laseract == 2)
            {
                #region SendEverythingBehind
                //For all possible enemies, Send them and their bullets to behind the laser
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].SendToBack();
                    ebulletn[i].SendToBack();
                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].SendToBack();
                    ebulletp[i].SendToBack();
                }
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].SendToBack();
                    ebullets[i].SendToBack();
                }
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    picTEnemy[i].SendToBack();
                    ebullett[i].SendToBack();
                }
                if (wavenumber == 7)
                {
                    Boss1Enemy.SendToBack();
                    boss1bullet.SendToBack();
                }
                if (wavenumber == 16)
                {
                    Boss2Enemy.SendToBack();
                    boss2bullet.SendToBack();
                }
                if (wavenumber == 26)
                {
                    Boss3Enemy.SendToBack();
                    boss3bullet.SendToBack();
                    boss3bullet2[0].SendToBack();
                    boss3bullet2[1].SendToBack();
                    boss3bulletn[0].SendToBack();
                    boss3bulletn[1].SendToBack();
                }
                #endregion
                //Ensures user cannot shoot
                ubulletact[0] = false;
                ubulletact[1] = false;
                //Ensures the user cannot create a blast
                if (ublastact == 0)
                {
                    ublastact = 3;
                }

                #region LaserToNormalEnemy
              
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadnenemy[i] == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < picNEnemy[i].Bottom && PicLaser.Bottom > picNEnemy[i].Top && PicLaser.Right > picNEnemy[i].Left && PicLaser.Left < picNEnemy[i].Right && normalenemy[i] == true && laserdodamage == true)
                        {
                            //Deal 2 damage
                            enhealth[i] -= 2;
                            if (wavenumber != 16)
                            {
                                //Laser delay
                            laserdodamage = false;
                            }

                        }

                        if (enhealth[i] <= 0)
                        {
                            //Disable enemy
                            picNEnemy[i].Visible = false;
                            picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, -35);
                            normalenemy[i] = false;
                            deadnenemy[i] = true;
                            //Increas score
                            score += 1000;
                            lblScore.Text = "SCORE: " + score;

                            //Boss 2 Respawn enemy
                            if (wavenumber == 16)
                            {
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                            }

                            countdead += 1;
                            checknewwave();
                          


                        }
                    }
                }
                #endregion
                #region LaserToPowerEnemy
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadpenemy[i] == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < picPEnemy[i].Bottom && PicLaser.Bottom > picPEnemy[i].Top && PicLaser.Right > picPEnemy[i].Left && PicLaser.Left < picPEnemy[i].Right && powerenemy[i] == true && laserdodamage == true)
                        {
                            //Deal 2 damage
                            ephealth[i] -= 2;
                            if (wavenumber != 16)
                            {
                                //Laser delay
                                laserdodamage = false;
                            }

                        }

                        if (ephealth[i] <= 0)
                        {
                            //Disable enemy
                            picPEnemy[i].Visible = false;
                            picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, -35);
                            powerenemy[i] = false;
                            //Increas score
                            score += 3000;
                            lblScore.Text = "SCORE: " + score;

                            countdead += 1;
                            deadpenemy[i] = true;
                            checknewwave();


                            #region Boss2StuffP
                            //Allows for enemy to respawn
                            //Spawning position # 1
                            if (wavenumber == 16 && boss2p1 == true && i == 0)
                            {
                                //Reset Spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2p1 = false;
                            }
                            //Spawning position # 2
                            if (wavenumber == 16 && boss2p2 == true && i == 1)
                            {
                                //Reset Spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2p2 = false;
                            }
                            //Spawning position # 3
                            if (wavenumber == 16 && boss2p3 == true && i == 2)
                            {
                                //Reset Spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2p3 = false;
                            }
                            //Spawning position # 4
                            if (wavenumber == 16 && boss2p4 == true && i == 3)
                            {
                                //Reset Spawning timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2p4 = false;


                            }
                            #endregion

                        }
                    }
                }
                #endregion
                #region LaserToSpeedEnemy
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadsenemy[i] == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < picSEnemy[i].Bottom && PicLaser.Bottom > picSEnemy[i].Top && PicLaser.Right > picSEnemy[i].Left && PicLaser.Left < picSEnemy[i].Right && speedenemy[i] == true && laserdodamage == true)
                        {
                            //Deal 2 damage
                            eshealth[i] -= 2;
                            if (wavenumber != 16)
                            {
                                //Laser delay
                                laserdodamage = false;
                            }


                        }

                        if (eshealth[i] <= 0)
                        {
                            //Disable enemy
                            picSEnemy[i].Visible = false;
                            picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, -35);
                            speedenemy[i] = false;
                            //Increas score
                            score += 3000;
                            lblScore.Text = "SCORE: " + score;

                            countdead += 1;
                            deadsenemy[i] = true;
                            checknewwave();

                            #region Boss2StuffS
                            //Respawns enemies
                            //Respawn enemy 1
                            if (wavenumber == 16 && boss2s1 == true && i == 0)
                            {
                                //Reset timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2s1 = false;
                            }
                            //Respawn enemy 2
                            if (wavenumber == 16 && boss2s2 == true && i == 1)
                            {
                                //Reset timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2s2 = false;
                            }
                            //Respawn enemy 3
                            if (wavenumber == 16 && boss2s3 == true && i == 2)
                            {
                                //Reset timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2s3 = false;
                            }
                            //Respawn enemy 4
                            if (wavenumber == 16 && boss2s4 == true && i == 3)
                            {
                                //Reset timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2s4 = false;


                            }
                            #endregion


                        }
                    }
                }
                #endregion
                #region LaserToTankEnemy
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    //If enemy is not already dead
                    if (deadtenemy[i] == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < picTEnemy[i].Bottom && PicLaser.Bottom > picTEnemy[i].Top && PicLaser.Right > picTEnemy[i].Left && PicLaser.Left < picTEnemy[i].Right && tankenemy[i] == true && laserdodamage == true)
                        {
                            //Deal damage
                            ethealth[i] -= 4;
                            if (wavenumber != 16)
                            {
                                //Laser delay
                                laserdodamage = false;
                            }

                        }

                        if (ethealth[i] <= 0)
                        {
                            //Disable enemy
                            picTEnemy[i].Visible = false;
                            picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, -35);
                            tankenemy[i] = false;
                            //Increas score
                            score += 7000;
                            lblScore.Text = "SCORE: " + score;

                            countdead += 1;
                            deadtenemy[i] = true;
                            checknewwave();

                            #region Boss2StuffT
                            //Respawn Enemies
                            //Respawn location 1
                            if (wavenumber == 16 && boss2t1 == true && i == 0)
                            {
                                //Restart timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e1 = false;
                                boss2t1 = false;
                            }
                            //Respawn location 2
                            if (wavenumber == 16 && boss2t2 == true && i == 1)
                            {
                                //Restart timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e2 = false;
                                boss2t2 = false;

                            }
                            //Respawn location 3
                            if (wavenumber == 16 && boss2t3 == true && i == 2)
                            {
                                //Restart timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e3 = false;
                                boss2t3 = false;
                            }
                            //Respawn location 4
                            if (wavenumber == 16 && boss2t4 == true && i == 3)
                            {
                                //Restart timer
                                Boss2eSpawn.Stop();
                                Boss2eSpawn.Start();
                                boss2e4 = false;
                                boss2t4 = false;
                            }
                            #endregion


                        }
                    }
                }
                #endregion


                #region LaserToBoss1Enemy
                if (wavenumber == 7)
                {
                    //If enemy is not already dead
                    if (deadboss1 == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < Boss1Enemy.Bottom && PicLaser.Bottom > Boss1Enemy.Top && PicLaser.Right > Boss1Enemy.Left && PicLaser.Left < Boss1Enemy.Right && laserdodamage == true && laserdamagelimit < 20)
                        {
                            //Deal 1 damage
                            boss1health -= 1;
                            if (boss1health <= 0)
                            {
                                boss1health = 0;
                            }
                            BossHP.Value = boss1health;
                            //Laser delay
                            laserdodamage = false;
                            laserdamagelimit += 1;
                        }



                        if (boss1health <= 0 && deadboss1 == false)
                        {
                            //Increas score
                            score += 75000;
                            lblScore.Text = "SCORE: " + score;
                            //Disable boss
                            deadboss1 = true;
                        }
                    }
                }

                #endregion


                #region LaserToBoss2Enemy
                if (wavenumber == 16)
                {
                    //If enemy is not already dead
                    if (deadboss2 == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < Boss2Enemy.Bottom && PicLaser.Bottom > Boss2Enemy.Top && PicLaser.Right > Boss2Enemy.Left && PicLaser.Left < Boss2Enemy.Right && laserdodamage == true && laserdamagelimit < 20)
                        {
                            //Deal 1 damage
                            boss2health -= 1;
                            if (boss2health <= 0)
                            {
                                boss2health = 0;
                            }
                            BossHP.Value = boss2health;
                            //Laser delay
                            laserdodamage = false;
                            laserdamagelimit += 1;
                        }

                        if (boss2health <= 0 && deadboss2 == false)
                        {
                            //Increas score
                            score += 100000;
                            lblScore.Text = "SCORE: " + score;
                            //Disable boss
                            deadboss2 = true;


                        }
                    }
                }

                #endregion

                #region LaserToBoss3Enemy
                if (wavenumber == 26)
                {
                    //If enemy is not already dead
                    if (deadboss3 == false)
                    {
                        //Laser to Enemy collision
                        if (PicLaser.Top < Boss3Enemy.Bottom && PicLaser.Bottom > Boss3Enemy.Top && PicLaser.Right > Boss3Enemy.Left && PicLaser.Left < Boss3Enemy.Right && laserdodamage == true && laserdamagelimit < 20)
                        {
                            //Deal 1 damage
                            boss3health -= 1;
                            if (boss3health <= 0)
                            {
                                boss3health = 0;
                            }
                            BossHP.Value = boss3health;
                            //Laser delay
                            laserdodamage = false;
                            laserdamagelimit += 1;
                        }

                        if (boss3health <= 0 && deadboss3 == false)
                        {
                            //Increas score
                            score += 150000;
                            lblScore.Text = "SCORE: " + score;
                            //Disable boss
                            deadboss3 = true;


                        }
                    }
                }

                #endregion
            }
        }

        private void uBombTimer_Tick(object sender, EventArgs e)
        {
            #region BombExplosion

            if (bombact == true)
            {
                #region SendEverythingBehind
                //Sends all enemies and enemy bullets to back
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    picNEnemy[i].SendToBack();
                    ebulletn[i].SendToBack();
                }
                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    picPEnemy[i].SendToBack();
                    ebulletp[i].SendToBack();
                }
                for (int i = 0; i <= numberofsenemies - 1; i++)
                {
                    picSEnemy[i].SendToBack();
                    ebullets[i].SendToBack();
                }
                for (int i = 0; i <= numberoftenemies - 1; i++)
                {
                    picTEnemy[i].SendToBack();
                    ebullett[i].SendToBack();
                }
                if (wavenumber == 7)
                {
                    Boss1Enemy.SendToBack();
                    boss1bullet.SendToBack();
                }
                if (wavenumber == 16)
                {
                    Boss2Enemy.SendToBack();
                    boss2bullet.SendToBack();
                }
                if (wavenumber == 26)
                {
                    Boss3Enemy.SendToBack();
                    boss3bullet.SendToBack();
                    boss3bullet2[0].SendToBack();
                    boss3bullet2[1].SendToBack();
                    boss3bulletn[0].SendToBack();
                    boss3bulletn[1].SendToBack();
                }
                #endregion
                //Enable invincibility and stop from using bullets and blast
                userinvincibility = true;
                ubulletact[0] = false;
                ubulletact[1] = false;
                ubulletdelay = true;
                ubulletdelaytmr.Enabled = false;

                if (ublastact == 0)
                {
                    ublastact = 3;
                }

               //Make enemy all bullets dissapear
                for (int i = 0; i <= numberofnenemies - 1; i++)
                {
                    ebulletn[i].Visible = false;
                    ebulletnact[i] = false;
                    ebulletn[i].Location = new Point(picNEnemy[i].Location.X + 8, picNEnemy[i].Bottom);
                }

                for (int i = 0; i <= numberofpenemies - 1; i++)
                {
                    ebulletp[i].Visible = false;
                    ebulletpact[i] = false;
                    ebulletp[i].Location = new Point(picPEnemy[i].Location.X + 8, picPEnemy[i].Bottom);
                }
                //Stop the enemy bullet timers

                ebulletdelay.Enabled = false;
                ebulletdelay2.Enabled = false;
                ebulletdelay3.Enabled = false;
                //Resart bomb value
                bombvalue = 0;
                PicBombBar.Size = new Size(Convert.ToInt32(bombvalue), 20);
                //Send everything to back
                picUser.SendToBack();
                Warning1.SendToBack();
                Warning2.SendToBack();
                Warning3.SendToBack();
                Warning4.SendToBack();
                Warning5.SendToBack();
                Warning6.SendToBack();
                Warning7.SendToBack();
                Warning8.SendToBack();

                //Set bomb visible to true
                PicBomb.Visible = true;

                //When expanding outwards
                if (bombexpand == true)
                {
                    //Expand outwards gradually faster
                    PicBomb.Size = new Size(PicBomb.Size.Width + 10, PicBomb.Size.Height + 10);
                    PicBomb.Location = new Point(PicBomb.Location.X - 5, PicBomb.Location.Y - 5);
                    if (PicBomb.Size.Width > 100)
                    {
                        PicBomb.Size = new Size(PicBomb.Size.Width + 20, PicBomb.Size.Height + 20);
                        PicBomb.Location = new Point(PicBomb.Location.X - 10, PicBomb.Location.Y - 10);
                    }
                    if (PicBomb.Size.Width > 300)
                    {
                        PicBomb.Size = new Size(PicBomb.Size.Width + 30, PicBomb.Size.Height + 30);
                        PicBomb.Location = new Point(PicBomb.Location.X - 15, PicBomb.Location.Y - 15);
                    }
                    //After Bomb width was greater than a size
                    if (PicBomb.Size.Width > 2500)
                    {
                        //Phase 2: Bomb decreases in size
                        bombexpand = false;
                    }


                }
                //Phase 2
                if (bombexpand == false)
                {
                    //Bomb decreases in size very quickly
                    PicBomb.Size = new Size(PicBomb.Size.Width - 100, PicBomb.Size.Height - 100);
                    PicBomb.Location = new Point(PicBomb.Location.X + 50, PicBomb.Location.Y + 50);
                    //After size is less than a certain point
                    if (PicBomb.Size.Width < 21 && bombact == true)
                    {
                        //Deactivate and reset everything
                        //Invincibility
                        userinvincibility = false;
                        //Reset bomb
                        bombact = false;
                        PicBomb.Location = new Point(picUser.Left + 15, picUser.Bottom);
                        PicBomb.Visible = false;
                        bombvalue = 0;
                        bombexpand = true;
                        PicBomb.Size = new Size(20, 20);
                        uBombTimer.Enabled = false;
                        //Enable user bullet 
                        ubulletdelay = false;
                        ubulletact[0] = true;
                        ubulletact[1] = true;
                        ubulletdelaytmr.Enabled = true;
                        //Enable enemy bullet
                        ebulletdelay.Enabled = true;
                        ebulletdelay2.Enabled = true;
                        ebulletdelay3.Enabled = true;

                      //Enable blast
                        ublastact = 0;
                        


                        #region BombToNormalCollision
                        if (spawntmr.Enabled == false)
                        {
                            for (int i = 0; i <= numberofnenemies - 1; i++)
                            {
                                //If enemy is not already dead
                                if (deadnenemy[i] == false)
                                {
                                    //Deal damage
                                    enhealth[i] -= 2;

                                    if (enhealth[i] <= 0)
                                    {
                                        //Disable enemy
                                        picNEnemy[i].Visible = false;
                                        picNEnemy[i].Location = new Point(picNEnemy[i].Location.X, -35);
                                        normalenemy[i] = false;
                                        deadnenemy[i] = true;
                                        //Increase score
                                        score += 1000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Count number of dead enemies
                                        countdead += 1;
                                    
                                        checknewwave();
                                    }
                                }
                            }

                        }
                        #endregion

                        #region BombToPowerCollision
                        if (spawntmr.Enabled == false)
                        {
                            for (int i = 0; i <= numberofpenemies - 1; i++)
                            {
                                //If enemy is not already dead
                                if (deadpenemy[i] == false)
                                {

                                    ephealth[i] -= 3;
                                    //      ephealth[i] -= 3;
                                    if (ephealth[i] <= 0)
                                    {
                                        //Disable enemy
                                        picPEnemy[i].Visible = false;
                                        picPEnemy[i].Location = new Point(picPEnemy[i].Location.X, -35);
                                        powerenemy[i] = false;
                                        deadpenemy[i] = true;
                                        //Increase score
                                        score += 3000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Count number of dead enemies
                                        countdead += 1;

                                        checknewwave();

                                        #region Boss2StuffP
                                        //Allows for enemy to respawn
                                        //Spawning position # 1
                                        if (wavenumber == 16 && boss2p1 == true && i == 0)
                                        {
                                            //Reset Spawning timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e1 = false;
                                            boss2p1 = false;
                                        }
                                        //Spawning position # 2
                                        if (wavenumber == 16 && boss2p2 == true && i == 1)
                                        {
                                            //Reset Spawning timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e2 = false;
                                            boss2p2 = false;
                                        }
                                        //Spawning position # 3
                                        if (wavenumber == 16 && boss2p3 == true && i == 2)
                                        {
                                            //Reset Spawning timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e3 = false;
                                            boss2p3 = false;
                                        }
                                        //Spawning position # 4
                                        if (wavenumber == 16 && boss2p4 == true && i == 3)
                                        {
                                            //Reset Spawning timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e4 = false;
                                            boss2p4 = false;


                                        }
                                        #endregion
                                    }
                                }
                            }
                        }
                        #endregion
                        #region BombToSpeedCollision

                        if (spawntmr.Enabled == false)
                        {
                            for (int i = 0; i <= numberofsenemies - 1; i++)
                            {
                                //If enemy is not already dead
                                if (deadsenemy[i] == false)
                                {
                                    //Lower health
                                    eshealth[i] -= 3;

                                    if (eshealth[i] <= 0)
                                    {
                                        //Disable enemy
                                        picSEnemy[i].Visible = false;
                                        picSEnemy[i].Location = new Point(picSEnemy[i].Location.X, -35);
                                        speedenemy[i] = false;
                                        deadsenemy[i] = true;
                                        //Increase score
                                        score += 3000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Count number of dead enemies
                                        countdead += 1;
                                        checknewwave();
                                        #region Boss2StuffS
                                        //Respawns enemies
                                        //Respawn enemy 1
                                        if (wavenumber == 16 && boss2s1 == true && i == 0)
                                        {
                                            //Reset timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e1 = false;
                                            boss2s1 = false;
                                        }
                                        //Respawn enemy 2
                                        if (wavenumber == 16 && boss2s2 == true && i == 1)
                                        {
                                            //Reset timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e2 = false;
                                            boss2s2 = false;
                                        }
                                        //Respawn enemy 3
                                        if (wavenumber == 16 && boss2s3 == true && i == 2)
                                        {
                                            //Reset timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e3 = false;
                                            boss2s3 = false;
                                        }
                                        //Respawn enemy 4
                                        if (wavenumber == 16 && boss2s4 == true && i == 3)
                                        {
                                            //Reset timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e4 = false;
                                            boss2s4 = false;


                                        }
                                        #endregion

                                    }
                                }
                            }
                        }
                        #endregion
                        #region BombToTankCollision
                        if (spawntmr.Enabled == false)
                        {
                            for (int i = 0; i <= numberoftenemies - 1; i++)
                            {
                                //If enemy is not already dead
                                if (deadtenemy[i] == false)
                                {
                                    //Lower health
                                    ethealth[i] -= 7;
                                 
                                    //If damage resuls in death
                                    if (ethealth[i] <= 0)
                                    {
                                        //Disable enemy
                                        picTEnemy[i].Visible = false;
                                        picTEnemy[i].Location = new Point(picTEnemy[i].Location.X, -35);
                                        tankenemy[i] = false;
                                        deadtenemy[i] = true;
                                        //Increase score
                                        score += 7000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Count number of dead enemies
                                        countdead += 1;
                                       
                                       //Checks for new wave
                                        checknewwave();
                                        #region Boss2StuffT
                                        //Respawn Enemies
                                        //Respawn location 1
                                        if (wavenumber == 16 && boss2t1 == true && i == 0)
                                        {
                                            //Restart timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e1 = false;
                                            boss2t1 = false;
                                        }
                                        //Respawn location 2
                                        if (wavenumber == 16 && boss2t2 == true && i == 1)
                                        {
                                            //Restart timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e2 = false;
                                            boss2t2 = false;

                                        }
                                        //Respawn location 3
                                        if (wavenumber == 16 && boss2t3 == true && i == 2)
                                        {
                                            //Restart timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e3 = false;
                                            boss2t3 = false;
                                        }
                                        //Respawn location 4
                                        if (wavenumber == 16 && boss2t4 == true && i == 3)
                                        {
                                            //Restart timer
                                            Boss2eSpawn.Stop();
                                            Boss2eSpawn.Start();
                                            boss2e4 = false;
                                            boss2t4 = false;
                                        }
                                        #endregion
                                    }
                                }
                            }
                        }
                        #endregion
                        #region BombToboss1Collision
                        if (wavenumber == 7)
                        {
                            if (spawntmr.Enabled == false)
                            {

                                //If enemy is not already dead
                                if (deadboss1 == false)
                                {
                                    //Lower health
                                    boss1health -= 10;
                                    if (boss1health <= 0)
                                    {
                                        boss1health = 0;
                                    }
                                    BossHP.Value = boss1health;
                                    //If damage results in death
                                    if (boss1health <= 0 && deadboss1 == false)
                                    {
                                        //Increase score
                                        score += 75000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Set boss1 as dead
                                        deadboss1 = true;

                                    }
                                }


                            }
                        }
                        #endregion

                        #region BombToboss2Collision
                        if (wavenumber == 16)
                        {
                            if (spawntmr.Enabled == false)
                            {

                                //If enemy is not already dead
                                if (deadboss2 == false)
                                {
                                    //Decrease health
                                    boss2health -= 10;
                                    if (boss2health <= 0)
                                    {
                                        boss2health = 0;
                                    }
                                    BossHP.Value = boss2health;
                                    //If damage results in death
                                    if (boss2health <= 0 && deadboss1 == false)
                                    {

                                        //Decrease score
                                        score += 100000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Set boss2 as dead
                                        deadboss2 = true;

                                    }
                                }


                            }
                        }
                        #endregion

                        #region BombToboss3Collision
                        if (wavenumber == 26)
                        {
                            if (spawntmr.Enabled == false)
                            {

                                //If enemy is not already dead
                                if (deadboss3 == false)
                                {
                                    //Decrease health
                                    boss3health -= 10;
                                    if (boss3health <= 0)
                                    {
                                        boss3health = 0;
                                    }
                                    BossHP.Value = boss3health;
                                    //If damage results in death
                                    if (boss3health <= 0 && deadboss1 == false)
                                    {
                                        //Increase score
                                        score += 150000;
                                        lblScore.Text = "SCORE: " + score;
                                        //Set boss3 as dead
                                        deadboss3 = true;

                                    }
                                }


                            }
                        }
                        #endregion


                    }
                }
            }
            //}
            #endregion
        }


        private void Infiltrators_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      

    }
}
