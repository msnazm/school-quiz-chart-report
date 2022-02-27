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
    public partial class SelectQuiz : Form
    {
        
        public SelectQuiz()
        {
            InitializeComponent();
        }
        public int count = 0;
        private int i = 0;
        private int j = 0;
        private int k = 0;
        public int ct = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox3.Text = (DateTime.Now.Minute.ToString());
            //label36.Text = (DateTime.Now.Minute.ToString());
            label36.Text = System.Convert.ToString(i = i + 1);
            if (i == 59)
            {
                i = 0;
                label38.Text = System.Convert.ToString(j = j + 1);
            }
            if (j == 59)
            {
                j = 0;
                label39.Text = System.Convert.ToString(k = k + 1);
            }
        } 

        private void SelectQuiz_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            //groupBox3.Visible = false;
            var db = new Data.DataSetLinqDataContext();
            var qry = (from u in db.tbl_quizs
                       select new {id= u.Id_Quiz,name = u.name_quiz }).ToList();
           
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = qry;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            DateTime dat = DateTime.Now;

            textBox4.Text = (pc.GetYear(dat) + "/" + pc.GetMonth(dat) + "/" + pc.GetDayOfMonth(dat));
    //        var db = new Data.DataSetLinqDataContext();
    //        var Select = (from x in db.tbl_quizs
    //                      join p in db.tbl_books on x.Id_Quiz equals p.Id_Quiz      
    //                      join i in db.tbl_lessons on p.Id_Book equals i.Id_Book 
        
    // select new { QuizList = x.Id_Quiz,
    // name = x.name_quiz,
    // idbook = p.Id_Book,
    //namebook = p.name_book,
    //idlessen = i.id_lesson,
    //namelesson = i.name_lesson
    // });
    //        dataGridView1.DataSource = Select.ToList();
            //comboBox1.DisplayMember = "name";
            //comboBox1.ValueMember = "QuizList";
            groupBox1.Parent = this.pictureBox1;
            groupBox2.Parent = this.pictureBox1;
            groupBox3.Parent = this.pictureBox1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               var db = new Data.DataSetLinqDataContext();
             var qui  = (from u in db.tbl_books
                       //   join p in db.tbl_books on u.Id_Quiz equals p.Id_Quiz
                         where u.Id_Quiz == Convert.ToInt32(comboBox1.SelectedValue)
                          select new
                          {

                              idbook = u.Id_Book,
                              name = u.name_book
                          }).ToList();
            
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "idbook";
            comboBox2.DataSource = qui;
            //var db = new Data.DataSetLinqDataContext();
            //var Select_Id_bookc = (from x in db.tbl_books 
            //                      join p in db.tbl_quizs on x.Id_Quiz equals p.Id_Quiz
            //                      //where comboBox1.Text == Int32.Parse(x.Id_Quiz).ToString()
            //                       select new { name = x.name_book,
            //                       idbook = x.Id_Book});
            //comboBox2.DataSource = Select_Id_bookc.ToList();
            //comboBox2.DisplayMember = "name";
            //comboBox2.ValueMember = "idbook";
            }
            catch
            {
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show();
                //MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //groupBox2.Visible = true;


                var db = new Data.DataSetLinqDataContext();
                //var q = from x in db.GetTable<Data.tbl_main>()
                //                   where (x.id_quiz == Convert.ToInt32(comboBox1.SelectedValue)) && (x.id_book == Convert.ToInt32(comboBox2.SelectedValue)) && (x.id_lesson == Convert.ToInt32(comboBox3.SelectedValue))

                //               select x.id_main;
                var Select_Id_main = (from x in db.tbl_mains
                                      where (x.id_quiz == Convert.ToInt32(comboBox1.SelectedValue)) && (x.id_book == Convert.ToInt32(comboBox2.SelectedValue)) && (x.id_lesson == Convert.ToInt32(comboBox3.SelectedValue))
                                      select x).FirstOrDefault();
                //var w = Select_Id_main.FirstOrDefault().id_main;
                int id;
                id = Select_Id_main.id_main;
                textBox1.Text = id.ToString();
                var Select_Id_temp = (from x in db.tbl_questions
                                      where (x.id_main == Convert.ToInt32(textBox1.Text))
                                      select new
                                      {
                                          idques = x.Id_Question,
                                          ques = x.question,
                                          ansone = x.answerone,
                                          anstwo = x.answertwo,
                                          ansthree = x.answerthree,
                                          ansfure = x.answerfure,
                                          num = x.num
                                      }).FirstOrDefault();
                label2.Text = Select_Id_temp.idques.ToString();
                button5.Text = Select_Id_temp.num.ToString();
                question.Text = Select_Id_temp.ques;
                one.Text = Select_Id_temp.ansone;
                two.Text = Select_Id_temp.anstwo;
                three.Text = Select_Id_temp.ansthree;
                fure.Text = Select_Id_temp.ansfure;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                timer1.Start();
            }
            catch 
            {
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show(); 
            } 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            var qui = (from u in db.tbl_lessons
                       //   join p in db.tbl_books on u.Id_Quiz equals p.Id_Quiz
                       where u.Id_Book == Convert.ToInt32(comboBox2.SelectedValue)
                       select new
                       {

                           idlesson = u.id_lesson,
                           name = u.name_lesson
                       }).ToList();

            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "idlesson";
            comboBox3.DataSource = qui;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            var qui = (from u in db.tbl_books
                       //   join p in db.tbl_books on u.Id_Quiz equals p.Id_Quiz
                       where u.Id_Quiz == Convert.ToInt32(comboBox1.SelectedValue)
                       select new
                       {

                           idbook = u.Id_Book,
                           name = u.name_book
                       }).ToList();

            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "idbook";
            comboBox2.DataSource = qui;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            var qui = (from u in db.tbl_lessons
                       //   join p in db.tbl_books on u.Id_Quiz equals p.Id_Quiz
                       where u.Id_Book == Convert.ToInt32(comboBox2.SelectedValue)
                       select new
                       {

                           idlesson = u.id_lesson,
                           name = u.name_lesson
                       }).ToList();

            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "idlesson";
            comboBox3.DataSource = qui;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (raone.Checked == false && retwo.Checked == false && rethree.Checked==false && refure.Checked==false)
            {
                var db = new Data.DataSetLinqDataContext();
                var result = (from u in db.tbl_questions
                              where u.Id_Question == Int32.Parse(label2.Text)

                              select u).Single();
                result.testcorect = Convert.ToInt32(txtvalue.Text = "0");

                db.SubmitChanges();
                var Select_sum = (from x in db.tbl_questions
                                  where (x.answer == x.testcorect) && (x.Id_Question == Convert.ToInt32(label2.Text))
                                  select x).FirstOrDefault();
                var Selectt = (from x in db.tbl_questions
                               where (x.Id_Question == Convert.ToInt32(label2.Text))
                               select x).FirstOrDefault();

                if (Select_sum != null)
                {
                    Select_sum.resultCorrect = 1;
                    db.SubmitChanges();
                    dataGridView1.DataSource = Select_sum;
                }
                else Selectt.resultInCorrect = 1;
                db.SubmitChanges();
                dataGridView1.DataSource = Select_sum;

                if (count == db.tbl_questions.Count() - 1)
                {
                    button2.Enabled = true;
                    btnnext.Enabled = false;
                }
                else
                {
                    count++;
                    var Selectid = (from u in db.tbl_questions

                                    where (u.id_main == Convert.ToInt32(textBox1.Text))
                                    orderby (u.Id_Question)
                                    select u.Id_Question).Skip(count).FirstOrDefault();
                    label2.Text = Selectid.ToString();
                    var Selectnum = (from u in db.tbl_questions

                                     where (u.Id_Question == Convert.ToInt32(label2.Text))
                                     select u.num).FirstOrDefault();
                    button5.Text = Selectnum.ToString();
                    //var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
                    //    .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    if (Selectid == 0)
                    {
                        //MessageBox.Show("--اتمام سوالها--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnnext.Enabled = false;
                    }
                    else
                    {
                        var query = (from x in db.tbl_questions
                                     where (x.Id_Question == Convert.ToInt32(label2.Text))
                                     select x).FirstOrDefault();

                        question.Text = query.question;
                        one.Text = query.answerone.ToString();
                        two.Text = query.answertwo.ToString();
                        three.Text = query.answerthree.ToString();
                        fure.Text = query.answerfure.ToString();
                    }
                    // var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();

                    //    var query = db.tbl_questions.Select(c => c)
                    //        .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    //    label2.Text = query.Id_Question.ToString();
                    //    question.Text = query.question;
                    //    one.Text = query.answerone.ToString();
                    //    two.Text = query.answertwo.ToString();
                    //    three.Text = query.answerthree.ToString();
                    //    fure.Text = query.answerfure.ToString();
                    //    count = 0;

                }
                raone.Checked = false;
                retwo.Checked = false;
                rethree.Checked = false;
                refure.Checked = false;
               // MessageBox.Show("--لطفا یکی از گزینه ها را انتخاب کنید--", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();

                var Select_sum = (from x in db.tbl_questions
                                  where (x.answer == x.testcorect) && (x.Id_Question == Convert.ToInt32(label2.Text))
                                  select x).FirstOrDefault();
                var Selectt = (from x in db.tbl_questions
                               where (x.Id_Question == Convert.ToInt32(label2.Text))
                               select x).FirstOrDefault();

                if (Select_sum != null)
                {
                    Select_sum.resultCorrect = 1;
                    db.SubmitChanges();
                    dataGridView1.DataSource = Select_sum;
                }
                else Selectt.resultInCorrect = 1;
                db.SubmitChanges();
                dataGridView1.DataSource = Select_sum;

                if (count == db.tbl_questions.Count() - 1)
                {
                    button2.Enabled = true;
                    btnnext.Enabled = false;
                }
                else
                {
                    count++;
                    var Selectid = (from u in db.tbl_questions

                                    where (u.id_main == Convert.ToInt32(textBox1.Text))
                                    orderby (u.Id_Question)
                                    select u.Id_Question).Skip(count).FirstOrDefault();
                    label2.Text = Selectid.ToString();
                    var Selectnum = (from u in db.tbl_questions

                                     where (u.Id_Question == Convert.ToInt32(label2.Text))
                                     select u.num).FirstOrDefault();
                    button5.Text = Selectnum.ToString();
                    //var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
                    //    .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    if (Selectid == 0)
                    {
                        //MessageBox.Show("--اتمام سوالها--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnnext.Enabled = false;
                    }
                    else
                    {
                        var query = (from x in db.tbl_questions
                                     where (x.Id_Question == Convert.ToInt32(label2.Text))
                                     select x).FirstOrDefault();

                        question.Text = query.question;
                        one.Text = query.answerone.ToString();
                        two.Text = query.answertwo.ToString();
                        three.Text = query.answerthree.ToString();
                        fure.Text = query.answerfure.ToString();
                    }
                    // var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();

                    //    var query = db.tbl_questions.Select(c => c)
                    //        .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    //    label2.Text = query.Id_Question.ToString();
                    //    question.Text = query.question;
                    //    one.Text = query.answerone.ToString();
                    //    two.Text = query.answertwo.ToString();
                    //    three.Text = query.answerthree.ToString();
                    //    fure.Text = query.answerfure.ToString();
                    //    count = 0;
                   
                }
                raone.Checked = false;
                retwo.Checked = false;
                rethree.Checked = false;
                refure.Checked = false;
            }

        }

        private void raone_CheckedChanged(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                return;
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();
                var result = (from u in db.tbl_questions
                              where u.Id_Question == Int32.Parse(label2.Text)

                              select u).Single();
                result.testcorect = Convert.ToInt32(txtvalue.Text = "1");

                db.SubmitChanges();
                var Select = (from x in db.tbl_questions
                              //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                              select x).ToList();
                dataGridView1.DataSource = Select;

            }
        }

        private void retwo_CheckedChanged(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                return;
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();
                var result = (from u in db.tbl_questions
                              where u.Id_Question == Int32.Parse(label2.Text)

                              select u).Single();
                result.testcorect = Convert.ToInt32(txtvalue.Text = "2");

                db.SubmitChanges();
                var Select = (from x in db.tbl_questions
                              //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                              select x).ToList();
                dataGridView1.DataSource = Select;
            }
        }

        private void rethree_CheckedChanged(object sender, EventArgs e)
        {
             if (label2.Text == "0")
            {
                return;
            }
             else
             {
            var db = new Data.DataSetLinqDataContext();
            var result = (from u in db.tbl_questions
                          where u.Id_Question == Int32.Parse(label2.Text)

                          select u).Single();
           
           
                result.testcorect = Convert.ToInt32(txtvalue.Text = "3");

                db.SubmitChanges();
                var Select = (from x in db.tbl_questions
                              //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                              select x).ToList();
                dataGridView1.DataSource = Select;
            }
        }

        private void refure_CheckedChanged(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                return;
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();
                var result = (from u in db.tbl_questions
                              where u.Id_Question == Int32.Parse(label2.Text)

                              select u).Single();
                result.testcorect = Convert.ToInt32(txtvalue.Text = "4");

                db.SubmitChanges();
                var Select = (from x in db.tbl_questions
                              //where (dgnquiz.CurrentRow.Cells["Id_Quiz"].Value.ToString() == x.Id_Quiz.ToString())

                              select x).ToList();

                dataGridView1.DataSource = Select;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
           
            //txt12.Parent = this.pictureBox1;
            //label36.Text = "";
            //label38.Text = "";
            //label39.Text = "";
            //groupBox2.Visible = false;
         //   groupBox3.Visible = true;
            var db = new Data.DataSetLinqDataContext();
            //var Select_sum_correct = (from x in db.tbl_questions
            //                          where (x.id_main == Convert.ToInt32(textBox1.Text))
            //                          select x.resultCorrect).ToList();
            //var n = Select_sum_correct.Sum();
            //n = Convert.ToInt32(label19.Text);

            //var Select_sum_Incorrect = (from x in db.tbl_questions
            //                            where (x.id_main == Convert.ToInt32(textBox1.Text))
            //                            select x.resultInCorrect).ToList();
            //var m = Select_sum_Incorrect.Sum();
            //m = Convert.ToInt32(label22.Text);

            var Select_sum = (from x in db.tbl_questions
                              where (x.answer == x.testcorect) && (x.id_main == Convert.ToInt32(textBox1.Text))
                              orderby (x.Id_Question)
                              select x).Count();
            var Selectt = (from x in db.tbl_questions
                           where (x.answer != x.testcorect) && (x.id_main == Convert.ToInt32(textBox1.Text))
                           orderby (x.Id_Question)
                           select x).Count();
            var Selectzero = (from x in db.tbl_questions
                           where (x.testcorect == 0) && (x.id_main == Convert.ToInt32(textBox1.Text))
                           orderby (x.Id_Question)
                           select x).Count();
            label19.Text = Select_sum.ToString();
            label12.Text = Selectzero.ToString();
                label22.Text = Selectt.ToString();
                int seco = Convert.ToInt32(label36.Text);
                int one = Convert.ToInt32(label38.Text) * 60;
                int two = Convert.ToInt32(label39.Text) * 60;
                int sum_ints = seco + one + two;
                textBox3.Text = sum_ints.ToString();
                Data.tbl_result tblresult = new Data.tbl_result();
                tblresult.Points_Correct = Convert.ToInt32(label19.Text);
                tblresult.Points_InCorrect = Convert.ToInt32(label22.Text);
                tblresult.Id_Quiz = Convert.ToInt32(comboBox1.SelectedValue);
                tblresult.Id_Book = Convert.ToInt32(comboBox2.SelectedValue);
                tblresult.id_lesson = Convert.ToInt32(comboBox3.SelectedValue);
                tblresult.Time_Result =Convert.ToInt32(textBox3.Text);
                tblresult.date_t =  persianDateTimePicker1.Value.ToString("yyyy/MM/dd");
                db.tbl_results.InsertOnSubmit(tblresult);
                db.SubmitChanges();
                int Competency = 0;
                int sum_selection = Select_sum + Selectt;
                Competency = Select_sum * 100 / sum_selection;
                label6.Text = Competency.ToString();
            var Select_Id_temp = (from x in db.tbl_questions
                                  where (x.id_main == Convert.ToInt32(textBox1.Text))
                                  select new
                                  {
                                      idques = x.Id_Question,
                                      ques = x.question,
                                      ansone = x.answerone,
                                      anstwo = x.answertwo,
                                      ansthree = x.answerthree,
                                      ansfure = x.answerfure,
                                      num = x.num
                                  }).FirstOrDefault();
            label5.Text = Select_Id_temp.idques.ToString();
            button6.Text = Select_Id_temp.num.ToString();
            textBox8.Text = Select_Id_temp.ques;
            txt12.Text = Select_Id_temp.ansone;
            textBox5.Text = Select_Id_temp.anstwo;
            textBox6.Text = Select_Id_temp.ansthree;
            textBox7.Text = Select_Id_temp.ansfure;
            
            var Select_ans = (from x in db.tbl_questions
                              where (x.id_main == Convert.ToInt32(textBox1.Text)) && (x.Id_Question == Convert.ToInt32(label5.Text))
                              select x).FirstOrDefault();
            if (Select_ans.answer == 1)
                textBox9.Text = Select_ans.answerone;
            else if (Select_ans.answer == 2)
                textBox9.Text = Select_ans.answertwo;
            else if (Select_ans.answer == 3)
                textBox9.Text = Select_ans.answerthree;
            else if (Select_ans.answer == 4)
                textBox9.Text = Select_ans.answerfure;
            label16.Text = Select_ans.answer.ToString();
            label13.Text = Select_ans.testcorect.ToString();
            
            //timer1.Enabled = false;
            
            timer1.Stop();
            i = 0;
            j = 0;
            k = 0;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            if (ct == (db.tbl_questions.Count() - 1))
            {

                button4.Enabled = false;
                return;
            }
           else
           {
              // return;
               ct++;
               var Selectid = (from u in db.tbl_questions

                            where (u.id_main == Convert.ToInt32(textBox1.Text))
                            orderby (u.Id_Question)
                            select u.Id_Question).Skip(ct).FirstOrDefault();
               label5.Text = Selectid.ToString();
               var Selectnum = (from u in db.tbl_questions

                                where (u.Id_Question == Convert.ToInt32(label2.Text))
                                select u.num).FirstOrDefault();
               button6.Text = Selectnum.ToString();
               //var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
               //    .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
               if (Selectid == 0)
               {
                   button4.Text = "اتمام سوال ها";
                   groupBox3.Visible = false;
                   groupBox1.Visible = true;
               }
               else
               {
                   var query = (from x in db.tbl_questions
                                where (x.Id_Question == Convert.ToInt32(label5.Text))
                                select x).FirstOrDefault();

                  textBox8.Text = query.question;
                   txt12.Text = query.answerone.ToString();
                   textBox5.Text = query.answertwo.ToString();
                   textBox6.Text = query.answerthree.ToString();
                   textBox7.Text = query.answerfure.ToString();
                   var Select_ans = (from x in db.tbl_questions
                                     where (x.id_main == Convert.ToInt32(textBox1.Text)) && (x.Id_Question == Convert.ToInt32(label5.Text))
                                     select x).FirstOrDefault();
                   if (Select_ans.answer == 1)
                       textBox9.Text = Select_ans.answerone;
                   else if (Select_ans.answer == 2)
                       textBox9.Text = Select_ans.answertwo;
                   else if (Select_ans.answer == 3)
                       textBox9.Text = Select_ans.answerthree;
                   else if (Select_ans.answer == 4)
                       textBox9.Text = Select_ans.answerfure;
                   label16.Text = Select_ans.answer.ToString();
                   label13.Text = Select_ans.testcorect.ToString();
                     
                }
                // var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();

                //    var query = db.tbl_questions.Select(c => c)
                //        .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                //    label2.Text = query.Id_Question.ToString();
                //    question.Text = query.question;
                //    one.Text = query.answerone.ToString();
                //    two.Text = query.answertwo.ToString();
                //    three.Text = query.answerthree.ToString();
                //    fure.Text = query.answerfure.ToString();
                //    count = 0;

            }


            //if (count < (db.tbl_questions.Count() - 1))
            //{
            //    count++;
            //    var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
            //         .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
            //    label5.Text = query.Id_Question.ToString();
            //    label6.Text = query.question;
            //    label12.Text = query.answerone.ToString();
            //    label11.Text = query.answertwo.ToString();
            //    label8.Text = query.answerthree.ToString();
            //    label7.Text = query.answerfure.ToString();
            //    label16.Text = query.answer.ToString();
            //    label13.Text = query.testcorect.ToString();
            //    var Select_ans = (from x in db.tbl_questions
            //                      where (x.id_main == Convert.ToInt32(textBox1.Text)) && (x.Id_Question == Convert.ToInt32(label5.Text))
            //                          select x).FirstOrDefault();
            //    if (Select_ans.answer == 1)
            //    label17.Text= Select_ans.answerone;
            //    else if (Select_ans.answer == 2)
            //    label17.Text= Select_ans.answertwo;
            //        else if (Select_ans.answer == 3)
            //    label17.Text= Select_ans.answerthree;
            //            else if (Select_ans.answer == 4)
            //    label17.Text= Select_ans.answerfure;

                
            //}
            //else
            //{
            //    var query = db.tbl_questions.Select(c => c)
            //          .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
            //    label5.Text = query.Id_Question.ToString();
            //    label6.Text = query.question;
            //    label12.Text = query.answerone.ToString();
            //    label11.Text = query.answertwo.ToString();
            //    label8.Text = query.answerthree.ToString();
            //    label7.Text = query.answerfure.ToString();
            //    label16.Text = query.answer.ToString();
            //    label13.Text = query.testcorect.ToString();
            //    var Select_ans = (from x in db.tbl_questions
            //                      where (x.id_main == Convert.ToInt32(textBox1.Text)) && (x.Id_Question == Convert.ToInt32(label5.Text))
            //                      select x).FirstOrDefault();
            //    if (Select_ans.answer == 1)
            //        label17.Text = Select_ans.answerone;
            //    else if (Select_ans.answer == 2)
            //        label17.Text = Select_ans.answertwo;
            //    else if (Select_ans.answer == 3)
            //        label17.Text = Select_ans.answerthree;
            //    else if (Select_ans.answer == 4)
            //        label17.Text = Select_ans.answerfure;
            //    count = 0;

            //}
        }

        private void raone_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
                
            if (raone.Checked == false && retwo.Checked == false && rethree.Checked==false && refure.Checked==false)
            {
                var db = new Data.DataSetLinqDataContext();
                var result = (from u in db.tbl_questions
                              where u.Id_Question == Int32.Parse(label2.Text)

                              select u).Single();
                result.testcorect = Convert.ToInt32(txtvalue.Text = "0");

                db.SubmitChanges();
                var Select_sum = (from x in db.tbl_questions
                                  where (x.answer == x.testcorect) && (x.Id_Question == Convert.ToInt32(label2.Text))
                                  select x).FirstOrDefault();
                var Selectt = (from x in db.tbl_questions
                               where (x.Id_Question == Convert.ToInt32(label2.Text))
                               select x).FirstOrDefault();

                if (Select_sum != null)
                {
                    Select_sum.resultCorrect = 1;
                    db.SubmitChanges();
                    dataGridView1.DataSource = Select_sum;
                }
                else Selectt.resultInCorrect = 1;
                db.SubmitChanges();
                dataGridView1.DataSource = Select_sum;


                if (count == db.tbl_questions.Count() - 1 || count != 0)
            {
            
                    count--;
                    var Selectid = (from u in db.tbl_questions

                                    where (u.id_main == Convert.ToInt32(textBox1.Text))
                                    orderby (u.Id_Question)
                                    select u.Id_Question).Skip(count).FirstOrDefault();
                    label2.Text = Selectid.ToString();
                    var Selectnum = (from u in db.tbl_questions

                                     where (u.Id_Question == Convert.ToInt32(label2.Text))
                                     select u.num).FirstOrDefault();
                    button5.Text = Selectnum.ToString();
                    //var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
                    //    .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    if (Selectid == 0)
                    {
                        //MessageBox.Show("--اتمام سوالها--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnnext.Enabled = false;
                    }
                    else
                    {
                        var query = (from x in db.tbl_questions
                                     where (x.Id_Question == Convert.ToInt32(label2.Text))
                                     select x).FirstOrDefault();

                        question.Text = query.question;
                        one.Text = query.answerone.ToString();
                        two.Text = query.answertwo.ToString();
                        three.Text = query.answerthree.ToString();
                        fure.Text = query.answerfure.ToString();
                    }
                    // var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();

                    //    var query = db.tbl_questions.Select(c => c)
                    //        .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    //    label2.Text = query.Id_Question.ToString();
                    //    question.Text = query.question;
                    //    one.Text = query.answerone.ToString();
                    //    two.Text = query.answertwo.ToString();
                    //    three.Text = query.answerthree.ToString();
                    //    fure.Text = query.answerfure.ToString();
                    //    count = 0;

                }
                raone.Checked = false;
                retwo.Checked = false;
                rethree.Checked = false;
                refure.Checked = false;
               // MessageBox.Show("--لطفا یکی از گزینه ها را انتخاب کنید--", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();

                var Select_sum = (from x in db.tbl_questions
                                  where (x.answer == x.testcorect) && (x.Id_Question == Convert.ToInt32(label2.Text))
                                  select x).FirstOrDefault();
                var Selectt = (from x in db.tbl_questions
                               where (x.Id_Question == Convert.ToInt32(label2.Text))
                               select x).FirstOrDefault();

                if (Select_sum != null)
                {
                    Select_sum.resultCorrect = 1;
                    db.SubmitChanges();
                    dataGridView1.DataSource = Select_sum;
                }
                else Selectt.resultInCorrect = 1;
                db.SubmitChanges();
                dataGridView1.DataSource = Select_sum;

                if (count == db.tbl_questions.Count() - 1 || count != 0)
                {
                    button2.Enabled = true;
                    btnnext.Enabled = false;
                }
                else
                {
                    count--;
                    var Selectid = (from u in db.tbl_questions

                                    where (u.id_main == Convert.ToInt32(textBox1.Text))
                                    orderby (u.Id_Question)
                                    select u.Id_Question).Skip(count).FirstOrDefault();
                    label2.Text = Selectid.ToString();
                    var Selectnum = (from u in db.tbl_questions

                                     where (u.Id_Question == Convert.ToInt32(label2.Text))
                                     select u.num).FirstOrDefault();
                    button5.Text = Selectnum.ToString();
                    //var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count)
                    //    .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    if (Selectid == 0)
                    {
                        //MessageBox.Show("--اتمام سوالها--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnnext.Enabled = false;
                    }
                    else
                    {
                        var query = (from x in db.tbl_questions
                                     where (x.Id_Question == Convert.ToInt32(label2.Text))
                                     select x).FirstOrDefault();

                        question.Text = query.question;
                        one.Text = query.answerone.ToString();
                        two.Text = query.answertwo.ToString();
                        three.Text = query.answerthree.ToString();
                        fure.Text = query.answerfure.ToString();
                    }
                    // var query = db.tbl_questions.OrderBy(t => t.Id_Question).Skip(count).FirstOrDefault();

                    //    var query = db.tbl_questions.Select(c => c)
                    //        .Where(z => Convert.ToInt32(z.id_main).Equals(textBox1.Text)).FirstOrDefault();
                    //    label2.Text = query.Id_Question.ToString();
                    //    question.Text = query.question;
                    //    one.Text = query.answerone.ToString();
                    //    two.Text = query.answertwo.ToString();
                    //    three.Text = query.answerthree.ToString();
                    //    fure.Text = query.answerfure.ToString();
                    //    count = 0;
                   
                }
                raone.Checked = false;
                retwo.Checked = false;
                rethree.Checked = false;
                refure.Checked = false;
            }

        }

       

        
    }
}
