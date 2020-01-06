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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void BackInstr_Click(object sender, EventArgs e)
        {
            this.Hide();
            select ff = new select();
            ff.Show();
            ff.Show();
        }
    }
}
