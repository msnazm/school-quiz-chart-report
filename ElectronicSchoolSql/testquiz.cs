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
    public partial class testquiz : Form
    {
        public testquiz()
        {
            InitializeComponent();
        }

        private void testquiz_Load(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            cmdquiz.DataSource = db.tbl_quizs.Select(m => m.name_quiz)
              .ToList();
            cmdquiz.DataSource = db.tbl_quizs;
            cmdquiz.DisplayMember = "name_quiz";
            cmdquiz.ValueMember = "Id_Quiz";
            cmdbook.DataSource = db.tbl_books.Select(m => m.name_book)
              .ToList();
            cmdbook.DataSource = db.tbl_books;
            cmdbook.DisplayMember = "name_book";
            cmdbook.ValueMember = "Id_Book";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
