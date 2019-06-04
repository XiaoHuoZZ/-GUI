namespace GUI
{
    partial class NotifyForm
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
            this.notify_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notify_tb
            // 
            this.notify_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notify_tb.Location = new System.Drawing.Point(0, 0);
            this.notify_tb.Multiline = true;
            this.notify_tb.Name = "notify_tb";
            this.notify_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notify_tb.Size = new System.Drawing.Size(547, 328);
            this.notify_tb.TabIndex = 0;
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 328);
            this.Controls.Add(this.notify_tb);
            this.Name = "NotifyForm";
            this.Text = "result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notify_tb;
    }
}