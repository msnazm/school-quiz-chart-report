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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void newquiz_Click(object sender, EventArgs e)
        {
            Form childForm = new frmquizs();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void mnulesson_Click(object sender, EventArgs e)
        {
            Form childForm = new frmlesson();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void newbook_Click(object sender, EventArgs e)
        {
            Form childForm = new frmbook();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void newquestion_Click(object sender, EventArgs e)
        {
            Form childForm = new frmnewquiz();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void quizsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new SelectQuiz();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void resulttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmresult();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmClassOne();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classtwoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new classtwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classtreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classtree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classfureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classfure();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classfiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classfive();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classsextoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classsex();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void rahtwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new rahtwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classthreeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new rahtree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnaoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new moomoone();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void naentwoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form childForm = new naentwocs();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnaenthreeToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form childForm = new naenthree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnaretwotoolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form childForm = new narifitwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnarithreeToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form childForm = new narifithree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnatatwoToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form childForm = new natatwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void classnatathreeToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Form childForm = new natathree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void faeltwoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new faeltwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void faelthreeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form childForm = new faelthree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void faeltetwoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form childForm = new faeltectwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fametwoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form childForm = new famecanictwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void famethreeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form childForm = new famecanicthree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        

        private void fachobthreeToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form childForm = new fasachobthree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fafelezithreeToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form childForm = new fasafelezithree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fatathreeToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form childForm = new fatathree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void facomtwoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form childForm = new facomtwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void facomthreeToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form childForm = new facomthreecs();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fanaghthreeToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form childForm = new fanaghmemarithree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fanaothreeToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form childForm = new fathreenaghsheocs();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void famathreeToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form childForm = new famafarthree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fakeomortoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form childForm = new fakeomotwo();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void fakemashinthreeToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form childForm = new fakemathree();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void pishriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new pishrifi();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void pishtaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new pishta();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmQuiz();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmhelp();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TamasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new AboutBox();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 2, this.Location.Y + (this.Height - childForm.Height) / 2);
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
      

       

     

      
        
    }
}
