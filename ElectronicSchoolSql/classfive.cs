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
    public partial class classfive : Form
    {
        public classfive()
        {
            InitializeComponent();
        }
        const string XMLDOCFILEPATGHORAN = "dbfigh.xml";
        const string XMLDOCFILEPATR = "dbfir.xml";
        const string XMLDOCFILEPATO = "dbfio.xml";
        const string XMLDOCFILEPATB = "dbfib.xml";
        const string XMLDOCFILEPATBE = "dbfibe.xml";
        XDocument doc;
        

        
        private void Refreshbe()
        {
            doc = XDocument.Load(XMLDOCFILEPATBE);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,
               
                description = (string)emp.Element("description").Value


            });

            this.dataGridView5.DataSource = q.ToList();
            dataGridView5.Columns[0].Visible = false;
            
        }

        private void RefreshXDoc()
        {
            doc = XDocument.Load(XMLDOCFILEPATGHORAN);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,
               
                description = (string)emp.Element("description").Value


            });

            this.dataGridView1.DataSource = q.ToList();
            dataGridView1.Columns[0].Visible = false;
            
        }
        private void Refreshr()
        {
            doc = XDocument.Load(XMLDOCFILEPATR);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView2.DataSource = q.ToList();
            dataGridView2.Columns[0].Visible = false;

        }
        private void Refresho()
        {
            doc = XDocument.Load(XMLDOCFILEPATO);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView3.DataSource = q.ToList();
            dataGridView3.Columns[0].Visible = false;

        }
        private void Refreshb()
        {
            doc = XDocument.Load(XMLDOCFILEPATB);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView4.DataSource = q.ToList();
            dataGridView4.Columns[0].Visible = false;

        }
        private void frmClassOne_Load(object sender, EventArgs e)
        {
            RefreshXDoc();

            //dataGridView1.Columns[0].HeaderText = "id";
            //dataGridView1.Columns[0].Width = 150;
            //dataGridView1.Columns[1].HeaderText = "نام درس";
            //dataGridView1.Columns[1].Width = 200;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[2].HeaderText = "id";
            //dataGridView1.Columns[2].Width = 20;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //var oDept = doc.Descendants().Elements("lesson")
            //           .Where(d => d.Attribute("id").Value == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
            //           .FirstOrDefault();
           var oDept  = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
              panel1.Controls.Add(axShockwaveFlash1);
      axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + "main.swf";
      
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

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                RefreshXDoc();
            }else if(tabControl1.SelectedTab.Name == "tabPage2")
             
            {
                Refreshr();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                Refresho();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                Refreshb();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                Refreshbe();
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

        private void classfive_Load(object sender, EventArgs e)
        {
            RefreshXDoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

       

       
    }
    
}
