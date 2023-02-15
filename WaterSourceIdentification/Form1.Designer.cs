namespace WaterSourceIdentification
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtTurbidity = new System.Windows.Forms.TextBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(79, 183);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "结果";
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(67, 111);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(100, 21);
            this.txtPH.TabIndex = 1;
            // 
            // txtTurbidity
            // 
            this.txtTurbidity.Location = new System.Drawing.Point(211, 111);
            this.txtTurbidity.Name = "txtTurbidity";
            this.txtTurbidity.Size = new System.Drawing.Size(100, 21);
            this.txtTurbidity.TabIndex = 2;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(139, 149);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 3;
            this.btnIdentify.Text = "判别";
            this.btnIdentify.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(182, 69);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(324, 21);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(67, 69);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "打开";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.txtTurbidity);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtTurbidity;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
    }
}

