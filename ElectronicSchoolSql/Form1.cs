using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ElectronicSchoolSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        GraphicsPath shape = new GraphicsPath();
        public int height,width,Count,Model;
        Rectangle rec;
        bool[,] arrPixel;
        int CountTotalPixel;
        int PixelBandi = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Model)
            {
                case 1:
                    height -= 5;
                    rec = new Rectangle(0, 0, Application.OpenForms["frmresult"].Width, height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    if (height <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    }
                    break;
                case 2:
                    height -= 5;
                    rec = new Rectangle(0, Application.OpenForms["frmresult"].Height-height, Application.OpenForms["frmresult"].Width, height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    if (height <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    } 
                    break;
                case 3:
                    width -= 5;
                    rec = new Rectangle(Application.OpenForms["frmresult"].Width-width, 0, width, Application.OpenForms["frmresult"].Height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    if (width <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    } 
                    break;
                case 4:
                    width -= 5;
                    rec = new Rectangle(0, 0, width, Application.OpenForms["frmresult"].Height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    if (width <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    } 
                    break;
                case 5:
                    height -= 10;
                    width -= 10;
                    rec = new Rectangle((Application.OpenForms["frmresult"].Width-width)/2, 
                                        (Application.OpenForms["frmresult"].Height - height)/2, width, height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    if (height <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    } break;
                case 6:
                    Count++;
                    if (Count % 10 == 0)
                    {
                        shape.Reset();
                        Rectangle rect = new Rectangle();
                        Random rnd = new Random();
                        for (int x = 0; x < width ; x += PixelBandi)
                        {
                            for (int y = 0; y < height ; y += PixelBandi)
                            {
                                rect.X = x;
                                rect.Y = y;
                                rect.Width = rect.Height = PixelBandi;
                                if (!arrPixel[x / PixelBandi, y / PixelBandi])
                                {
                                    if (Convert.ToBoolean(rnd.Next(0, 6)))
                                    {
                                        shape.AddArc(rect,rnd.Next(100),rnd.Next(100));
                                        arrPixel[x / PixelBandi, y / PixelBandi] = true;
                                        CountTotalPixel++;
                                    }
                                }
                                
                            }
                        }
                        Application.OpenForms["frmresult"].Region = new Region(shape);
                    }
                    if (Count>=60)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                        Count = 0;
                    } 
                    break;
                case 7:
                    Count++;
                    if (Count % 10 == 0)
                    {
                        //shape.Reset();
                        Rectangle rect = new Rectangle();
                        Random rnd = new Random();
                        for (int x = 0; x < width; x += PixelBandi)
                        {
                            for (int y = 0; y < height; y += PixelBandi)
                            {
                                rect.X = x;
                                rect.Y = y;
                                rect.Width = rect.Height = PixelBandi;
                                if (!arrPixel[x / PixelBandi, y / PixelBandi])
                                {
                                    if (Convert.ToBoolean(rnd.Next(0, 6)))
                                    {
                                        shape.AddArc(rect, rnd.Next(100), rnd.Next(100));
                                        arrPixel[x / PixelBandi, y / PixelBandi] = true;
                                        CountTotalPixel++;
                                    }
                                }

                            }
                        }
                        Application.OpenForms["frmresult"].Region = new Region(shape);
                    }
                    if (Count >= 60)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                        Count = 0;
                    } 
                    break;
                case 8:
                    Count++;
                    if (Count % 10 == 0)
                    {
                        shape.Reset();
                        Rectangle rect = new Rectangle();
                        Random rnd = new Random();
                        for (int x = 0; x < width; x += PixelBandi)
                        {
                            for (int y = 0; y < height; y += PixelBandi)
                            {
                                rect.X = x;
                                rect.Y = y;
                                rect.Width = rect.Height = PixelBandi;
                                if (!arrPixel[x / PixelBandi, y / PixelBandi])
                                {
                                    if (Convert.ToBoolean(rnd.Next(0, 6)))
                                    {
                                        shape.AddArc(rect, rnd.Next(100), rnd.Next(100));
                                        arrPixel[x / PixelBandi, y / PixelBandi] = true;
                                        CountTotalPixel++;
                                    }
                                }

                            }
                        }
                        Application.OpenForms["frmresult"].Region = new Region(shape);
                    }
                    if (Count >= 60)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                        Count = 0;
                    }
                    break;
                case 9:
                    Count++;
                    if (Count % 10 == 0)
                    {
                        shape.Reset();
                        Rectangle rect = new Rectangle();
                        Random rnd = new Random();
                        for (int x = 0; x < width; x += PixelBandi)
                        {
                            for (int y = 0; y < height; y += PixelBandi)
                            {
                                rect.X = x;
                                rect.Y = y;
                                rect.Width = rect.Height = PixelBandi;
                                if (!arrPixel[x / PixelBandi, y / PixelBandi])
                                {
                                    if (Convert.ToBoolean(rnd.Next(0, 2)))
                                    {
                                        shape.AddEllipse(rect);
                                        arrPixel[x / PixelBandi, y / PixelBandi] = true;
                                        CountTotalPixel++;
                                    }
                                }

                            }
                        }
                        Application.OpenForms["frmresult"].Region = new Region(shape);
                    }
                    if (Count >= 60)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                        Count = 0;
                    }
                    break;
                case 10:
                    Count++;
                    if (Count % 10 == 0)
                    {
                        shape.Reset();
                        Rectangle rect = new Rectangle();
                        Random rnd = new Random();
                        for (int x = 0; x < width; x += PixelBandi)
                        {
                            for (int y = 0; y < height; y += PixelBandi)
                            {
                                rect.X = x;
                                rect.Y = y;
                                rect.Width = rect.Height = PixelBandi;
                                if (!arrPixel[x / PixelBandi, y / PixelBandi])
                                {
                                    if (Convert.ToBoolean(rnd.Next(0, 2)))
                                    {
                                        shape.AddRectangle(rect);
                                        arrPixel[x / PixelBandi, y / PixelBandi] = true;
                                        CountTotalPixel++;
                                    }
                                }

                            }
                        }
                        Application.OpenForms["frmresult"].Region = new Region(shape);
                    }
                    if (Count >= 60)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                        Count = 0;
                    }
                    break;
                case 11:
                    height -= 5;
                    rec = new Rectangle(0, Application.OpenForms["frmresult"].Height - height, Application.OpenForms["frmresult"].Width, height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    Application.OpenForms["frmresult"].Top -= 5;
                    if (height <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    } 
                    break;
                case 12:
                    height -= 5;
                    rec = new Rectangle(0, 0, Application.OpenForms["frmresult"].Width, height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    Application.OpenForms["frmresult"].Top += 5;
                    if (height <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    }
                    break;
                case 13:
                    width -= 5;
                    rec = new Rectangle(Application.OpenForms["frmresult"].Width - width, 0, width, Application.OpenForms["frmresult"].Height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    Application.OpenForms["frmresult"].Left+=5 ;
                    if (width <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    }
                    break;
                case 14:
                    width -= 5;
                    rec = new Rectangle(0, 0, width, Application.OpenForms["frmresult"].Height);
                    shape.Reset();
                    shape.AddRectangle(rec);
                    Application.OpenForms["frmresult"].Region = new Region(shape);
                    Application.OpenForms["frmresult"].Left -= 5;
                    if (width <= 0)
                    {
                        Application.OpenForms["frmresult"].Close();
                        Model = 0;
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 1;
            timer1.Enabled = true;
            height = f2.Height;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 2;
            timer1.Enabled = true;
            height = f2.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 3;
            timer1.Enabled = true;
            width = f2.Width;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 4;
            timer1.Enabled = true;
            width = f2.Width;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 5;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 6;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
            arrPixel = new bool[height / PixelBandi+25, width / PixelBandi+25];
            CountTotalPixel = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 7;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
            arrPixel = new bool[height / PixelBandi + 25, width / PixelBandi + 25];
            CountTotalPixel = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 8;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
            arrPixel = new bool[height / PixelBandi + 25, width / PixelBandi + 25];
            CountTotalPixel = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 9;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
            arrPixel = new bool[height / PixelBandi + 25, width / PixelBandi + 25];
            CountTotalPixel = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 10;
            timer1.Enabled = true;
            height = f2.Height;
            width = f2.Width;
            arrPixel = new bool[height / PixelBandi + 25, width / PixelBandi + 25];
            CountTotalPixel = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 11;
            timer1.Enabled = true;
            height = f2.Height;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 12;
            timer1.Enabled = true;
            height = f2.Height;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 13;
            timer1.Enabled = true;
            width = f2.Width;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmresult f2 = new frmresult();
            f2.Show();
            Model = 14;
            timer1.Enabled = true;
            width = f2.Width;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = (int)numericUpDown1.Value;
            }
            catch
            {
                MessageBox.Show("لطفا عدد صحيح وارد كنيد");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                PixelBandi = (int)numericUpDown2.Value;
            }
            catch
            {
                MessageBox.Show("لطفا عدد صحيح وارد كنيد");
            }
        }
    }
}
