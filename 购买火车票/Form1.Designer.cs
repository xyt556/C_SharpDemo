namespace 购买火车票
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPerson = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textSum = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "月份：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMonth
            // 
            this.textMonth.Location = new System.Drawing.Point(88, 15);
            this.textMonth.MaxLength = 2;
            this.textMonth.Name = "textMonth";
            this.textMonth.Size = new System.Drawing.Size(100, 23);
            this.textMonth.TabIndex = 1;
            this.textMonth.TextChanged += new System.EventHandler(this.textMonth_TextChanged);
            this.textMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMonth_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "订票人数：";
            // 
            // textPerson
            // 
            this.textPerson.Location = new System.Drawing.Point(88, 58);
            this.textPerson.Name = "textPerson";
            this.textPerson.Size = new System.Drawing.Size(100, 23);
            this.textPerson.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.radioYes);
            this.groupBox1.Location = new System.Drawing.Point(204, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "是否为学生";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(13, 48);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(38, 21);
            this.radioNo.TabIndex = 1;
            this.radioNo.Text = "否";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Checked = true;
            this.radioYes.Location = new System.Drawing.Point(12, 29);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(38, 21);
            this.radioYes.TabIndex = 0;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "是";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "票价：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(269, 149);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(100, 23);
            this.textSum.TabIndex = 7;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(88, 101);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 23);
            this.textPrice.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 194);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMonth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "购买火车票";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textMonth;
        private Label label2;
        private TextBox textPerson;
        private GroupBox groupBox1;
        private RadioButton radioNo;
        private RadioButton radioYes;
        private Label label3;
        private Button button1;
        private TextBox textSum;
        private TextBox textPrice;
    }
}