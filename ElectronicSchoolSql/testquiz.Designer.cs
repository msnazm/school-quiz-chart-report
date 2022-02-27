namespace ElectronicSchoolSql
{
    partial class testquiz
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
            this.cmdquiz = new System.Windows.Forms.ComboBox();
            this.cmdbook = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdlesson = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdquiz
            // 
            this.cmdquiz.FormattingEnabled = true;
            this.cmdquiz.Location = new System.Drawing.Point(108, 33);
            this.cmdquiz.Name = "cmdquiz";
            this.cmdquiz.Size = new System.Drawing.Size(121, 27);
            this.cmdquiz.TabIndex = 0;
            // 
            // cmdbook
            // 
            this.cmdbook.FormattingEnabled = true;
            this.cmdbook.Location = new System.Drawing.Point(108, 75);
            this.cmdbook.Name = "cmdbook";
            this.cmdbook.Size = new System.Drawing.Size(121, 27);
            this.cmdbook.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "کتاب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "آزمون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "درس:";
            // 
            // cmdlesson
            // 
            this.cmdlesson.FormattingEnabled = true;
            this.cmdlesson.Location = new System.Drawing.Point(108, 118);
            this.cmdlesson.Name = "cmdlesson";
            this.cmdlesson.Size = new System.Drawing.Size(121, 27);
            this.cmdlesson.TabIndex = 47;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(73, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 66);
            this.btnStart.TabIndex = 49;
            this.btnStart.Text = "شروع آزمون";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // testquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 276);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdlesson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdbook);
            this.Controls.Add(this.cmdquiz);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "testquiz";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "testquiz";
            this.Load += new System.EventHandler(this.testquiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdquiz;
        private System.Windows.Forms.ComboBox cmdbook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdlesson;
        private System.Windows.Forms.Button btnStart;
    }
}