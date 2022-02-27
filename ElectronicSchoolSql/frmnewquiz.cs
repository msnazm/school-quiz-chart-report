using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Class;

namespace ElectronicSchoolSql
{
    public partial class frmnewquiz : Form
    {
        int m = 0;
        public int count;
        public frmnewquiz()
        {
            InitializeComponent();
        }

        MaftooxCalendar.MaftooxPersianCalendar.TimeWork prdTime = new MaftooxCalendar.MaftooxPersianCalendar.TimeWork();
        MaftooxCalendar.MaftooxPersianCalendar.DateWork prd = new MaftooxCalendar.MaftooxPersianCalendar.DateWork();

        private void frmnewquiz_Load(object sender, EventArgs e)
        {
            var db = new Data.DataSetLinqDataContext();
            var qry = (from u in db.tbl_quizs
                       select new { id = u.Id_Quiz, name = u.name_quiz }).ToList();

            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = qry;
            groupBox2.Enabled = false;
            String stry = prd.GetNameMonth() + prd.GetNameDayInMonth();
            txtdate.Text = prd.GetNameDayInMonth() + "   " + prd.GetNumberDayInMonth().ToString() + "   " + prd.GetNameMonth() + "  سال  " + prd.GetNumberYear().ToString();
            groupBox1.Parent = this.pictureBox1;
            groupBox2.Parent = this.pictureBox1;
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //var qui = (from u in db.tbl_mains
            //           //   join p in db.tbl_books on u.Id_Quiz equals p.Id_Quiz
            //           where u.id_lesson == Convert.ToInt32(comboBox3.SelectedValue)
            //           select new
            //           {

            //               id_main = u.id_main,
                          
            //           }).Max();
            //textBox1.Text = qui.ToString();

            
            
        }

        private void setdg()
        {
            dgquizmath.Columns[11].HeaderText = "شماره سوال";
            dgquizmath.Columns[1].HeaderText = "سوال";
            dgquizmath.Columns[2].HeaderText = "جواب 1";
            dgquizmath.Columns[3].HeaderText = "جواب 2";
            dgquizmath.Columns[4].HeaderText = "جواب 3";
            dgquizmath.Columns[5].HeaderText = "جواب 4";
            dgquizmath.Columns[6].HeaderText = "جواب درست";
            dgquizmath.Columns[7].Visible = false;
            dgquizmath.Columns[0].Visible = false;
            dgquizmath.Columns[8].Visible = false;
            dgquizmath.Columns[9].Visible = false;
            dgquizmath.Columns[10].Visible = false;
            dgquizmath.Columns[12].Visible = false;
        }

        private void btnsavequiz_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" | comboBox2.Text == "" | comboBox3.Text == "")
            {
            
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show();
                //MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();

                Data.tbl_main tblmain = new Data.tbl_main();

                var Select_Id_main = (from x in db.tbl_mains
                                      where x.id_lesson == Convert.ToInt32(comboBox3.SelectedValue) && x.id_book == Convert.ToInt32(comboBox2.SelectedValue) && x.id_quiz == Convert.ToInt32(comboBox1.SelectedValue)
                                      select x.id_lesson).FirstOrDefault();
                textBox1.Text = Select_Id_main.ToString();
                if (Select_Id_main == null)
                {
                    tblmain.date_main = persianDateTimePicker1.Value.ToString("yy/mm/dd");
                    tblmain.id_quiz = Convert.ToInt32(comboBox1.SelectedValue);
                    tblmain.id_book = Convert.ToInt32(comboBox2.SelectedValue);
                    tblmain.id_lesson = Convert.ToInt32(comboBox3.SelectedValue);
                    db.tbl_mains.InsertOnSubmit(tblmain);
                    db.SubmitChanges();
                    //var childForm = new messegebox();
                    //childForm.label1.Text = "اطلاعات مورد نظر با موفقیت ثبت شد.";
                    //childForm.Show();
                    //MessageBox.Show("--اطلاعات ذخیره شد--", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var Select_main = (from x in db.tbl_mains

                                       select x.id_main).Max();
                    textBox1.Text = Select_main.ToString();
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                    settxt();
                }
                else
                {
                    var childForm = new messegebox();
                    childForm.label1.Text = "آزمون مورد نظر ثبت شده است لطفا آزمون جدید انتخاب کنید!";
                    childForm.Show();
                   // MessageBox.Show("--آزمون مورد نظر ثبت شده است لطفا آزمون جدید انتخاب کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //var w = Select_Id_main.FirstOrDefault().id_main;
                // int id;
                // id = Select_Id_main.id_main;
                //textBox1.Text = id.ToString();
                //if (count < (db.tbl_mains.Count() - 1))
                //{
                //    count++;
                //    var queryt = db.tbl_mains.OrderBy(t => t.id_main).Skip(count).FirstOrDefault();
                //    textBox1.Text = queryt.id_main.ToString();
                //    //select x);
                //    //var w = Select_Id_main.Last();
                //    //txtidmain.Text = query.ToString();
                //}
                //else
                //{
                //    var query = db.tbl_mains.Select(c => c).FirstOrDefault();
                //    textBox1.Text = query.id_main.ToString();
                //}

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            if (txtquestion.Text == "" | txtanswerone.Text == "" | txtanswertwo.Text == "" | txtanswerthree.Text == "" | txtanswerfure.Text == "" | txtcorrect.Text == "")
            {
                var childForm = new messegebox();
                childForm.label1.Text = "لطفا اطلاعات را تکمیل کنید!";
                childForm.Show();
               // MessageBox.Show("--لطفا اطلاعات را تکمیل کنید--", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = new Data.DataSetLinqDataContext();
                Data.tbl_question tblsquestion = new Data.tbl_question();
                tblsquestion.question = txtquestion.Text;
                tblsquestion.answerone = txtanswerone.Text;
                tblsquestion.answertwo = txtanswertwo.Text;
                tblsquestion.answerthree = txtanswerthree.Text;
                tblsquestion.answerfure = txtanswerfure.Text;
                tblsquestion.answer = Convert.ToInt32(txtcorrect.Text);
                tblsquestion.num = Convert.ToInt32(textBox2.Text);
                tblsquestion.id_main = Convert.ToInt32(textBox1.Text);


                db.tbl_questions.InsertOnSubmit(tblsquestion);
                db.SubmitChanges();

                var Select_main = (from x in db.tbl_questions
                                   where ((x.id_main.ToString() == textBox1.Text))

                                   select x);

                dgquizmath.DataSource = Select_main.ToList();
                setdg();
                //var childForm = new messegebox();
                //childForm.label1.Text = "اطلاعات مورد نظر با موفقیت ثبت شد.";
                //childForm.Show();
               // MessageBox.Show("--اطلاعات ذخیره شد--", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                settxt();
            }
        }

        private void settxt()
        {
           // settxt(tblsquestion);

            m += 1;
            textBox2.Text = m.ToString();
            txtquestion.Text="";
            txtanswerone.Text="";
           txtanswertwo.Text="";
           txtanswerthree.Text="";
             txtanswerfure.Text="";
             txtquestion.Focus();
        }

        private void rbanswerone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbanswerone.Checked == true)
            {
                txtcorrect.Text = "1";
            }
        }

        private void rbanswertwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbanswertwo.Checked == true)
            {
                txtcorrect.Text = "2";
            }
        }

        private void rbanswerthree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbanswerthree.Checked == true)
            {
                txtcorrect.Text = "3";
            }
        }

        private void rbanswerfure_CheckedChanged(object sender, EventArgs e)
        {
            if (rbanswerfure.Checked == true)
            {
                txtcorrect.Text = "4";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
