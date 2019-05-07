namespace GUI
{
    partial class Form1
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
            this.selectFile_btn = new System.Windows.Forms.Button();
            this.selectPy_btn = new System.Windows.Forms.Button();
            this.execute_btn = new System.Windows.Forms.Button();
            this.filePath_tbox = new System.Windows.Forms.TextBox();
            this.pyPath_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFile_btn
            // 
            this.selectFile_btn.Location = new System.Drawing.Point(73, 100);
            this.selectFile_btn.Name = "selectFile_btn";
            this.selectFile_btn.Size = new System.Drawing.Size(75, 23);
            this.selectFile_btn.TabIndex = 0;
            this.selectFile_btn.Text = "选择数据源";
            this.selectFile_btn.UseVisualStyleBackColor = true;
            this.selectFile_btn.Click += new System.EventHandler(this.SelectFile_btn_Click);
            // 
            // selectPy_btn
            // 
            this.selectPy_btn.Location = new System.Drawing.Point(73, 129);
            this.selectPy_btn.Name = "selectPy_btn";
            this.selectPy_btn.Size = new System.Drawing.Size(75, 23);
            this.selectPy_btn.TabIndex = 1;
            this.selectPy_btn.Text = "选择脚本";
            this.selectPy_btn.UseVisualStyleBackColor = true;
            this.selectPy_btn.Click += new System.EventHandler(this.SelectPy_btn_Click);
            // 
            // execute_btn
            // 
            this.execute_btn.Location = new System.Drawing.Point(196, 227);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(75, 23);
            this.execute_btn.TabIndex = 2;
            this.execute_btn.Text = "执行";
            this.execute_btn.UseVisualStyleBackColor = true;
            this.execute_btn.Click += new System.EventHandler(this.Execute_btn_Click);
            // 
            // filePath_tbox
            // 
            this.filePath_tbox.Location = new System.Drawing.Point(155, 101);
            this.filePath_tbox.Name = "filePath_tbox";
            this.filePath_tbox.Size = new System.Drawing.Size(229, 21);
            this.filePath_tbox.TabIndex = 3;
            // 
            // pyPath_tbox
            // 
            this.pyPath_tbox.Location = new System.Drawing.Point(155, 131);
            this.pyPath_tbox.Name = "pyPath_tbox";
            this.pyPath_tbox.Size = new System.Drawing.Size(229, 21);
            this.pyPath_tbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 297);
            this.Controls.Add(this.pyPath_tbox);
            this.Controls.Add(this.filePath_tbox);
            this.Controls.Add(this.execute_btn);
            this.Controls.Add(this.selectPy_btn);
            this.Controls.Add(this.selectFile_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "离群点分析";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFile_btn;
        private System.Windows.Forms.Button selectPy_btn;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.TextBox filePath_tbox;
        private System.Windows.Forms.TextBox pyPath_tbox;
    }
}

