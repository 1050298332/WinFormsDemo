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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 615);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(896, 163);
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
            this.Button2.Location = new System.Drawing.Point(1109, 39);
            this.Button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(175, 61);
            this.Button2.Style = Sunny.UI.UIStyle.Black;
            this.Button2.TabIndex = 4;
            this.Button2.Text = "保存";
            this.Button2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Button1
            // 
            this.Button1.Enabled = false;
            this.Button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(615, 36);
            this.Button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(175, 61);
            this.Button1.Style = Sunny.UI.UIStyle.Black;
            this.Button1.TabIndex = 3;
            this.Button1.Text = "验证";
            this.Button1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox1.Location = new System.Drawing.Point(238, 39);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Radius = 15;
            this.uiComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.uiComboBox1.Size = new System.Drawing.Size(262, 32);
            this.uiComboBox1.Style = Sunny.UI.UIStyle.Black;
            this.uiComboBox1.TabIndex = 2;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.Black;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(26, 103);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(779, 484);
            this.videoSourcePlayer1.TabIndex = 1;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
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
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 106);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.退出ToolStripMenuItem.Text = "登录";
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
            this.设置1ToolStripMenuItem.Text = "1";
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(832, 650);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("微软雅黑", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2560, 1600);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.ShowFullScreen = true;
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Black;
            this.Text = "测试应用";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(26, 26, 1384, 751);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton Button2;
        private Sunny.UI.UIButton Button1;
        private AForge.Controls.PictureBox pictureBox1;
    }
}