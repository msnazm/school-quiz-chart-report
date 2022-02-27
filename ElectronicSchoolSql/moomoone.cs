using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ElectronicSchoolSql
{
    public partial class moomoone : Form
    {
        const string XMLDOCFILEPAONE = "dbdaonefizik.xml";
        const string XMLDOCFILEPATWO = "daoner.xml";
        const string XMLDOCFILEPATHREE = "daonearabi.xml";
        const string XMLDOCFILEPAFURE = "daoneo.xml";
        const string XMLDOCFILEPAFIVE = "daonefizikaz.xml";
      
        XDocument doc;

        public moomoone()
        {
            InitializeComponent();
     
        }

        private void RefreshDone()
        {
            doc = XDocument.Load(XMLDOCFILEPAONE);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView1.DataSource = q.ToList();
            dataGridView1.Columns[0].Visible = false;

        }
        private void RefreshDtwo()
        {
            doc = XDocument.Load(XMLDOCFILEPATWO);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView2.DataSource = q.ToList();
            dataGridView2.Columns[0].Visible = false;

        }
        private void RefreshDthree()
        {
            doc = XDocument.Load(XMLDOCFILEPATHREE);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView3.DataSource = q.ToList();
            dataGridView3.Columns[0].Visible = false;

        }
        private void RefreshDfure()
        {
            doc = XDocument.Load(XMLDOCFILEPAFURE);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView4.DataSource = q.ToList();
            dataGridView4.Columns[0].Visible = false;

        }
        private void RefreshDfive()
        {
            doc = XDocument.Load(XMLDOCFILEPAFIVE);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView5.DataSource = q.ToList();
            dataGridView5.Columns[0].Visible = false;

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var oDept = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
            
        }




        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
          
        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                RefreshDone();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                RefreshDtwo();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                RefreshDthree();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                RefreshDfure();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                RefreshDfive();
            }
        }

       

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
           
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
           
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";

        }

        private void moomoone_Load(object sender, EventArgs e)
        {
            RefreshDone();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

    }
}
