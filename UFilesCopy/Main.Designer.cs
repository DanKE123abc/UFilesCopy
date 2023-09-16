namespace UFilesCopy;

partial class Main
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        notifyIcon1 = new NotifyIcon(components);
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        FilesPath = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(10, 12);
        button1.Name = "button1";
        button1.Size = new Size(215, 60);
        button1.TabIndex = 0;
        button1.Text = "创建自动U盘";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Location = new Point(231, 12);
        button2.Name = "button2";
        button2.Size = new Size(215, 60);
        button2.TabIndex = 1;
        button2.Text = "创建配置文件";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button3.Location = new Point(452, 78);
        button3.Name = "button3";
        button3.Size = new Size(215, 60);
        button3.TabIndex = 2;
        button3.Text = "最小化";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // notifyIcon1
        // 
        notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
        notifyIcon1.Text = "U盘自动复制";
        notifyIcon1.Visible = true;
        notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
        // 
        // button4
        // 
        button4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button4.Location = new Point(231, 78);
        button4.Name = "button4";
        button4.Size = new Size(215, 60);
        button4.TabIndex = 3;
        button4.Text = "关闭程序";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button5.Location = new Point(452, 12);
        button5.Name = "button5";
        button5.Size = new Size(215, 60);
        button5.TabIndex = 4;
        button5.Text = "手动复制文件";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        button6.Location = new Point(12, 78);
        button6.Name = "button6";
        button6.Size = new Size(215, 60);
        button6.TabIndex = 5;
        button6.Text = "设置开机自启";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // FilesPath
        // 
        FilesPath.AutoSize = true;
        FilesPath.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        FilesPath.Location = new Point(12, 150);
        FilesPath.Name = "FilesPath";
        FilesPath.Size = new Size(122, 27);
        FilesPath.TabIndex = 6;
        FilesPath.Text = "版本号：1.1";
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(678, 186);
        Controls.Add(FilesPath);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Main";
        Text = "U盘自动复制程序 —— by DYC";
        FormClosed += Main_FormClosed;
        Load += Main_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private NotifyIcon notifyIcon1;
    private Button button4;
    private Button button5;
    private Button button6;
    private Label FilesPath;
}