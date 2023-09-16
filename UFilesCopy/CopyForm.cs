using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFilesCopy.Base;
using UFilesCopy.Code;

namespace UFilesCopy
{
    public partial class CopyForm : Form
    {
        public CopyForm(string sourceDir, string Disk)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//默认居中显示
            FilesPath.Text = "正在将" + sourceDir + " 复制到 " + Disk;
            ShowCopyProgress(0);
            FilesPath.Refresh();
            label1.Refresh();
        }


        public void Copy(string sourceDir, string Disk)
        {
            FilesPath.Text = "正在将" + sourceDir + " 复制到 " + Disk;
            FilesPath.Refresh();
            label1.Refresh();
            EventCenter.instance.AddEventListener<float>(sourceDir, ShowCopyProgress);
            try
            {
                //var progressCallback = new DirectoryManager.CopyProgressDelegate(ShowCopyProgress);
                var destDir = Disk + "\\$自动复制" + sourceDir.Substring(2);
                DirectoryManager.CopyDirectory(sourceDir, destDir);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错！请联系开发者:" + ex, "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ShowCopyProgress(float percentComplete)
        {
            progressBar.Value = (int)percentComplete;
            FilesPath.Refresh();
            label1.Refresh();
            progressBar.Refresh();
        }

    }
}
