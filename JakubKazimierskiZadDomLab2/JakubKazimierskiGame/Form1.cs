using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Resources;
using WMPLib;



namespace JakubKazimierskiGame
{
    public partial class Form1 : Form
    {
        
        


        #region Variables
        Random rand; //variable to create random positions 

        PictureBox[] stars;
        int backgroundSpeed;

        PictureBox[] meteors;

        

        PictureBox[] munitions;
        int MunitionSpeed;

        PictureBox[] enemies;
        


        PictureBox[] enemiesMunitions;
        

        int score;
        int level;
        int difficulty;
        int money;
        int speedLvl;
        int bullets;
        bool pause;
        bool gameIsOver;
        bool EasyModeFlag = false;
        bool MediumModeFlag = false;
        bool HardModeFlag = false;

        private Background background;

        private Health health;

        private Bullets bulletsPlayer;

        private Speed speedPlayer;

        private EnemyBullets enemyBullet;

        private EnemySpeed speedEnemy;

        private EnemyAmount amountEnemy;

        private Scores highScores;

        private List<int> ScoresList = new List<int>();//list for scores

        Image enemi1 = JakubKazimierskiGame.Properties.Resources.E1;
        Image enemi2 = JakubKazimierskiGame.Properties.Resources.E2;
        Image enemi3 = JakubKazimierskiGame.Properties.Resources.E3___Kopia;

        Image boss1 = JakubKazimierskiGame.Properties.Resources.Boss1;
        Image boss2 = JakubKazimierskiGame.Properties.Resources.Boss2;

        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer boom;

        #endregion

        public Form1()
        {
            
                InitializeComponent();
            
        }

        #region Bacground Methods

        /// <summary>
        /// Loading backround of game
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event object</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region creating variables object
                //assigmnet of values to variables
                if (background.GetColorBackground() != null && health.GetLifeAmount() != null && health.GetShieldAmount() != null && bulletsPlayer.GetBulletsAmount() != null && speedPlayer.GetSpeedLevel() != null && enemyBullet.GetBullets() != null && speedEnemy.GetSpeed() != null && amountEnemy.GetAmount() != null)
                {

                    MunitionSpeed = 20;
                    difficulty = 9;
                    level = 1;
                    score = 0;
                    money = 0;
                    speedLvl = 1;
                    bullets = 1;//speed of bullets not amount
                    pause = false;
                    gameIsOver = false;
                    rand = new Random();
                    #endregion

                    #region Creating picture  objects

                    stars = new PictureBox[15];

                    meteors = new PictureBox[6];

                    munitions = new PictureBox[bulletsPlayer.GetBulletsAmount()];



                    enemies = new PictureBox[amountEnemy.GetAmount()];

                    enemiesMunitions = new PictureBox[amountEnemy.GetAmount()];

                    //thanks to initialization below background speed and color depends from difficulty mode
                    this.BackColor = Color.FromName(background.GetColorBackground());
                    backgroundSpeed = background.GetObstaclesBackground();

                    //create object of sound
                    gameMedia = new WindowsMediaPlayer();
                    shootMedia = new WindowsMediaPlayer();
                    boom = new WindowsMediaPlayer();

                    gameMedia.URL = @"GameSong.mp3";
                    shootMedia.URL = @"shoot.mp3";
                    boom.URL = @"boom.mp3";

                    gameMedia.settings.setMode("loop", true);
                    gameMedia.settings.volume = 5;
                    shootMedia.settings.volume = 1;
                    boom.settings.volume = 6;

                    //start music
                    gameMedia.controls.play();

                    LifeLabel.Text = "LIFE: " + health.GetLifeAmount().ToString();
                    ShieldLabel.Text = "SHIELD: " + health.GetShieldAmount().ToString();
                    #endregion
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Odpalanie");
            }
            #region Rendering Images loops
            //rendering ammo
            for (int i = 0; i<munitions.Length; i++ )
            {

                munitions[i] = new PictureBox();
                munitions[i].BorderStyle = BorderStyle.None;
                munitions[i].Size = new Size(8, 8);
                munitions[i].BackColor = Color.Red;
                munitions[i].Location = new Point(Player.Location.X-10 + i*10, Player.Location.Y + 50);
                this.Controls.Add(munitions[i]);
            }



