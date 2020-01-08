
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        


        public Main()
        {
            InitializeComponent();
            
            startgame();

        }

        void startgame()
        {
            over.Visible = false;
            restart.Visible = false;
            bullet1.Visible = false;
            bullet2.Visible = false;
            bullet3.Visible = false;
            Close.Visible = false;
            Back.Visible = false;
            Ex.Visible = false;



            enemy1.Left = 1000;
            enemy2.Left = 3000;
            enemy3.Left = 4000;
            enemy4.Left = 3000;
            enemy5.Left = 2000;
            boss.Left = 9000;
            rocket.Left = 6000;
            rocket2.Left = 6000;
            rocket3.Left = 6000;
            goat1.Left = 12000;
            goat2.Left = 11000;


        }

        private void Main_Load(object sender, EventArgs e)
        {
            // player.controls.play();

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        int bulletcount = 0;

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (fighter.Top > 10)
                    fighter.Top += -15;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (fighter.Top < 440)
                    fighter.Top += 15;

            }
           
            if (e.KeyCode == Keys.Z)
            {
                if (bulletcount % 1 == 0)
                {
                    bullet1.Location = fighter.Location;
                    fire1.Enabled = true;
                    bulletcount++;
                }
                else if (bulletcount % 2 == 0)
                {
                    bullet2.Location = fighter.Location;
                    fire2.Enabled = true;
                    bulletcount++;
                }
                else if (bulletcount % 3 == 0)
                {
                    bullet3.Location = fighter.Location;
                    fire3.Enabled = true;
                    bulletcount++;
                }


            }
            



        }

        private void fire1_Tick(object sender, EventArgs e)
        {
            bullet1.Visible = true;
            bullet1.Left += 10;
        }

        private void fire2_Tick(object sender, EventArgs e)
        {
            bullet2.Visible = true;
            bullet2.Left += 10;

        }

        private void fire3_Tick(object sender, EventArgs e)
        {
            bullet3.Visible = true;
            bullet3.Left += 10;
        }

        int score = 0;
        private void enemytimer_Tick(object sender, EventArgs e)
        {
            Moveenemy(enemy1);
            Moveenemy(enemy2);
            Moveenemy(enemy3);
            Moveenemy(enemy4);
            Moveenemy(enemy5);
            Moveenemy(boss);
            Moveenemy(rocket);
            Moveenemy(rocket2);
            Moveenemy(rocket3);
            Moveenemy(goat1);
            Moveenemy(goat2);


        }
        Random loc = new Random();

        void Moveenemy(PictureBox enemyObj)
        {
            if (enemyObj.Left >= 0)
            { enemyObj.Left += -4; }
            else 
            {
                enemyObj.Location = new Point(1000, loc.Next(100, 400));
            }


            

            if (enemyObj.Bounds.IntersectsWith(fighter.Bounds))
            {
                fighter.Image = Properties.Resources.explosion;
                restart.Visible = true;
                over.Visible = true;
                enemytimer.Enabled = false;
                Close.Visible = true;
                Back.Visible = true;
                Ex.Visible = true;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                enemy4.Visible = false;
                enemy5.Visible = false;
                boss.Visible = false;
                rocket.Visible = false;
                rocket2.Visible=false;
                rocket3.Visible = false;
                goat1.Visible=false;
                goat2.Visible = false;




            }


            if((bullet1.Bounds.IntersectsWith(enemyObj.Bounds )) || (bullet2.Bounds.IntersectsWith(enemyObj.Bounds)) || (bullet3.Bounds.IntersectsWith(enemyObj.Bounds)))
               {
                score++;
                points.Text = score.ToString();
                
                enemyObj.Location = new Point(1000, loc.Next(100, 400));

            }

        }

        private void restart_Click(object sender, EventArgs e)
        {



            this.Hide();
            Main ss = new Main();
            ss.Show();



        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 gg = new Main2();
            gg.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            select ff = new select();
            ff.Show();
            ff.Show();

        }

        private void Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
    }
       
            

    


