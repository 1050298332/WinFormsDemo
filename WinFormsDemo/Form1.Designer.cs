namespace WinFormsDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.Button2 = new Sunny.UI.UIButton();
            this.Button1 = new Sunny.UI.UIButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.uiComboBox1);
            this.panel1.Controls.Add(this.videoSourcePlayer1);
            this.panel1.Controls.Add(this.webView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 716);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(993, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(742, 216);
            this.Button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(175, 61);
            this.Button2.Style = Sunny.UI.UIStyle.Black;
            this.Button2.TabIndex = 4;
            this.Button2.Text = "保存";
            this.Button2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(742, 114);
            this.Button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(175, 61);
            this.Button1.Style = Sunny.UI.UIStyle.Black;
            this.Button1.TabIndex = 3;
            this.Button1.Text = "拍照";
            this.Button1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox1.Items.AddRange(new object[] {
            "摄像头1",
            "摄像头2"});
            this.uiComboBox1.Location = new System.Drawing.Point(724, 39);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Radius = 15;
            this.uiComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.uiComboBox1.Size = new System.Drawing.Size(262, 51);
            this.uiComboBox1.Style = Sunny.UI.UIStyle.Black;
            this.uiComboBox1.TabIndex = 2;
            this.uiComboBox1.Text = "摄像头1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(733, 346);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(648, 367);
            this.videoSourcePlayer1.TabIndex = 1;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.webView2.Location = new System.Drawing.Point(0, 0);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(717, 716);
            this.webView2.Source = new System.Uri("file:///C:/Users/sdzy/Desktop/demo.html", System.UriKind.Absolute);
            this.webView2.TabIndex = 0;
            this.webView2.ZoomFactor = 1D;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "测试应用";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.主页ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 140);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.退出ToolStripMenuItem.Text = "登录";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置1ToolStripMenuItem,
            this.设置2ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 设置1ToolStripMenuItem
            // 
            this.设置1ToolStripMenuItem.Name = "设置1ToolStripMenuItem";
            this.设置1ToolStripMenuItem.Size = new System.Drawing.Size(183, 40);
            this.设置1ToolStripMenuItem.Text = "设置1";
            // 
            // 设置2ToolStripMenuItem
            // 
            this.设置2ToolStripMenuItem.Name = "设置2ToolStripMenuItem";
            this.设置2ToolStripMenuItem.Size = new System.Drawing.Size(183, 40);
            this.设置2ToolStripMenuItem.Text = "设置2";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(126, 34);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.LayuiOrange;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1384, 751);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Black;
            this.Text = "测试应用";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(26, 26, 1384, 751);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 设置1ToolStripMenuItem;
        private ToolStripMenuItem 设置2ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem1;
        private ToolStripMenuItem 主页ToolStripMenuItem;
        public Sunny.UI.UIStyleManager uiStyleManager1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton Button2;
        private Sunny.UI.UIButton Button1;
        private AForge.Controls.PictureBox pictureBox1;
    }
}