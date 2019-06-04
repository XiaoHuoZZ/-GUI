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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectFile_btn = new System.Windows.Forms.Button();
            this.selectPy_btn = new System.Windows.Forms.Button();
            this.execute_btn = new System.Windows.Forms.Button();
            this.filePath_tbox = new System.Windows.Forms.TextBox();
            this.pyPath_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.line_tb = new System.Windows.Forms.TextBox();
            this.rank_tb = new System.Windows.Forms.TextBox();
            this.clusteringNum_tb = new System.Windows.Forms.TextBox();
            this.threshold_tb = new System.Windows.Forms.TextBox();
            this.eps_tb = new System.Windows.Forms.TextBox();
            this.min_samples_tb = new System.Windows.Forms.TextBox();
            this.max_comp_tb = new System.Windows.Forms.TextBox();
            this.selectOutFile_bt = new System.Windows.Forms.Button();
            this.outfile_tb = new System.Windows.Forms.TextBox();
            this.more = new System.Windows.Forms.Button();
            this.flag_std_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iteration_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.max_iter_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lam_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFile_btn
            // 
            this.selectFile_btn.Location = new System.Drawing.Point(58, 38);
            this.selectFile_btn.Name = "selectFile_btn";
            this.selectFile_btn.Size = new System.Drawing.Size(90, 23);
            this.selectFile_btn.TabIndex = 0;
            this.selectFile_btn.Text = "选择数据源";
            this.selectFile_btn.UseVisualStyleBackColor = true;
            this.selectFile_btn.Click += new System.EventHandler(this.SelectFile_btn_Click);
            // 
            // selectPy_btn
            // 
            this.selectPy_btn.Location = new System.Drawing.Point(58, 93);
            this.selectPy_btn.Name = "selectPy_btn";
            this.selectPy_btn.Size = new System.Drawing.Size(92, 23);
            this.selectPy_btn.TabIndex = 1;
            this.selectPy_btn.Text = "选择脚本";
            this.selectPy_btn.UseVisualStyleBackColor = true;
            this.selectPy_btn.Click += new System.EventHandler(this.SelectPy_btn_Click);
            // 
            // execute_btn
            // 
            this.execute_btn.Location = new System.Drawing.Point(287, 249);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(75, 23);
            this.execute_btn.TabIndex = 2;
            this.execute_btn.Text = "execute";
            this.execute_btn.UseVisualStyleBackColor = true;
            this.execute_btn.Click += new System.EventHandler(this.Execute_btn_Click);
            // 
            // filePath_tbox
            // 
            this.filePath_tbox.Location = new System.Drawing.Point(155, 40);
            this.filePath_tbox.Name = "filePath_tbox";
            this.filePath_tbox.Size = new System.Drawing.Size(446, 21);
            this.filePath_tbox.TabIndex = 3;
            // 
            // pyPath_tbox
            // 
            this.pyPath_tbox.Location = new System.Drawing.Point(156, 95);
            this.pyPath_tbox.Name = "pyPath_tbox";
            this.pyPath_tbox.Size = new System.Drawing.Size(445, 21);
            this.pyPath_tbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "rank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "ClusteringNum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "threshold:";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(503, 156);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(29, 12);
            this.lable5.TabIndex = 9;
            this.lable5.Text = "eps:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "min_samples:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "max_comp:";
            // 
            // line_tb
            // 
            this.line_tb.Location = new System.Drawing.Point(334, 67);
            this.line_tb.Name = "line_tb";
            this.line_tb.Size = new System.Drawing.Size(51, 21);
            this.line_tb.TabIndex = 13;
            // 
            // rank_tb
            // 
            this.rank_tb.Location = new System.Drawing.Point(438, 67);
            this.rank_tb.Name = "rank_tb";
            this.rank_tb.Size = new System.Drawing.Size(51, 21);
            this.rank_tb.TabIndex = 14;
            // 
            // clusteringNum_tb
            // 
            this.clusteringNum_tb.Location = new System.Drawing.Point(146, 153);
            this.clusteringNum_tb.Name = "clusteringNum_tb";
            this.clusteringNum_tb.Size = new System.Drawing.Size(51, 21);
            this.clusteringNum_tb.TabIndex = 15;
            // 
            // threshold_tb
            // 
            this.threshold_tb.Location = new System.Drawing.Point(287, 153);
            this.threshold_tb.Name = "threshold_tb";
            this.threshold_tb.Size = new System.Drawing.Size(51, 21);
            this.threshold_tb.TabIndex = 16;
            // 
            // eps_tb
            // 
            this.eps_tb.Location = new System.Drawing.Point(550, 153);
            this.eps_tb.Name = "eps_tb";
            this.eps_tb.Size = new System.Drawing.Size(51, 21);
            this.eps_tb.TabIndex = 17;
            // 
            // min_samples_tb
            // 
            this.min_samples_tb.Location = new System.Drawing.Point(134, 195);
            this.min_samples_tb.Name = "min_samples_tb";
            this.min_samples_tb.Size = new System.Drawing.Size(51, 21);
            this.min_samples_tb.TabIndex = 18;
            // 
            // max_comp_tb
            // 
            this.max_comp_tb.Location = new System.Drawing.Point(550, 195);
            this.max_comp_tb.Name = "max_comp_tb";
            this.max_comp_tb.Size = new System.Drawing.Size(51, 21);
            this.max_comp_tb.TabIndex = 20;
            // 
            // selectOutFile_bt
            // 
            this.selectOutFile_bt.Location = new System.Drawing.Point(58, 122);
            this.selectOutFile_bt.Name = "selectOutFile_bt";
            this.selectOutFile_bt.Size = new System.Drawing.Size(90, 23);
            this.selectOutFile_bt.TabIndex = 21;
            this.selectOutFile_bt.Text = "结果文件地址";
            this.selectOutFile_bt.UseVisualStyleBackColor = true;
            this.selectOutFile_bt.Click += new System.EventHandler(this.SelectOutFile_tb_Click);
            // 
            // outfile_tb
            // 
            this.outfile_tb.Location = new System.Drawing.Point(156, 124);
            this.outfile_tb.Name = "outfile_tb";
            this.outfile_tb.Size = new System.Drawing.Size(445, 21);
            this.outfile_tb.TabIndex = 22;
            // 
            // more
            // 
            this.more.Location = new System.Drawing.Point(524, 69);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(48, 20);
            this.more.TabIndex = 23;
            this.more.Text = "....";
            this.more.UseVisualStyleBackColor = true;
            // 
            // flag_std_tb
            // 
            this.flag_std_tb.Location = new System.Drawing.Point(218, 67);
            this.flag_std_tb.Name = "flag_std_tb";
            this.flag_std_tb.Size = new System.Drawing.Size(51, 21);
            this.flag_std_tb.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "flag_std：";
            // 
            // iteration_tb
            // 
            this.iteration_tb.Location = new System.Drawing.Point(428, 153);
            this.iteration_tb.Name = "iteration_tb";
            this.iteration_tb.Size = new System.Drawing.Size(51, 21);
            this.iteration_tb.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "iteration:";
            // 
            // max_iter_tb
            // 
            this.max_iter_tb.Location = new System.Drawing.Point(271, 195);
            this.max_iter_tb.Name = "max_iter_tb";
            this.max_iter_tb.Size = new System.Drawing.Size(51, 21);
            this.max_iter_tb.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "max_iter:";
            // 
            // lam_tb
            // 
            this.lam_tb.Location = new System.Drawing.Point(402, 195);
            this.lam_tb.Name = "lam_tb";
            this.lam_tb.Size = new System.Drawing.Size(51, 21);
            this.lam_tb.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "lam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 297);
            this.Controls.Add(this.lam_tb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.max_iter_tb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iteration_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flag_std_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.more);
            this.Controls.Add(this.outfile_tb);
            this.Controls.Add(this.selectOutFile_bt);
            this.Controls.Add(this.max_comp_tb);
            this.Controls.Add(this.min_samples_tb);
            this.Controls.Add(this.eps_tb);
            this.Controls.Add(this.threshold_tb);
            this.Controls.Add(this.clusteringNum_tb);
            this.Controls.Add(this.rank_tb);
            this.Controls.Add(this.line_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pyPath_tbox);
            this.Controls.Add(this.filePath_tbox);
            this.Controls.Add(this.execute_btn);
            this.Controls.Add(this.selectPy_btn);
            this.Controls.Add(this.selectFile_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox line_tb;
        private System.Windows.Forms.TextBox rank_tb;
        private System.Windows.Forms.TextBox clusteringNum_tb;
        private System.Windows.Forms.TextBox threshold_tb;
        private System.Windows.Forms.TextBox eps_tb;
        private System.Windows.Forms.TextBox min_samples_tb;
        private System.Windows.Forms.TextBox max_comp_tb;
        private System.Windows.Forms.Button selectOutFile_bt;
        private System.Windows.Forms.TextBox outfile_tb;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.TextBox flag_std_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iteration_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox max_iter_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lam_tb;
        private System.Windows.Forms.Label label11;
    }
}

