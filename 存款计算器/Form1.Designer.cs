namespace 存款计算器
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.corpus_textBox = new System.Windows.Forms.TextBox();
            this.years_textBox = new System.Windows.Forms.TextBox();
            this.interest_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "最初本金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "存 期（年）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "年利率（%）";
            // 
            // corpus_textBox
            // 
            this.corpus_textBox.Location = new System.Drawing.Point(164, 41);
            this.corpus_textBox.Name = "corpus_textBox";
            this.corpus_textBox.Size = new System.Drawing.Size(100, 23);
            this.corpus_textBox.TabIndex = 3;
            // 
            // years_textBox
            // 
            this.years_textBox.Location = new System.Drawing.Point(164, 73);
            this.years_textBox.Name = "years_textBox";
            this.years_textBox.Size = new System.Drawing.Size(100, 23);
            this.years_textBox.TabIndex = 3;
            // 
            // interest_textBox
            // 
            this.interest_textBox.Location = new System.Drawing.Point(164, 108);
            this.interest_textBox.Name = "interest_textBox";
            this.interest_textBox.Size = new System.Drawing.Size(100, 23);
            this.interest_textBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result_listBox
            // 
            this.result_listBox.FormattingEnabled = true;
            this.result_listBox.ItemHeight = 17;
            this.result_listBox.Items.AddRange(new object[] {
            "存期        本金        利息        总金额"});
            this.result_listBox.Location = new System.Drawing.Point(292, 48);
            this.result_listBox.Name = "result_listBox";
            this.result_listBox.Size = new System.Drawing.Size(352, 123);
            this.result_listBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 188);
            this.Controls.Add(this.result_listBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.interest_textBox);
            this.Controls.Add(this.years_textBox);
            this.Controls.Add(this.corpus_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "存款计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox corpus_textBox;
        private TextBox years_textBox;
        private TextBox interest_textBox;
        private Button button1;
        private Button button2;
        private ListBox result_listBox;
    }
}