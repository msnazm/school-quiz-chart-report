namespace ElectronicSchoolSql
{
    partial class frmbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbook));
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumbook = new System.Windows.Forms.TextBox();
            this.txtnamebook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsavebook = new System.Windows.Forms.Button();
            this.cmdquiz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "شماره کتاب:";
            // 
            // txtnumbook
            // 
            this.txtnumbook.Location = new System.Drawing.Point(26, 98);
            this.txtnumbook.Name = "txtnumbook";
            this.txtnumbook.ReadOnly = true;
            this.txtnumbook.Size = new System.Drawing.Size(280, 26);
            this.txtnumbook.TabIndex = 72;
            this.txtnumbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnamebook
            // 
            this.txtnamebook.Location = new System.Drawing.Point(26, 146);
            this.txtnamebook.MaxLength = 100;
            this.txtnamebook.Name = "txtnamebook";
            this.txtnamebook.Size = new System.Drawing.Size(280, 26);
            this.txtnamebook.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "نام کتاب:";
            // 
            // btnsavebook
            // 
            this.btnsavebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsavebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavebook.Location = new System.Drawing.Point(82, 188);
            this.btnsavebook.Name = "btnsavebook";
            this.btnsavebook.Size = new System.Drawing.Size(148, 48);
            this.btnsavebook.TabIndex = 67;
            this.btnsavebook.Text = "ایجاد کتاب";
            this.btnsavebook.UseVisualStyleBackColor = false;
            this.btnsavebook.Click += new System.EventHandler(this.btnsavebook_Click);
            // 
            // cmdquiz
            // 
            this.cmdquiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdquiz.FormattingEnabled = true;
            this.cmdquiz.Location = new System.Drawing.Point(26, 46);
            this.cmdquiz.Name = "cmdquiz";
            this.cmdquiz.Size = new System.Drawing.Size(280, 27);
            this.cmdquiz.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "آزمون:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ElectronicSchoolSql.Properties.Resources.formsmall1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(82, 242);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(148, 45);
            this.exit.TabIndex = 83;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.cmdquiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumbook);
            this.Controls.Add(this.txtnamebook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsavebook);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmbook";
            this.Opacity = 0.8D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ایجاد کتاب آزمون";
            this.Load += new System.EventHandler(this.frmbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnumbook;
        public System.Windows.Forms.TextBox txtnamebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsavebook;
        private System.Windows.Forms.ComboBox cmdquiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
    }
}