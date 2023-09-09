namespace UFilesCopy
{
    partial class CopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyForm));
            progressBar = new ProgressBar();
            FilesPath = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(37, 106);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(565, 51);
            progressBar.TabIndex = 0;
            // 
            // FilesPath
            // 
            FilesPath.AutoSize = true;
            FilesPath.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FilesPath.Location = new Point(37, 56);
            FilesPath.Name = "FilesPath";
            FilesPath.Size = new Size(113, 27);
            FilesPath.TabIndex = 2;
            FilesPath.Text = "C:\\File.file";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 33);
            label1.TabIndex = 3;
            label1.Text = "自动复制中...";
            // 
            // CopyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 181);
            Controls.Add(label1);
            Controls.Add(FilesPath);
            Controls.Add(progressBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CopyForm";
            Text = "U盘自动复制进度";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label FilesPath;
        private Label label1;
    }
}