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
    public partial class rahtwo : Form
    {
        public rahtwo()
        {
            InitializeComponent();
        }
        const string XMLDOCFILEPATO = "dbrahtwoo.xml";
        XDocument doc;





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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                Refresho();
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

        private void rahtwo_Load(object sender, EventArgs e)
        {
            Refresho();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