            //rendering stars at background
            for (int i = 0; i < stars.Length; i ++)
            {

                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rand.Next(-25, this.Width), rand.Next(-10, this.Height));
                if( i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;

                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }


                this.Controls.Add(stars[i]);

            }

            //rendering meteors at background, meteors are enemies of player
            for (int i = 0; i < meteors.Length; i++)
            {

                meteors[i] = new PictureBox();
                meteors[i].BorderStyle = BorderStyle.None;
                meteors[i].Location = new Point(rand.Next(-45, this.Width-60), rand.Next(-20, this.Height-100));
                
                
                meteors[i].Size = new Size(10, 12);
                meteors[i].BackColor = Color.SandyBrown;

                
                
                this.Controls.Add(meteors[i]);

            }

            //creating enemies positions
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
            
                enemies[i].Location = new Point((i + 1) * 50 + 40 , -50);
                this.Controls.Add(enemies[i]);
            }

            //creating postions of enemies bullets
            for (int i = 0; i < enemiesMunitions.Length; i++)
            {

                enemiesMunitions[i] = new PictureBox();
                enemiesMunitions[i].Size = new Size(2, 25);
                enemiesMunitions[i].BackColor = Color.Magenta;
                enemiesMunitions[i].Visible = false;
                int x = rand.Next(0, 10);
                
                this.Controls.Add(enemiesMunitions[i]);
            }

            #endregion
            //load enemies img from file
            #region Images of enemies
            //methods to load pictures of enemies

            CreateEnemiesImage();
            #endregion

        }
        /// <summary>
        /// Method of timer, which is responsible for moving background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveBackground_Tick(object sender, EventArgs e)
        {
            //rendering stars depending from timer
            for ( int i = 0; i < stars.Length / 2; i++ )
            {
                stars[i].Top += backgroundSpeed;

                if(stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            //rendering sars depending from timer
            for (int i = stars.Length / 2 ; i < stars.Length ; i++)
            {
                stars[i].Top += backgroundSpeed-2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            //rendering meteors speed depending from timer
            for (int i = 0; i < meteors.Length; i++)
            {
                meteors[i].Top += backgroundSpeed - 2;
                if (meteors[i].Top >= this.Height)
                {
                    meteors[i].Top = -stars[i].Height;
                }

            }
        }

        #endregion

        #region Moving Player Methods
        
        /// <summary>
        /// Timer responsible for moving left
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event object</param>
        private void LeftTimer_Tick(object sender, EventArgs e)
        {
            if ( Player.Left > 10)
            {

                Player.Left -= speedPlayer.GetSpeedLevel();
            }
        }

        /// <summary>
        /// Timer responsible for moving right
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event object</param>
        private void RightTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 630)
            {

                Player.Left += speedPlayer.GetSpeedLevel();
            }
        }

        /// <summary>
        /// Method responsible for start moving
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event object</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (EasyModeRadioButton.Enabled == false && MediumModeRadioButton.Enabled == false && HardModeRadioButton.Enabled == false)
            {
                if (!pause)
                {
                    if (e.KeyCode == Keys.Right)
                    {
                        if (speedLvl < 5)//improve speed
                        {
                            RightTimer.Interval = 5 - speedLvl;
                        }
                        RightTimer.Start();
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        if (speedLvl < 5)//imporve speed 
                        {
                            LeftTimer.Interval = 5 - speedLvl;
                        }
                        LeftTimer.Start();
                    }

                    //start fire
                    if (e.KeyCode == Keys.A)
                    {
                        if (bullets <= 3) //more bullets, more intervals of shooting
                        {
                            MunitionTimer.Interval = 31 - 10 * bullets;
                        }
                        MunitionTimer.Start();

                    }
                }
            }
        }

        
        /// <summary>
        ///Method responsible for stop moving
        /// </summary>
        /// <param name="sender">The even sender</param>
        /// <param name="e">The event object</param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightTimer.Stop();
            LeftTimer.Stop();
            //if for preventing null exception
            if (EasyModeRadioButton.Enabled == false && MediumModeRadioButton.Enabled == false && HardModeRadioButton.Enabled == false)
            {
                //pause the game
                if (e.KeyCode == Keys.Space)
                {
                    if (!gameIsOver)
                    {
                        if (pause)
                        {
                            StartTimers();
                            label1.Visible = false;
                            pause = false;
                        }
                        else
                        {
                            label1.Location = new Point(this.Width / 2 - 120, 150);
                            label1.Text = "PAUSED";
                            label1.Visible = true;
                            StopTimers();
                            pause = true;
                        }
                    }
                }

                //end fire
                if (e.KeyCode == Keys.S)
                {

                    MunitionTimer.Stop();
                    for (int i = 0; i < munitions.Length; i++)
                    {

                        munitions[i].Visible = false;

                    }

                }
            }
        }
        #endregion

        #region Shooting method
    
        /// <summary>
        /// Method of timer, which is responsible for moving player ammo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MunitionTimer_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                    Collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 40 -i*20, Player.Location.Y - i * 30);
                }
            }
        }

        #endregion

        #region Moving enemies methods
        /// <summary>
        /// Method responsible for rendering enemies 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="speed"></param>
        private void MoveEnemies(PictureBox[] array, int speed)
        {
            
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        array[i].Visible = true;
                        array[i].Top += speedEnemy.GetSpeed();

                        if (array[i].Top > this.Height)
                        {
                            array[i].Location = new Point((i + 1) * 50, -200);
                        }
                    }
                }
            
        }
        
        /// <summary>
        /// Method based on timer intervals responsible for moving enemies, also contains method responsible for collisions of object like bullets and ships
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            Collision();
            MoveEnemies(enemies, speedEnemy.GetSpeed());
        }
        #endregion

        #region collisions methods
        /// <summary>
        /// Collision detector, detect bullets collisions with ships, and also ships collision to each other
        /// </summary>
        private void Collision()
        {
            
            for (int i = 0; i < enemies.Length; i++)
            {
                for (int j = 0; j < munitions.Length; j++)
                {
                   //logic of increasing values : level, money, score, bullet, speed
                    if (munitions[j].Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        score += 1;
                        scoreLabel.Text = (score < 10) ? "SCORE: 0" + score.ToString() : "SCORE: " + score.ToString();

                        if (score % 30 == 0)
                        {
                            level += 1;
                            levelLabel.Text = (level < 10) ? "LEVEL: 0" + level.ToString() : "LEVEL: " + level.ToString();

                            if (speedEnemy.GetSpeed() <= 10 && enemyBullet.GetBullets() <=10 && difficulty >= 0)
                            {
                                difficulty--;
                                speedEnemy.SetSpeed(speedEnemy.GetSpeed()+1);
                                enemyBullet.SetBullets(enemyBullet.GetBullets()+1);
                            }

                            if(level == 10)
                            {
                                GameOver("You Won Star Battle!");
                            }
                        }
                        if (score % 5 == 0)
                        {
                            money += 1;
                            MoneyLabel.Text = (money < 10) ? "MONEY: 0" + money.ToString() : "MONEY: " + money.ToString();




                            if (money % 5 == 0)
                            {
                                speedLvl += 1;
                                if (speedLvl < 5)
                                {
                                    SpeedLvlLabel.Text = (speedLvl < 10) ? "SPEED: 0" + speedLvl.ToString() : "SPEED: " + speedLvl.ToString();
                                }
                            }
                            if (money % 20 == 0)
                            {
                                bullets += 1;
                                if (bullets <= 3)
                                {

                                    BulletsLabel.Text = (bullets < 10) ? "BULLETS: 0" + bullets.ToString() : "BULLETS: " + bullets.ToString();
                                }
                            }
                        }
                        //rendering enemies after collision
                        enemies[i].Location = new Point((i + 1) * 50, -100);
                    }
                    
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    //after collision if player still has shield take one from player
                    if (health.GetShieldAmount() > 0)
                    {

                        Player.Location = new Point(587, 453);
                        health.SetShieldAmount((health.GetShieldAmount() - 1));
                        ShieldLabel.Text = "SHIELD: " + health.GetShieldAmount().ToString();
                        
                    }
                    else
                    {
                        //after collision take one life from player
                        if (health.GetLifeAmount() > 0)
                        {
                            Player.Location = new Point(587, 453);
                            health.SetLifeAmount((health.GetLifeAmount() - 1));
                            LifeLabel.Text = "LIFE: " + health.GetLifeAmount().ToString();
                            
                        }
                        else
                        {
                            Player.Visible = false;
                            GameOver("GAME OVER");

                        }

                    }
                }
                

            }
        //loop for meeors
            for(int i = 0; i < meteors.Length; i++)
            {

                if (Player.Bounds.IntersectsWith(meteors[i].Bounds))
                {
                    if (health.GetShieldAmount() > 0)
                    {

                        Player.Location = new Point(587, 453);
                        health.SetShieldAmount((health.GetShieldAmount() - 1));
                        ShieldLabel.Text = "SHIELD: " + health.GetShieldAmount().ToString();
                    }
                    else
                    {
                        //after collision take one life from player
                        if (health.GetLifeAmount() > 0)
                        {
                            Player.Location = new Point(587, 453);
                            health.SetLifeAmount((health.GetLifeAmount() - 1));
                            LifeLabel.Text = "LIFE: " + health.GetLifeAmount().ToString();
                            
                        }
                        else
                        {
                            Player.Visible = false;
                            GameOver("GAME OVER");
                        }

                    }
                }
            }
        }

        #region Timers on/off Methods

        /// <summary>
        /// Stop game means stopping each timer, and also display on screen text and buttons, after collision, also radio buttons are enabled
        /// </summary>
        /// <param name="str"></param>
        private void GameOver(String str)
        {
            highScores = new BestScore(score);

            ScoresList.Add(highScores.GetScore());//adding scores to list



            label1.Text = str;
            label1.BackColor = Color.FromName(background.GetColorBackground());
            label1.Location = new Point(this.Width / 2 - 120, 150);
            label1.Visible = true;
            
            ReplayButton.Location = new Point(this.Width / 2 - 120, 250);
            ReplayButton.Visible = true;

            EndButton.Location = new Point(this.Width / 2 - 120, 350);
            EndButton.Visible = true;

            ScoresButton.Visible = true;
            ScoresButton.Enabled = true;
            StopTimers();

            ON_Radio_Buttons();
        }
        
        /// <summary>
        /// stop timers method, timers are responsible for rendering graphic
        /// </summary>
        private void StopTimers()
        {
            MoveBackground.Stop();
            RightTimer.Stop();
            LeftTimer.Stop();
            MoveEnemiesTimer.Stop();
            MunitionTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }
        
        /// <summary>
        /// start timers method
        /// </summary>
        private void StartTimers()
        {
            MoveBackground.Start();
            MoveEnemiesTimer.Start();
            MunitionTimer.Start();
            EnemiesMunitionTimer.Start();
        }
        
        #endregion

        /// <summary>
        /// method responsible for rendering enemies ammo, method based on timer, and connected with collisions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            //with next levels, difficulty decrease itself, but it cause more bullets from enemies, so it is improving of difficulty in game
            for (int i=0; i < enemiesMunitions.Length - difficulty; i++)
            {
                if(enemiesMunitions[i].Top < this.Height)
                {
                    enemiesMunitions[i].Visible = true;
                    enemiesMunitions[i].Top += enemyBullet.GetBullets(); 
                }
                else
                {
                    enemiesMunitions[i].Visible = false;
                    int x = rand.Next(0, amountEnemy.GetAmount());
                    enemiesMunitions[i].Location = new Point(enemies[x].Location.X , enemies[x].Location.Y + 30);
                }
            }
            EnemiesMunitionCollision();
        }
    
        /// <summary>
        /// method responsible for collision enemies ammo with player ship
        /// </summary>
        private void EnemiesMunitionCollision()
        {
            
            for (int i = 0; i< enemiesMunitions.Length; i++)
            {
                if(enemiesMunitions[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    if (health.GetShieldAmount() > 0)
                    {

                        Player.Location = new Point(587, 453);
                        health.SetShieldAmount((health.GetShieldAmount() - 1));
                        ShieldLabel.Text = "SHIELD: " + health.GetShieldAmount().ToString();
                        //after collision sound
                        boom.controls.play();
                    }
                    else
                    {
                        //after collision take one life from player
                        if (health.GetLifeAmount() > 0)
                        {
                            Player.Location = new Point(587, 453);
                            health.SetLifeAmount((health.GetLifeAmount() - 1));
                            LifeLabel.Text = "LIFE: " + health.GetLifeAmount().ToString();
                            //after collision sound
                            boom.controls.play();
                        }
                        else
                        {
                            Player.Visible = false;
                            GameOver("GAME OVER");
                            //after collision sound
                            boom.controls.play();
                        }

                    }


                }
            }

        }

        #endregion

        #region Buttons methods


        /// <summary>
        /// Method to operate event of Button Best scores, it's output is score form last few games
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoresButton_Click(object sender, EventArgs e)
        {

            List<string> scoresHierarchy = new List<string>();
            //MessageBox.Show(JakubKazimierskiGame.Properties.Resources.ScoresFile);
            //MessageBox.Show(ScoresList[0].ToString());
            StreamWriter writer = new StreamWriter(@"ScoresFile.txt");

            for (int i = 0; i < ScoresList.Count; i++)
            {

                writer.WriteLine(ScoresList[i].ToString());
            }


            writer.Close();


            int hierarchy = 1;
            StreamReader reader = new StreamReader(@"ScoresFile.txt");

            while (!reader.EndOfStream)
            {
                scoresHierarchy.Add(hierarchy.ToString() + " : " + reader.ReadLine());
                hierarchy++;
            }
            reader.Close();

            StreamWriter writerForFinalyScores = new StreamWriter(@"ScoresFile.txt");

            for (int i = 0; i < scoresHierarchy.Count; i++)
            {

                writerForFinalyScores.WriteLine(scoresHierarchy[i].ToString());
            }

            writerForFinalyScores.Close();

            string textScores = System.IO.File.ReadAllText(@"ScoresFile.txt");

            MessageBox.Show(textScores);



        }


        /// <summary>
        /// method responsible for using replay button, program didn't render proper name, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ScoresButton.Enabled = false;
            if (EasyModeRadioButton.Enabled == false && MediumModeRadioButton.Enabled == false && HardModeRadioButton.Enabled == false)
            {

                this.Controls.Clear();
                InitializeComponent();
                Form1_Load(e, e);
                StopTimers();
                StartTimers();
                Off_Radio_Buttons();
                

            }
            else
            {
                MessageBox.Show("Choose difficulty mode");
            }
        }
        /// <summary>
        /// method responsible for using end button, program didn't render proper name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        #endregion

        #region BackroundModeMethodsOfRadioButons
        
        /// <summary>
        /// Method to enable easy mode background and game itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EasyModeRadioButton_Click(object sender, EventArgs e)
        {
            Off_Radio_Buttons();
            EasyModeFlag = true;
            background = new DifficultyModeBackground("Black", 4);
            health = new HealthFromDifficultyMode(2,0);
            bulletsPlayer = new BulletsFromDifficultyMode(1);
            speedPlayer = new SpeedFromDifficultyMode(4);
            enemyBullet = new EnemyBulletsFromDifficultyMode(4);
            speedEnemy = new EnemySpeedFromDifficultyMode(4);
            amountEnemy = new EnemyAmountFromDifficultyMode(8);
        
            ReplayButton.Location = new Point(this.Width / 2 - 120, 250);
            ReplayButton.Visible = true;

        }

        /// <summary>
        /// Method to enable medium mode background and game itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumModeRadioButton_Click(object sender, EventArgs e)
        {
            Off_Radio_Buttons();
            MediumModeFlag = true;
            background = new DifficultyModeBackground("DarkBlue", 7);
            health = new HealthFromDifficultyMode(3,1);
            bulletsPlayer = new BulletsFromDifficultyMode(2);
            speedPlayer = new SpeedFromDifficultyMode(6);
            enemyBullet = new EnemyBulletsFromDifficultyMode(6);
            speedEnemy = new EnemySpeedFromDifficultyMode(6);
            amountEnemy = new EnemyAmountFromDifficultyMode(9);

            ReplayButton.Location = new Point(this.Width / 2 - 120, 250);
            ReplayButton.Visible = true;


        }

        /// <summary>
        /// Method to enable Hard mode background and game itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardModeRadioButton_Click(object sender, EventArgs e)
        {   
            Off_Radio_Buttons();
            HardModeFlag = true;
            background = new DifficultyModeBackground("MidnightBlue", 9);
            health = new HealthFromDifficultyMode(4,2);
            bulletsPlayer = new BulletsFromDifficultyMode(3);
            speedPlayer = new SpeedFromDifficultyMode(8);
            enemyBullet = new EnemyBulletsFromDifficultyMode(8);
            speedEnemy = new EnemySpeedFromDifficultyMode(8);
            amountEnemy = new EnemyAmountFromDifficultyMode(10);

            ReplayButton.Location = new Point(this.Width / 2 - 120, 250);
            ReplayButton.Visible = true;

        }

        /// <summary>
        /// Mehod to disable radio buttons
        /// </summary>
        public void Off_Radio_Buttons()
        {
            EasyModeRadioButton.Enabled = false;
            MediumModeRadioButton.Enabled = false;
            HardModeRadioButton.Enabled = false;
            
        }
        /// <summary>
        /// method to enable radio buttons
        /// </summary>
        public void ON_Radio_Buttons()
        {
            EasyModeRadioButton.Enabled = true;
            MediumModeRadioButton.Enabled = true;
            HardModeRadioButton.Enabled = true;

        }
        #endregion

        #region HelperMethodOfCreatingImages

        /// <summary>
        /// Method to order which enemy has which image
        /// </summary>
        public void CreateEnemiesImage()
        {
            if(EasyModeFlag == true)
            {
                for (int i = 0; i < amountEnemy.GetAmount(); i++)
                {
                    if (i % 2 == 0)
                    {
                        enemies[i].Image = enemi1;
                    }
                    else
                    {
                        enemies[i].Image = enemi2;
                    }
                }
                EasyModeFlag = false;
            }
            if(MediumModeFlag == true)
            {
                for (int i = 0; i < amountEnemy.GetAmount(); i++)
                {
                    if (i % 2 == 0)
                    {
                        enemies[i].Image = enemi2;
                    }
                    else
                    {
                        enemies[i].Image = enemi3;
                    }
                }
                MediumModeFlag = false;
            }
            if(HardModeFlag == true)
            {
                for (int i = 0; i < amountEnemy.GetAmount(); i++)
                {
                    if (i % 2 == 0)
                    {
                        enemies[i].Image = boss1;
                    }
                    else
                    {
                        enemies[i].Image = boss2;
                    }
                }
                HardModeFlag = false;
            }
        }
        #endregion




    }
}
