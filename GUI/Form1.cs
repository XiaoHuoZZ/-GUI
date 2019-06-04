using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String filePath;
        private String pyPath;
        private String outputPath;

        private void Form1_Load(object sender, EventArgs e)
        {
            flag_std_tb.Text = "0";
            line_tb.Text = "255";
            rank_tb.Text = "3000";
            clusteringNum_tb.Text = "5";
            threshold_tb.Text = "2.5";
            iteration_tb.Text = "100";
            eps_tb.Text = "0.25";
            min_samples_tb.Text = "10";
            lam_tb.Text = "0.8";
            max_iter_tb.Text = "50";
            max_comp_tb.Text = "20";
            

        }

        private void SelectFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择数据源";
            dialog.Filter = "文件(*.csv,*.json)|*.csv;*.json";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = dialog.FileName;
                filePath_tbox.Text = filePath;
            }
        }

        private void SelectPy_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择脚本";
            dialog.Filter = "文件(*.py,*.exe)|*.py;*.exe";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pyPath = dialog.FileName;
                pyPath_tbox.Text = pyPath;
            }
        }

        private void Execute_btn_Click(object sender, EventArgs e)
        {
            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            String suffix = pyPath_tbox.Text;

            String command = null;
            if(suffix.Contains(".exe"))
            {
                command= pyPath_tbox.Text +
                " " + filePath_tbox.Text +
                " " + outfile_tb.Text +
                " " + flag_std_tb.Text +
                " " + line_tb.Text +
                " " + rank_tb.Text +
                " " + clusteringNum_tb.Text +
                " " + threshold_tb.Text +
                " " + iteration_tb.Text +
                " " + eps_tb.Text +
                " " + min_samples_tb.Text +
                " " + lam_tb.Text +
                " " + max_iter_tb.Text +
                " " + max_comp_tb.Text +
                "&exit";
            }
            else
            {
                command = "python " + pyPath_tbox.Text +
                " " + filePath_tbox.Text +
                " " + outfile_tb.Text +
                " " + flag_std_tb.Text +
                " " + line_tb.Text +
                " " + rank_tb.Text +
                " " + clusteringNum_tb.Text +
                " " + threshold_tb.Text +
                " " + iteration_tb.Text +
                " " + eps_tb.Text +
                " " + min_samples_tb.Text +
                " " + lam_tb.Text +
                " " + max_iter_tb.Text +
                " " + max_comp_tb.Text +
                "&exit";
            }

            
            p.StandardInput.WriteLine(command);

            p.StandardInput.AutoFlush = true;
            //p.StandardInput.WriteLine("exit");
            //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
            //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令



            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            NotifyForm n = new NotifyForm();
            n.setText(output);
            n.Show();

        }

        private void SelectOutFile_tb_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择输出文件地址";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                }
                outputPath = dialog.SelectedPath;
                outfile_tb.Text = outputPath;
            }
          
        }
    }
}
