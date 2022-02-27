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
    public partial class rahtree : Form
    {
        public rahtree()
        {
            InitializeComponent();
        }
         const string XMLDOCFILEPATAMADEGI = "dbrahtreeamadegi.xml";
        const string XMLDOCFILEPATO = "dbrahtreeo.xml";
        const string XMLDOCFILEPATR = "dbrahtreer.xml";
        const string XMLDOCFILEPATARABI = "dbrahtreearabi.xml";
        const string XMLDOCFILEPATZABAN = "dbrahtreezaban.xml";
        const string XMLDOCFILEPATGHO = "dbrahtreegho.xml";
        XDocument doc;
        

        
        private void Refreshzaban()
        {
            doc = XDocument.Load(XMLDOCFILEPATZABAN);

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
            doc = XDocument.Load(XMLDOCFILEPATAMADEGI);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,
               
                description = (string)emp.Element("description").Value


            });

            this.dataGridView1.DataSource = q.ToList();
            dataGridView1.Columns[0].Visible = false;
            
        }
        private void Refresho()
        {
            doc = XDocument.Load(XMLDOCFILEPATO);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView2.DataSource = q.ToList();
            dataGridView2.Columns[0].Visible = false;

        }
        private void Refreshr()
        {
            doc = XDocument.Load(XMLDOCFILEPATR);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView3.DataSource = q.ToList();
            dataGridView3.Columns[0].Visible = false;

        }
        private void Refresharabi()
        {
            doc = XDocument.Load(XMLDOCFILEPATARABI);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView4.DataSource = q.ToList();
            dataGridView4.Columns[0].Visible = false;

        }
         private void Refreshgho()
        {
            doc = XDocument.Load(XMLDOCFILEPATGHO);

            var q = doc.Descendants().Elements("lesson").Select(emp => new
            {
                id = emp.Attribute("id").Value,

                description = (string)emp.Element("description").Value


            });

            this.dataGridView6.DataSource = q.ToList();
            dataGridView6.Columns[0].Visible = false;

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

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
           
        }

       private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                Refresho();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                Refreshr();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                Refresharabi();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                Refreshzaban();
            }
            else if (tabControl1.SelectedTab.Name == "tabPage6")
            {
                Refreshgho();
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

       

        private void rahtree_Load(object sender, EventArgs e)
        {
             RefreshXDoc();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

       

       
    }
    
   
}
