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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            startgame();
        }

        void startgame()
        {
           
           
            bullet4.Visible = false;
            bullet5.Visible = false;
            bullet6.Visible = false;
            Close.Visible = false;
            Back.Visible = false;
            Ex.Visible = false;
            over.Visible = false;
            restart.Visible = false;
            enemtimer.Enabled = true;




            goat1.Left = 5000;
            enem2.Left = 3000;
            enem3.Left = 4000;
            enem5.Left = 3000;
            boss.Left = 9000;
            goat2.Left = 5000;
            enem9.Left = 2000;
            enem9.Left = 2000;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        int bulletcount1 = 0;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (fighter2.Top > 10)
                    fighter2.Top += -15;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (fighter2.Top < 440)
                    fighter2.Top += 15;

            }

            if (e.KeyCode == Keys.Z)
            {
                if (bulletcount1 % 1 == 0)
                {
                    bullet4.Location = fighter2.Location;
                    fire4.Enabled = true;
                    bulletcount1++;
                }
                else if (bulletcount1 % 2 == 0)
                {
                    bullet5.Location = fighter2.Location;
                    fire5.Enabled = true;
                    bulletcount1++;
                }
                else if (bulletcount1 % 3 == 0)
                {
                    bullet6.Location = fighter2.Location;
                    fire6.Enabled = true;
                    bulletcount1++;
                }


            }
        }

        private void fire4_Tick(object sender, EventArgs e)
        {
            bullet4.Visible = true;
            bullet4.Left += 10;

        }

        private void fire5_Tick(object sender, EventArgs e)
        {
            bullet5.Visible = true;
            bullet5.Left += 10;

        }
        int score1 = 0;
        private void fire6_Tick(object sender, EventArgs e)
        {
            bullet6.Visible = true;
            bullet6.Left += 10;

        }

        private void enemtimer_Tick(object sender, EventArgs e)
        {
            Moveenemy1(goat1);
            Moveenemy1(enem2);
            Moveenemy1(enem3);
            Moveenemy1(enem4);
            Moveenemy1(enem5);
            Moveenemy1(boss);
            Moveenemy1(goat2);
            Moveenemy1(enem8);
            Moveenemy1(enem9);



        }
        Random foc = new Random();

        void Moveenemy1(PictureBox enemyObj)
        {
            if (enemyObj.Left >= 0)
            { enemyObj.Left += -3; }
            else
            {
                enemyObj.Location = new Point(1000, foc.Next(100, 400));
            }




            if (enemyObj.Bounds.IntersectsWith(fighter2.Bounds))
            {
                fighter2.Image = Properties.Resources.explosion;

                
                restart.Visible = true;
                over.Visible = true;
             
                Close.Visible = true;
                Back.Visible = true;
                Ex.Visible = true;
                enemtimer.Enabled = false;



                
                enem2.Visible = false;
                enem3.Visible = false;
                enem4.Visible = false;
                enem5.Visible = false;
                boss.Visible = false;
               enem8.Visible = false;
               enem9.Visible = false;
             
                goat1.Visible = false;
                goat2.Visible = false;





            }


            if ((bullet4.Bounds.IntersectsWith(enemyObj.Bounds)) || (bullet5.Bounds.IntersectsWith(enemyObj.Bounds)) || (bullet6.Bounds.IntersectsWith(enemyObj.Bounds)))
            {
                score1++;
                points1.Text = score1.ToString();

                enemyObj.Location = new Point(1000, foc.Next(100, 400));

            }

        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 oo = new Form2();
            oo.Show();
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            select ff = new select();
            ff.Show();
            ff.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 gg = new Main2();
            gg.Show();
        }
    }
}
