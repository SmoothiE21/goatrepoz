namespace WindowsFormsApp1
{
    partial class select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(select));
            this.Hard = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.Button();
            this.InstructionsGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.SystemColors.Info;
            this.Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.Location = new System.Drawing.Point(278, 146);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(191, 47);
            this.Hard.TabIndex = 0;
            this.Hard.Text = "Hard Level";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.SinglePlayer_Click);
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.SystemColors.Info;
            this.Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.Location = new System.Drawing.Point(278, 214);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(191, 50);
            this.Easy.TabIndex = 1;
            this.Easy.Text = "Easy Level";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.TwoPlayer_Click);
            // 
            // InstructionsGame
            // 
            this.InstructionsGame.BackColor = System.Drawing.SystemColors.Info;
            this.InstructionsGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsGame.Location = new System.Drawing.Point(278, 74);
            this.InstructionsGame.Name = "InstructionsGame";
            this.InstructionsGame.Size = new System.Drawing.Size(191, 47);
            this.InstructionsGame.TabIndex = 2;
            this.InstructionsGame.Text = "Instructions";
            this.InstructionsGame.UseVisualStyleBackColor = false;
            this.InstructionsGame.Click += new System.EventHandler(this.InstructionsGame_Click);
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstructionsGame);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Hard);
            this.Name = "select";
            this.Text = "select";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button InstructionsGame;
    }
}