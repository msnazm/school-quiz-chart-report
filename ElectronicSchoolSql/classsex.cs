﻿using System;
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
    public partial class classsex : Form
    {
        public classsex()
        {
            InitializeComponent();
        }
       
        const string XMLDOCFILEPATR = "dbser.xml";
        const string XMLDOCFILEPATO = "dbseo.xml";
        const string XMLDOCFILEPATB = "dbsexb.xml";
        XDocument doc;
        

       

      
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
       

      

       


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var oDept = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Name == "tabPage2")
             
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

        private void classsex_Load(object sender, EventArgs e)
        {
            Refreshr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

       

       
    }
   
}
