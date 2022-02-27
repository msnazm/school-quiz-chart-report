namespace ElectronicSchoolSql
{
    partial class frmlesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlesson));
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumlesson = new System.Windows.Forms.TextBox();
            this.txtnamelesson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsavelesson = new System.Windows.Forms.Button();
            this.cmdbook = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "شماره درس:";
            // 
            // txtnumlesson
            // 
            this.txtnumlesson.Location = new System.Drawing.Point(49, 74);
            this.txtnumlesson.Name = "txtnumlesson";
            this.txtnumlesson.ReadOnly = true;
            this.txtnumlesson.Size = new System.Drawing.Size(227, 26);
            this.txtnumlesson.TabIndex = 77;
            this.txtnumlesson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnamelesson
            // 
            this.txtnamelesson.Location = new System.Drawing.Point(49, 115);
            this.txtnamelesson.MaxLength = 100;
            this.txtnamelesson.Name = "txtnamelesson";
            this.txtnamelesson.Size = new System.Drawing.Size(228, 26);
            this.txtnamelesson.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "نام درس:";
            // 
            // btnsavelesson
            // 
            this.btnsavelesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsavelesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavelesson.Location = new System.Drawing.Point(95, 158);
            this.btnsavelesson.Name = "btnsavelesson";
            this.btnsavelesson.Size = new System.Drawing.Size(148, 44);
            this.btnsavelesson.TabIndex = 74;
            this.btnsavelesson.Text = "ایجاد درس";
            this.btnsavelesson.UseVisualStyleBackColor = false;
            this.btnsavelesson.Click += new System.EventHandler(this.btnsavelesson_Click);
            // 
            // cmdbook
            // 
            this.cmdbook.BackColor = System.Drawing.SystemColors.Window;
            this.cmdbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdbook.FormattingEnabled = true;
            this.cmdbook.Location = new System.Drawing.Point(49, 32);
            this.cmdbook.Name = "cmdbook";
            this.cmdbook.Size = new System.Drawing.Size(227, 27);
            this.cmdbook.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "کتاب:";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(95, 208);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(148, 45);
            this.exit.TabIndex = 82;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ElectronicSchoolSql.Properties.Resources.formsmall1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::ElectronicSchoolSql.Properties.Resources.formsmall1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // frmlesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.cmdbook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumlesson);
            this.Controls.Add(this.txtnamelesson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsavelesson);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmlesson";
            this.Opacity = 0.8D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ایجاد درس آزمون";
            this.Load += new System.EventHandler(this.frmlesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnumlesson;
        public System.Windows.Forms.TextBox txtnamelesson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsavelesson;
        private System.Windows.Forms.ComboBox cmdbook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
    }
}