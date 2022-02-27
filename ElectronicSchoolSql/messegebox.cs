using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectronicSchoolSql
{
    public partial class messegebox : Form
    {
        public messegebox()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messegebox_Load(object sender, EventArgs e)
        {
            label1.Parent = this.pictureBox1;
        }
    }
}
