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
    public partial class startquiz : Form
    {
        public int count;
       
        public startquiz()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {


            var db = new Data.DataSetLinqDataContext();


            if (count < (db.tbl_questions.Count() - 1))
            {
                count++;
                var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();
                label6.Text = query.Id_Question.ToString();
                question.Text = query.question;
                one.Text = query.answerone.ToString();
                two.Text = query.answertwo.ToString();
                three.Text = query.answerthree.ToString();
                fure.Text = query.answerfure.ToString();
            }
            else
            {
                var query = db.tbl_questions.Select(c => c).FirstOrDefault();
                label6.Text = query.Id_Question.ToString();
                question.Text = query.question;
                one.Text = query.answerone.ToString();
                two.Text = query.answertwo.ToString();
                three.Text = query.answerthree.ToString();
                fure.Text = query.answerfure.ToString();
                count = 0;
              
            }
           
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
          
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            count--;
            if (count < 0)
            {
                count = db.tbl_questions.Count();
            }
            var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).Take(1);
            foreach (var s1 in query)
            {
                question.Text = s1.question;
                one.Text = s1.answerfure.ToString();
                fure.Text = s1.answerone.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();

            Data.tbl_main tblmain = new Data.tbl_main();
            var st = (from c in db.tbl_mains
                      join o in db.tbl_questions on c.id_main equals o.id_main

                      where c.id_main == Int32.Parse(idquiz.Text)
                      orderby o.Id_Question
                      select o).First();





            this.question.Text = st.question;
        }

        private void startquiz_Load(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();

            Data.tbl_main tblmain = new Data.tbl_main();
            var st = (from c in db.tbl_mains
                      join o in db.tbl_questions on c.id_main equals o.id_main

                      where c.id_main == Int32.Parse(idquiz.Text)
                      orderby o.Id_Question
                      select o).First();





            
        }

 

  private void timer1_Tick(object sender, EventArgs e)
  {
     
  }

  private void raone_CheckedChanged(object sender, EventArgs e)
  {
      var db = new Data.DataSetLinqDataContext();
      var result = (from u in db.tbl_questions
                    where  u.Id_Question == Int32.Parse(label6.Text)
                    
                    select u).Single();
      result.testcorect = Convert.ToInt32(txtvalue.Text="1");
   
      db.SubmitChanges();
      var Select = (from x in db.tbl_questions
                           //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                           select x).ToList();

      dataGridView1.DataSource = Select;
  }
  
  private void btnend_Click(object sender, EventArgs e)
  {
      var db = new Data.DataSetLinqDataContext();
      var result = (from u in db.tbl_questions
                    where u.Id_Question == Int32.Parse(idques.Text)

                    select u).Single();
  }

  private void retwo_CheckedChanged(object sender, EventArgs e)
  {
      var db = new Data.DataSetLinqDataContext();
      var result = (from u in db.tbl_questions
                    where u.Id_Question == Int32.Parse(label6.Text)

                    select u).Single();
      result.testcorect = Convert.ToInt32(txtvalue.Text="2");

      db.SubmitChanges();
      var Select = (from x in db.tbl_questions
                    //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                    select x).ToList();

      dataGridView1.DataSource = Select;
  }

  private void rethree_CheckedChanged(object sender, EventArgs e)
  {
      var db = new Data.DataSetLinqDataContext();
      var result = (from u in db.tbl_questions
                    where u.Id_Question == Int32.Parse(label6.Text)

                    select u).Single();
      result.testcorect = Convert.ToInt32(txtvalue.Text = "3");

      db.SubmitChanges();
      var Select = (from x in db.tbl_questions
                    //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                    select x).ToList();

      dataGridView1.DataSource = Select;
  }

  private void refure_CheckedChanged(object sender, EventArgs e)
  {
      var db = new Data.DataSetLinqDataContext();
      var result = (from u in db.tbl_questions
                    where  u.Id_Question == Int32.Parse(label6.Text)
                    
                    select u).Single();
      result.testcorect = Convert.ToInt32(txtvalue.Text = "4");

      db.SubmitChanges();
      var Select = (from x in db.tbl_questions
                    //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                    select x).ToList();

      dataGridView1.DataSource = Select;
  }

 
    }
}
