namespace WindowsFormsApp1
{
    partial class Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.OpenF = new System.Windows.Forms.Button();
            this.SaveF = new System.Windows.Forms.Button();
            this.ExitG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // OpenF
            // 
            this.OpenF.BackColor = System.Drawing.SystemColors.Info;
            this.OpenF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenF.Location = new System.Drawing.Point(120, 100);
            this.OpenF.Name = "OpenF";
            this.OpenF.Size = new System.Drawing.Size(132, 43);
            this.OpenF.TabIndex = 0;
            this.OpenF.Text = "OpenFile";
            this.OpenF.UseVisualStyleBackColor = false;
            this.OpenF.Click += new System.EventHandler(this.OpenF_Click);
            // 
            // SaveF
            // 
            this.SaveF.BackColor = System.Drawing.SystemColors.Info;
            this.SaveF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveF.Location = new System.Drawing.Point(120, 149);
            this.SaveF.Name = "SaveF";
            this.SaveF.Size = new System.Drawing.Size(132, 39);
            this.SaveF.TabIndex = 1;
            this.SaveF.Text = "SaveFile";
            this.SaveF.UseVisualStyleBackColor = false;
            this.SaveF.Click += new System.EventHandler(this.SaveF_Click);
            // 
            // ExitG
            // 
            this.ExitG.BackColor = System.Drawing.SystemColors.Info;
            this.ExitG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitG.Location = new System.Drawing.Point(632, 227);
            this.ExitG.Name = "ExitG";
            this.ExitG.Size = new System.Drawing.Size(132, 36);
            this.ExitG.TabIndex = 2;
            this.ExitG.Text = "ExitGame";
            this.ExitG.UseVisualStyleBackColor = false;
            this.ExitG.Click += new System.EventHandler(this.ExitG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nyisd meg az eddigi eredményeid és üsd be az elért pontszámod!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mentsd le a beirt adatokat!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(2, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 256);
            this.textBox1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitG);
            this.Controls.Add(this.SaveF);
            this.Controls.Add(this.OpenF);
            this.Name = "Main2";
            this.Text = "SaveScore";
            this.Load += new System.EventHandler(this.Main2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenF;
        private System.Windows.Forms.Button SaveF;
        private System.Windows.Forms.Button ExitG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}