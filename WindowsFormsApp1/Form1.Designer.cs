namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.write1 = new System.Windows.Forms.TextBox();
            this.write2 = new System.Windows.Forms.TextBox();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Login1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // write1
            // 
            this.write1.BackColor = System.Drawing.SystemColors.Info;
            this.write1.Location = new System.Drawing.Point(403, 86);
            this.write1.Name = "write1";
            this.write1.Size = new System.Drawing.Size(196, 20);
            this.write1.TabIndex = 0;
            // 
            // write2
            // 
            this.write2.BackColor = System.Drawing.SystemColors.Info;
            this.write2.Location = new System.Drawing.Point(403, 145);
            this.write2.Name = "write2";
            this.write2.Size = new System.Drawing.Size(196, 20);
            this.write2.TabIndex = 1;
            // 
            // Exit1
            // 
            this.Exit1.BackColor = System.Drawing.SystemColors.Info;
            this.Exit1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Exit1.Location = new System.Drawing.Point(403, 210);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(75, 23);
            this.Exit1.TabIndex = 2;
            this.Exit1.Text = "E&XIT";
            this.Exit1.UseVisualStyleBackColor = false;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Login1
            // 
            this.Login1.BackColor = System.Drawing.SystemColors.Info;
            this.Login1.Location = new System.Drawing.Point(524, 210);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(75, 23);
            this.Login1.TabIndex = 3;
            this.Login1.Text = "LOGIN";
            this.Login1.UseVisualStyleBackColor = false;
            this.Login1.Click += new System.EventHandler(this.Login1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.Info;
            this.name.Location = new System.Drawing.Point(263, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 13);
            this.name.TabIndex = 4;
            this.name.Text = "USERNAME";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.SystemColors.Info;
            this.pass.Location = new System.Drawing.Point(263, 148);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(70, 13);
            this.pass.TabIndex = 5;
            this.pass.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 52);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.write2);
            this.Controls.Add(this.write1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox write1;
        private System.Windows.Forms.TextBox write2;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Login1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

