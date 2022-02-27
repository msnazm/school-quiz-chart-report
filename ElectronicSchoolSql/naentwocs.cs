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
    public partial class naentwocs : Form
    {
        const string XMLDOCFILEPAONE = "nazaritwojoghrafi.xml";
        XDocument doc;

        public naentwocs()
        {
            InitializeComponent();
        }

        private void naentwocs_Load(object sender, EventArgs e)
        {
            RefreshDone();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var oDept = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            axShockwaveFlash1.Dispose();
            axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            axShockwaveFlash1.Dock = DockStyle.Fill;
            panel1.Controls.Add(axShockwaveFlash1);
            axShockwaveFlash1.Movie = Application.StartupPath + @"\swfs\" + oDept + ".swf";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
