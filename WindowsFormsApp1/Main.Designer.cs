namespace WindowsFormsApp1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.points = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.enemytimer = new System.Windows.Forms.Timer(this.components);
            this.fire1 = new System.Windows.Forms.Timer(this.components);
            this.fire2 = new System.Windows.Forms.Timer(this.components);
            this.fire3 = new System.Windows.Forms.Timer(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.goat2 = new System.Windows.Forms.PictureBox();
            this.goat1 = new System.Windows.Forms.PictureBox();
            this.rocket3 = new System.Windows.Forms.PictureBox();
            this.rocket2 = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.boss = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.fighter = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.Ex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighter)).BeginInit();
            this.SuspendLayout();
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.Color.DarkViolet;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.Yellow;
            this.points.Location = new System.Drawing.Point(927, 434);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(40, 42);
            this.points.TabIndex = 7;
            this.points.Text = "0";
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Red;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Yellow;
            this.over.Location = new System.Drawing.Point(297, 55);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(281, 55);
            this.over.TabIndex = 8;
            this.over.Text = "Game Over";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Green;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(328, 158);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(219, 54);
            this.restart.TabIndex = 9;
            this.restart.Text = "Restart Game";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // enemytimer
            // 
            this.enemytimer.Enabled = true;
            this.enemytimer.Interval = 10;
            this.enemytimer.Tick += new System.EventHandler(this.enemytimer_Tick);
            // 
            // fire1
            // 
            this.fire1.Interval = 10;
            this.fire1.Tick += new System.EventHandler(this.fire1_Tick);
            // 
            // fire2
            // 
            this.fire2.Interval = 10;
            this.fire2.Tick += new System.EventHandler(this.fire2_Tick);
            // 
            // fire3
            // 
            this.fire3.Interval = 10;
            this.fire3.Tick += new System.EventHandler(this.fire3_Tick);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Blue;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close.Location = new System.Drawing.Point(615, 158);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(219, 54);
            this.Close.TabIndex = 15;
            this.Close.Text = "Save Score";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // goat2
            // 
            this.goat2.Image = global::WindowsFormsApp1.Properties.Resources.goat;
            this.goat2.Location = new System.Drawing.Point(807, 404);
            this.goat2.Name = "goat2";
            this.goat2.Size = new System.Drawing.Size(100, 50);
            this.goat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goat2.TabIndex = 20;
            this.goat2.TabStop = false;
            // 
            // goat1
            // 
            this.goat1.Image = global::WindowsFormsApp1.Properties.Resources.goat;
            this.goat1.Location = new System.Drawing.Point(760, 144);
            this.goat1.Name = "goat1";
            this.goat1.Size = new System.Drawing.Size(100, 50);
            this.goat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goat1.TabIndex = 19;
            this.goat1.TabStop = false;
            // 
            // rocket3
            // 
            this.rocket3.Image = global::WindowsFormsApp1.Properties.Resources.rocket;
            this.rocket3.Location = new System.Drawing.Point(766, 335);
            this.rocket3.Name = "rocket3";
            this.rocket3.Size = new System.Drawing.Size(94, 22);
            this.rocket3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket3.TabIndex = 18;
            this.rocket3.TabStop = false;
            // 
            // rocket2
            // 
            this.rocket2.Image = global::WindowsFormsApp1.Properties.Resources.rocket;
            this.rocket2.Location = new System.Drawing.Point(683, 42);
            this.rocket2.Name = "rocket2";
            this.rocket2.Size = new System.Drawing.Size(90, 21);
            this.rocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket2.TabIndex = 17;
            this.rocket2.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.Image = global::WindowsFormsApp1.Properties.Resources.rocket;
            this.rocket.Location = new System.Drawing.Point(820, 276);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(100, 22);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket.TabIndex = 16;
            this.rocket.TabStop = false;
            // 
            // boss
            // 
            this.boss.Image = global::WindowsFormsApp1.Properties.Resources.monster1;
            this.boss.Location = new System.Drawing.Point(890, 176);
            this.boss.Name = "boss";
            this.boss.Size = new System.Drawing.Size(67, 64);
            this.boss.TabIndex = 13;
            this.boss.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.Image = ((System.Drawing.Image)(resources.GetObject("bullet3.Image")));
            this.bullet3.Location = new System.Drawing.Point(221, 190);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(39, 22);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet3.TabIndex = 12;
            this.bullet3.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.Image = ((System.Drawing.Image)(resources.GetObject("bullet2.Image")));
            this.bullet2.Location = new System.Drawing.Point(249, 140);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(39, 24);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet2.TabIndex = 11;
            this.bullet2.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.Image = ((System.Drawing.Image)(resources.GetObject("bullet1.Image")));
            this.bullet1.Location = new System.Drawing.Point(164, 154);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(39, 24);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet1.TabIndex = 10;
            this.bullet1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::WindowsFormsApp1.Properties.Resources.helicopter;
            this.enemy2.Location = new System.Drawing.Point(553, 144);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(69, 34);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = global::WindowsFormsApp1.Properties.Resources.helicopter1;
            this.enemy4.Location = new System.Drawing.Point(716, 218);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(57, 35);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy4.TabIndex = 5;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.Image = global::WindowsFormsApp1.Properties.Resources.jet_fighter1;
            this.enemy5.Location = new System.Drawing.Point(651, 349);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(59, 36);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy5.TabIndex = 4;
            this.enemy5.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::WindowsFormsApp1.Properties.Resources.jet_fighter;
            this.enemy3.Location = new System.Drawing.Point(581, 255);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(79, 40);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy3.TabIndex = 2;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::WindowsFormsApp1.Properties.Resources.jet_fighter;
            this.enemy1.Location = new System.Drawing.Point(766, 83);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(81, 41);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // fighter
            // 
            this.fighter.Image = global::WindowsFormsApp1.Properties.Resources.goat;
            this.fighter.Location = new System.Drawing.Point(22, 162);
            this.fighter.Name = "fighter";
            this.fighter.Size = new System.Drawing.Size(100, 50);
            this.fighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fighter.TabIndex = 0;
            this.fighter.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(52, 158);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(219, 54);
            this.Back.TabIndex = 21;
            this.Back.Text = "Back to Menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Ex
            // 
            this.Ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex.Location = new System.Drawing.Point(328, 255);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(219, 55);
            this.Ex.TabIndex = 23;
            this.Ex.Text = "Exit";
            this.Ex.UseVisualStyleBackColor = false;
            this.Ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.goat2);
            this.Controls.Add(this.goat1);
            this.Controls.Add(this.rocket3);
            this.Controls.Add(this.rocket2);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.boss);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.over);
            this.Controls.Add(this.points);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.fighter);
            this.Name = "Main";
            this.Text = "GoatGame";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.goat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fighter;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.Timer enemytimer;
        private System.Windows.Forms.Timer fire1;
        private System.Windows.Forms.Timer fire2;
        private System.Windows.Forms.Timer fire3;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.PictureBox rocket2;
        private System.Windows.Forms.PictureBox rocket3;
        private System.Windows.Forms.PictureBox goat1;
        private System.Windows.Forms.PictureBox goat2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Ex;
    }
}