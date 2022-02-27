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
    public partial class frmidquiz : Form
    {
        public frmidquiz()
        {
            InitializeComponent();
        }

        private void frmidquiz_Load(object sender, EventArgs e)
        {
          
        }

        private void dgidquiz_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void mnugho_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\Quran_paye_5\main.swf";
        }

        private void فارسیبخوانیمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\farsi_bekhanim_paye_5\main.swf";
        }

        private void فارسیبنویسیمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\farsi_benevisim_paye_5\main.swf";
        }

        private void ریاضیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\riazi_paye_5\main.swf";
        }

        private void علومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\Olom_tajrobi_paye_5\main.swf";
        }

        private void تعلیماتاجتماعیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\TalimatEjtemaee_paye_5\main.swf";
        }

        private void هدیههایآسمانیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\Hadyeha_book_paye_5\main.swf";
        }

        private void هدیههایآسمانیکتابکارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\Hadyeha_workbook_paye_5\main.swf";
        }

       
    }
}
