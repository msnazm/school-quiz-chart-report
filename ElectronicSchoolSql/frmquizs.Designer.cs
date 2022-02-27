namespace ElectronicSchoolSql
{
    partial class frmquizs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquizs));
            this.txtnumquiz = new System.Windows.Forms.TextBox();
            this.txtquiz = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsavequiz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumquiz
            // 
            this.txtnumquiz.Location = new System.Drawing.Point(19, 75);
            this.txtnumquiz.Name = "txtnumquiz";
            this.txtnumquiz.ReadOnly = true;
            this.txtnumquiz.Size = new System.Drawing.Size(275, 26);
            this.txtnumquiz.TabIndex = 65;
            this.txtnumquiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtquiz
            // 
            this.txtquiz.Location = new System.Drawing.Point(19, 118);
            this.txtquiz.MaxLength = 100;
            this.txtquiz.Name = "txtquiz";
            this.txtquiz.Size = new System.Drawing.Size(275, 26);
            this.txtquiz.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(118, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "تاریخ:";
            this.label8.Visible = false;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(12, 12);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 26);
            this.txtdate.TabIndex = 62;
            this.txtdate.Visible = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(82, 229);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(148, 45);
            this.exit.TabIndex = 67;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(300, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "شماره آزمون:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(300, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "آزمون:";
            // 
            // btnsavequiz
            // 
            this.btnsavequiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsavequiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavequiz.Location = new System.Drawing.Point(82, 176);
            this.btnsavequiz.Name = "btnsavequiz";
            this.btnsavequiz.Size = new System.Drawing.Size(148, 47);
            this.btnsavequiz.TabIndex = 60;
            this.btnsavequiz.Text = "ایجاد آزمون";
            this.btnsavequiz.UseVisualStyleBackColor = false;
            this.btnsavequiz.Click += new System.EventHandler(this.btnsavequiz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::ElectronicSchoolSql.Properties.Resources.formsmall;
            this.pictureBox1.Image = global::ElectronicSchoolSql.Properties.Resources.formsmall1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // frmquizs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumquiz);
            this.Controls.Add(this.txtquiz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsavequiz);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 400);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmquizs";
            this.Opacity = 0.7D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "فرم ایجاد آزمون";
            this.Load += new System.EventHandler(this.frmquizs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtnumquiz;
        public System.Windows.Forms.TextBox txtquiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsavequiz;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}