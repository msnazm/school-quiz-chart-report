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
    public partial class frmlesson : Form
    {
        public frmlesson()
        {
            InitializeComponent();
        }

        private void frmlesson_Load(object sender, EventArgs e)
        {
            maxid();
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            label9.Parent = this.pictureBox1;
           
        }

        private void maxid()
        {
            var db = new Data.DataSetLinqDataContext();
            //cmdbook.DataSource = db.tbl_books.Select(m => m.name_book)
            //.ToList();
            cmdbook.DataSource = db.tbl_books;
            cmdbook.DisplayMember = "name_book";
            cmdbook.ValueMember = "Id_Book";
              var qry = (from u in db.tbl_lessons
                       select u).FirstOrDefault();
              if (qry != null)
              {
                  var Select = (from x in db.tbl_lessons

                                select x.id_lesson).Max();
                  txtnumlesson.Text = Select.ToString();
                   } else {
                       txtnumlesson.Text = "1";
                
            
              }
        }

        private void btnsavelesson_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnamelesson.Text == "")
                {
                    var childForm = new messegebox();
                    childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                    childForm.Show();
                    // MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    var db = new Data.DataSetLinqDataContext();
                    Data.tbl_lesson tbllesson = new Data.tbl_lesson();
                    tbllesson.name_lesson = txtnamelesson.Text;
                    tbllesson.Id_Book = Convert.ToInt32(cmdbook.SelectedValue);
                    db.tbl_lessons.InsertOnSubmit(tbllesson);
                    db.SubmitChanges();
                    var childForm = new messegebox();
                    childForm.label1.Text = "اطلاعات مورد نظر با موفقیت ثبت شد.";
                    childForm.Show();
                    //MessageBox.Show("--اطلاعات ذخیره شد--", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnamelesson.Text = "";
                    maxid();
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
