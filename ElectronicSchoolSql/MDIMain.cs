using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ElectronicSchoolSql
{
    public partial class MDIMain : Form
    {
        

        public MDIMain()
        {
            InitializeComponent();
        }

       
        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new o();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 4, this.Location.Y + (this.Height - childForm.Height) / 4);
            // newquizs.Show();
            childForm.Show();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new b();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 4, this.Location.Y + (this.Height - childForm.Height) / 4);
            // newquizs.Show();
            childForm.Show();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new be();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            // newquizs.Show();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 4, this.Location.Y + (this.Height - childForm.Height) / 4);
            childForm.Show();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void newquiz_Click(object sender, EventArgs e)
        {
            Form childForm = new frmquizs();
            childForm.MdiParent = this;
            //var newquiz = new frmquizs();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) /3);
            childForm.Show();
               
        }

        private void newbook_Click(object sender, EventArgs e)
        {
            Form childForm = new frmbook();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // var newbook = new frmbook();
            childForm.Show();
        }

        private void newquestion_Click(object sender, EventArgs e)
        {
            Form childForm = new frmnewquiz();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // var newquizs = new Form1();
           // newquizs.Show();
            childForm.Show();
        }

        private void mnulesson_Click(object sender, EventArgs e)
        {
            Form childForm = new frmlesson();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            // newquizs.Show();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new gho();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            // newquizs.Show();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new r();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            // newquizs.Show();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Location = new Point(0, 0);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmidquiz();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // var newquizs = new Form1();
            // newquizs.Show();
            childForm.Show();
        }

        private void آزمونهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new SelectQuiz();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void نتایجآزمونهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmresult();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void فالToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void کلاساولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmClassOne();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void کلاسدومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classtwo();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void کلاسسومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classtree();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void کلاسچهارمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classfure();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void کلاسپنجمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classfive();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void کلاسششمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new classsex();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void دومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new rahtwo();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void سومToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new rahtree();
            childForm.MdiParent = this;
            // var newquizs = new Form1();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            // newquizs.Show();
            childForm.Show();
        }

        private void MDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MDIMain f2 = new MDIMain();
          
            //Model = 11;
            
        }

        private void اولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new moomoone();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new faeltwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form childForm = new faelthree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form childForm = new faeltectwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form childForm = new famecanictwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form childForm = new famecanicthree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form childForm = new fathreenaghsheocs();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form childForm = new fasachobthree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form childForm = new fasafelezithree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form childForm = new fatathree();
                        childForm.MdiParent = this;
                        childForm.StartPosition = FormStartPosition.CenterParent;
                        childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
                        childForm.Show();
        }

        private void دومToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form childForm = new facomtwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form childForm = new facomthreecs();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form childForm = new fanaghmemarithree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form childForm = new famafarthree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form childForm = new fakeomotwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form childForm = new fakemathree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form childForm = new naentwocs();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form childForm = new naenthree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form childForm = new narifithree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form childForm = new narifitwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void دومToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form childForm = new natatwo();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void سومToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Form childForm = new natathree();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void ریاضیوفیزیکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new pishrifi();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void تجربیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new pishta();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void تماسباماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new AboutBox();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Location = new Point(this.Location.X + (this.Width - childForm.Width) / 3, this.Location.Y + (this.Height - childForm.Height) / 3);
            childForm.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
    }
}
