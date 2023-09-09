using Microsoft.VisualBasic;
using UFilesCopy.Base;
using UFilesCopy.Code;
using DanKeJson;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UFilesCopy;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;//默认居中显示
        EventCenter.instance.AddEventListener<string>("USBin", IsCopy);
        UsbListener.Start();
        try
        {
            this.Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void IsCopy(string disk)
    {
        if (File.Exists(disk + "\\.dycopydisk"))
        {
            DialogResult result;
            result = MessageBox.Show("是否复制文件？", "U盘文件自动复制", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result.ToString() == "Yes")
            {
                string filePath = "C:\\dycufilescopy.json";
                if (!File.Exists(filePath))
                {
                    //MessageBox.Show("配置文件不存在！", "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);
                    return;
                }
                string jsonconfig = File.ReadAllText(filePath);
                JsonData config = JSON.ToData(jsonconfig);
                for (int i = 0; i < config.array.Count; i++)
                {
                    using (CopyForm form = new CopyForm(config[i], disk))
                    {
                        form.Show();
                        form.Copy(config[i], disk);
                    }
                }
                MessageBox.Show(disk + " 复制完成", "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        saveFileDialog.Title = "！！！请选择在U盘根目录！！！";

        saveFileDialog.FileName = ".dycopydisk";

        DialogResult result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            string directoryPath = Path.GetDirectoryName(saveFileDialog.FileName);
            string filePath = Path.Combine(directoryPath, ".dycopydisk");
            File.Create(filePath);

        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        File.Create("C:\\dycufilescopy.json");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            this.Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        try
        {
            if (this.WindowState == FormWindowState.Minimized)//当程序是最小化的状态时显示程序页面
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
            this.Visible = true;
            this.ShowInTaskbar = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        try
        {
            this.Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        System.Environment.Exit(0);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        saveFileDialog.Title = "手动复制文件 - 请选择目录";

        DialogResult result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            string directoryPath = Path.GetDirectoryName(saveFileDialog.FileName);
            string filePath = "C:\\dycufilescopy.json";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("配置文件不存在！", "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
                return;
            }
            string jsonconfig = File.ReadAllText(filePath);
            JsonData config = JSON.ToData(jsonconfig);
            for (int i = 0; i < config.array.Count; i++)
            {
                using (CopyForm form = new CopyForm(config[i], directoryPath))
                {
                    form.Show();
                    form.Copy(config[i], directoryPath);
                }
            }
            MessageBox.Show(directoryPath + " 复制完成", "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
         ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        registryKey.SetValue("UdiskAutoCopyFiles", Application.ExecutablePath);
        MessageBox.Show("设置开机自启成功", "U盘文件自动复制", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Main_Load(object sender, EventArgs e)
    {
        this.BeginInvoke(new Action(() => {
            this.Visible = false;
        }));
    }
}