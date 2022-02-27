using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSchoolSql
{
    public partial class r : Form
    {
        public r()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034000.swf";
           // axShockwaveFlash1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034001.swf";
            axShockwaveFlash1.Play();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuadd_Click(object sender, EventArgs e)
        {

          
        }

        private void کسرهایمتعارفیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034001.swf";
        }

        private void کسرهایمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034002.swf";
        }

        private void جمعوتفریقکسرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034003.swf";
        }

        private void هکتارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034004.swf";
        }

        private void جمعوتفریقمخلوطهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034005.swf";
        }

        private void نسبتوتناسبونسبتهایمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034006.swf";
        }

        private void ساعتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034007.swf";
        }

        private void ضربتقریبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034008.swf";
        }

        private void مساحتلوزیوذوزنقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034009.swf";
        }

        private void درصدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034010.swf";
        }

        private void تقارنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034011.swf";
        }

        private void جمعوتفریقاعداداعشاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034012.swf";
        }

        private void ضربکسرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034013.swf";
        }

        private void ضرباعداداعشاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034014.swf";
        }

        private void زاویهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034015.swf";
        }

        private void حجمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034016.swf";
        }

        private void معدلمیانگینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034017.swf";
        }

        private void مساحتدایرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034018.swf";
        }

        private void تقسیمکسرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034019.swf";
        }

        private void محیطدایرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034020.swf";
        }

        private void نشاندادنخطتقارنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034021.swf";
        }

        private void شناختاشکالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034022.swf";
        }

        private void شمارشوشناختاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034023.swf";
        }

        private void شمارشوشناختاعداددوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034024.swf";
        }

        private void محاسبهوشناختمساحتومحیطدایرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034025.swf";
        }

        private void آموزشخواندنساعتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034026.swf";
        }

        private void تقسیماعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034027.swf";
        }

        private void شناختمثلثواضلاعآنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034028.swf";
        }

        private void شناختاشکالهندسیومشخصاتآنهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034029.swf";
        }

        private void شناختچندضلعیهاومحاسبهمساحتآنهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034030.swf";
        }

        private void شناختچندضلعیهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034031.swf";
        }

        private void شناختدرجهداخلیاضلاعاشکالهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034032.swf";
        }

        private void تبدیلاشکالهندسیبهیکدیگرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034033.swf";
        }

        private void دروسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\01034000.swf";
        }

        private void معرفیکسرهابوسیلهشکلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034034.swf";
        }

        private void محاسبهمحیطومساحتاشکالهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034035.swf";
        }

        private void محاسبهکسرواعشارودرصداعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034036.swf";
        }

        private void مقایسهکسرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034037.swf";
        }

        private void انواعکسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034038.swf";
        }

        private void کسرهایمعادلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034039.swf";
        }

        private void زوایاودرجاتآنهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034040.swf";
        }

        private void زوایاودرجاتآنهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034041.swf";
        }

        private void تبدیلواحدهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034042.swf";
        }

        private void شکلوقرینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034043.swf";
        }

        private void تعادلاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034044.swf";
        }

        private void جمعضربتقسیمتفریقاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034045.swf";
        }

        private void جمعاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034046.swf";
        }

        private void خطپارهخطاشکالهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034047.swf";
        }

        private void دهگاناعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034048.swf";
        }

        private void ضرباعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034049.swf";
        }

        private void آموزشوشناختمفهومارزشمکانیاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034050.swf";
        }

        private void آموزشاحجامواشکالهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034051.swf";
        }

        private void مفهومحجمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034052.swf";
        }

        private void مفهوممکعبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034053.swf";
        }

        private void مفهوممکعبمستطیلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034054.swf";
        }

        private void مفهومچهاروجهیمنتظمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034055.swf";
        }

        private void واحداندازهگیریحجمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034056.swf";
        }

        private void محاسبهحجممکعبمستطیلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034057.swf";
        }

        private void محاسبهحجممکعبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034058.swf";
        }

        private void مفهومبخشپذیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034059.swf";
        }

        private void آموزشبخشپذیریبر2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034060.swf";
        }

        private void آموزشبخشپذیریبر3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034061.swf";
        }

        private void آموزشبخشپذیریبر6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034062.swf";
        }

        private void آموزشبخشپذیریبر9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034063.swf";
        }

        private void آموزشبخشپذیریبر5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034064.swf";
        }

        private void آموزشبخشپذیریبر10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034065.swf";
        }

        private void آموزشبخشپذیریبر15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034066.swf";
        }

        private void بررسیاطلاعاتمعدلیامیانگینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034067.swf";
        }

        private void رسمدایرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034068.swf";
        }

        private void شعاعوقطردایرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034069.swf";
        }

        private void معرفیمفهومهکتارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034070.swf";
        }

        private void مقایسهعددمخلوطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034071.swf";
        }

        private void جمععددمخلوطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034072.swf";
        }

        private void تفریقعددمخلوطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034073.swf";
        }

        private void ضربعددصحیحدرکسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034074.swf";
        }

        private void ضربکسردرعددصحیحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034075.swf";
        }

        private void ضربکسردرکسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034076.swf";
        }

        private void تقسسیمکسربرکسربامخرجمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034077.swf";
        }

        private void تقسسیمکسربرکسربامخرجنامساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034078.swf";
        }

        private void تقسیمعددصحیحبرکسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034079.swf";
        }

        private void تقسیمدوعددصحیحبخشناپذیرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034080.swf";
        }

        private void تبدیلعددمخلوطبهکسربزرگترازواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034081.swf";
        }

        private void معرفیکسراعشاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034082.swf";
        }

        private void کسرمتعارفیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034083.swf";
        }

        private void کسربرابرواحدوکسربرابرصفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034084.swf";
        }

        private void کسرمتعارفیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034085.swf";
        }

        private void کسربزرگترازواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034086.swf";
        }

        private void جمعکسرمتعارفیبامخرجمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034087.swf";
        }

        private void مقایسهکسرهابامخرجمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034088.swf";
        }

        private void تفریقکسرمتعارفیبامخرجمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034089.swf";
        }

        private void معرفیعددمخلوطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034090.swf";
        }

        private void تبدیلکسربزرگترازواحدبهعددمخلوطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034091.swf";
        }

        private void تبدیلکسربزرگترازواحدبهعددمخلوطToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034092.swf";
        }

        private void کسرهایمساویوسادهکردنکسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034093.swf";
        }

        private void جمعوتفریقکسرهایمتعارفیبامخرجهاینامساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034094.swf";
        }

        private void مقایسهکسرهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034095.swf";
        }

        private void مقایسهکسرهابامخرجنامساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034096.swf";
        }

        private void مساحتدایرهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034097.swf";
        }

        private void مساحتلوزیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034098.swf";
        }

        private void مساحتذوزنقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034099.swf";
        }

        private void نسبتوتناسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034100.swf";
        }

        private void نسبتمساویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034101.swf";
        }

        private void کاربردنسبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034102.swf";
        }

        private void درصدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034103.swf";
        }

        private void محاسبهسودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034104.swf";
        }

        private void درصددادهشدهمقدارخواستهشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034105.swf";
        }

        private void مقداردادهشدهدرصدخواستهشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034106.swf";
        }

        private void مبلغپرداختیدادهشدهقیمتکلخواستهشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034107.swf";
        }

        private void رسممثلثبوسیلهپرگارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034108.swf";
        }

        private void رسممثلثبوسیلهنقالهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034109.swf";
        }

        private void رسممثلثبوسیلهنقالهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034110.swf";
        }

        private void عددمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034111.swf";
        }

        private void جمععددمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034112.swf";
        }

        private void مقایسهعددمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034113.swf";
        }

        private void تفریقعددمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034114.swf";
        }

        private void تقارنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034115.swf";
        }

        private void تخمینضربتقریبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034116.swf";
        }

        private void ضربذهنیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034117.swf";
        }

        private void زاویهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034118.swf";
        }

        private void واحداندازهگیریزاویهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034119.swf";
        }

        private void وسیلهاندازهگیریزاویهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034120.swf";
        }

        private void مجموعزاویههایداخلیمثلثToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034121.swf";
        }

        private void کسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034122.swf";
        }

        private void آشناییبااعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034123.swf";
        }

        private void جمعوتفریقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034124.swf";
        }

        private void اشکالهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034125.swf";
        }

        private void جمعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034126.swf";
        }

        private void اشکالهندسیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034127.swf";
        }

        private void جمعوتشخیصمفهومبزرگتروکوچکترToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034128.swf";
        }

        private void جمعباکمکمحورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034129.swf";
        }

        private void جمعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034130.swf";
        }

        private void جمعToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034131.swf";
        }

        private void جمعToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034131.swf";
        }

        private void جمعToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034132.swf";
        }

        private void جمعToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034133.swf";
        }

        private void ساعتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034134.swf";
        }

        private void نقطههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034135.swf";
        }

        private void آشناییبااعدادToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034136.swf";
        }

        private void واحداندازهگیریوزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034137.swf";
        }

        private void اشکالهندسیToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034138.swf";
        }

        private void ماههایسالوفصلهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034139.swf";
        }

        private void ساعتToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034140.swf";
        }

        private void شمارشاعدادوجمعوتفریقاعدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034141.swf";
        }

        private void آشناییبااعدادToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"..\..\..\Resources\02034142.swf";
        }
    }
}
