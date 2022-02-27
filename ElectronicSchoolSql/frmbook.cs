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
    public partial class frmbook : Form
    {
        public frmbook()
        {
            InitializeComponent();
        }

        private void frmbook_Load(object sender, EventArgs e)
        {
            maxid();
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            label3.Parent = this.pictureBox1;
           
        }

        private void maxid()
        {
            var db = new Data.DataSetLinqDataContext();
            cmdquiz.DataSource = db.tbl_quizs.Select(m => m.name_quiz)
              .ToList();

            cmdquiz.DataSource = db.tbl_quizs;
            cmdquiz.DisplayMember = "name_quiz";
            cmdquiz.ValueMember = "Id_Quiz";
            var qry = (from u in db.tbl_books
                       select u).FirstOrDefault();
            if (qry != null )
            {
                var Select = (from x in db.tbl_books

                              select x.Id_Book).Max();
                txtnumbook.Text = Select.ToString();
            } else {
                txtnumbook.Text = "1";
                
            }
        }

        private void btnsavebook_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnamebook.Text == "")
                {
                    var childForm = new messegebox();
                    childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                    childForm.Show();
                    //MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var db = new Data.DataSetLinqDataContext();
                    Data.tbl_book tblbook = new Data.tbl_book();
                    tblbook.name_book = txtnamebook.Text;
                    tblbook.Id_Quiz = Convert.ToInt32(cmdquiz.SelectedValue);
                    db.tbl_books.InsertOnSubmit(tblbook);
                    db.SubmitChanges();
                    var childForm = new messegebox();
                    childForm.label1.Text = "اطلاعات مورد نظر با موفقیت ثبت شد.";
                    childForm.Show();
                    // MessageBox.Show("--اطلاعات ذخیره شد--", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maxid();
                    txtnamebook.Text = "";
                }
            }
            catch
            {
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
