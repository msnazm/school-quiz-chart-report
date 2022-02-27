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
    public partial class frmquizs : Form
    {
        public frmquizs()
        {
            InitializeComponent();
        }

        private void btnsavequiz_Click(object sender, EventArgs e)
        {
            if (txtquiz.Text == "")
            {
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show();
               // MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();
                Data.tbl_quiz tblsquiz = new Data.tbl_quiz();
                // tblsquiz.num_quiz = int.Parse(txtnumquiz.Text);
                tblsquiz.date_quiz = txtdate.Text;
                tblsquiz.name_quiz = txtquiz.Text;
                db.tbl_quizs.InsertOnSubmit(tblsquiz);
                db.SubmitChanges();
                var childForm = new messegebox();
                childForm.label1.Text = "اطلاعات مورد نظر با موفقیت ثبت شد.";
                childForm.Show();
               // MessageBox.Show("--اطلاعات ذخیره شد--", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquiz.Text = "";
                maxid();
            }
        }

        private void frmquizs_Load(object sender, EventArgs e)
        {
            maxid();
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            exit.Parent = this.pictureBox1;
        }

        private void maxid()
        {
            var db = new Data.DataSetLinqDataContext();
            var qry = (from u in db.tbl_quizs
                       select u).FirstOrDefault();
            if (qry != null)
            {
            var Select = (from x in db.tbl_quizs

                          select x.Id_Quiz).Max();
           
                 txtnumquiz.Text = Select.ToString();
            }else{
                txtnumquiz.Text = "1";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
