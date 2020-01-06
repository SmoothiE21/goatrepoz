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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();

        }

        private void TwoPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 oo = new Form2();
            oo.Show();
            
      
        }

        private void InstructionsGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions pp = new Instructions();
            pp.Show();

        }
    }
}
