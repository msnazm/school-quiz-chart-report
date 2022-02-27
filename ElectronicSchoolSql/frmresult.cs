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
    public partial class frmresult : Form
    {
        public frmresult()
        {
            InitializeComponent();
        }

        private void frmresult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.tbl_result' table. You can move, or remove it, as needed.
            this.tbl_resultTableAdapter.Fill(this.dataDataSet.tbl_result);
            var db = new Data.DataSetLinqDataContext();
            var qry = (from u in db.tbl_results
                       join co in db.tbl_quizs on u.Id_Quiz equals co.Id_Quiz
                       join prod in db.tbl_books on u.Id_Book equals prod.Id_Book
                       join pr in db.tbl_lessons on u.id_lesson equals pr.id_lesson

                       select new {  آزمون  = co.name_quiz,
                           کتاب = prod.name_book,
                                    درس = pr.name_lesson,

                           درست = u.Points_Correct, غلط = u.Points_InCorrect,
                                    زمان = u.Time_Result,
                                    تاریخ = u.date_t
                       }).ToList();

           
            dataGridView1.DataSource = qry;
            this.chart1.DataBind();
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            label3.Parent = this.pictureBox1;
           
            //this.chart1.DataBind();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             var db = new Data.DataSetLinqDataContext();
             var qry = (from u in db.tbl_results
                        where string.Compare(u.date_t, persianDateTimePicker1.Value.ToString("yyyy/MM/dd"))>-1
                        && string.Compare(u.date_t , persianDateTimePicker2.Value.ToString("yyyy/MM/dd"))<1
                        join co in db.tbl_quizs on u.Id_Quiz equals co.Id_Quiz
                        join prod in db.tbl_books on u.Id_Book equals prod.Id_Book
                        join pr in db.tbl_lessons on u.id_lesson equals pr.id_lesson

                        select new
                        {
                            آزمون = co.name_quiz,
                            کتاب = prod.name_book,
                            درس = pr.name_lesson,

                            درست = u.Points_Correct,
                            غلط = u.Points_InCorrect,
                            زمان = u.Time_Result,
                            تاریخ = u.date_t
                        }).ToList();
             dataGridView1.DataSource = qry;
             var qryi = (from u in dataDataSet.tbl_result
                         where string.Compare(u.date_t, persianDateTimePicker1.Value.ToString("yyyy/MM/dd")) >= 0
                         && string.Compare(u.date_t, persianDateTimePicker2.Value.ToString("yyyy/MM/dd")) <= 0
                         //join co in dataDataSet.tbl_quiz on u.Id_Quiz equals co.Id_Quiz
                         //join prod in dataDataSet.tbl_book on u.Id_Book equals prod.Id_Book
                         //join pr in dataDataSet.tbl_lesson on u.id_lesson equals pr.id_lesson

                         select u).ToList();
             this.chart1.DataSource = qryi;
             this.chart1.DataBind();

            
             //dataGridView1.Columns[1].HeaderText = "جواب درست";
             //dataGridView1.Columns[2].HeaderText = "جواب غلط";
            
             //dataGridView1.Columns[4].HeaderText = "زمان آزمون";
             //dataGridView1.Columns[0].Visible = false;
             //dataGridView1.Columns[3].Visible = false;
             //dataGridView1.Columns[5].Visible = false;
             //dataGridView1.Columns[6].Visible = false;
             //dataGridView1.Columns[7].Visible = false;
             //dataGridView1.Columns[8].HeaderText = "تاریخ";
             //dataGridView1.Columns[9].Visible = false;
             //dataGridView1.Columns[10].Visible = false;
             //dataGridView1.Columns[11].Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
