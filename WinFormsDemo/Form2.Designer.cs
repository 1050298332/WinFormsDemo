namespace WinFormsDemo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忘记密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.解锁ToolStripMenuItem,
            this.忘记密码ToolStripMenuItem,
            this.联系管理员ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 106);
            // 
            // 解锁ToolStripMenuItem
            // 
            this.解锁ToolStripMenuItem.Name = "解锁ToolStripMenuItem";
            this.解锁ToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.解锁ToolStripMenuItem.Text = "解锁";
            // 
            // 忘记密码ToolStripMenuItem
            // 
            this.忘记密码ToolStripMenuItem.Name = "忘记密码ToolStripMenuItem";
            this.忘记密码ToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.忘记密码ToolStripMenuItem.Text = "忘记密码";
            // 
            // 联系管理员ToolStripMenuItem
            // 
            this.联系管理员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置1ToolStripMenuItem,
            this.设置2ToolStripMenuItem});
            this.联系管理员ToolStripMenuItem.Name = "联系管理员ToolStripMenuItem";
            this.联系管理员ToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.联系管理员ToolStripMenuItem.Text = "联系管理员";
            // 
            // 设置1ToolStripMenuItem
            // 
            this.设置1ToolStripMenuItem.Name = "设置1ToolStripMenuItem";
            this.设置1ToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.设置1ToolStripMenuItem.Text = "临时离开密码";
            // 
            // 设置2ToolStripMenuItem
            // 
            this.设置2ToolStripMenuItem.Name = "设置2ToolStripMenuItem";
            this.设置2ToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.设置2ToolStripMenuItem.Text = "设置2";
            // 
            // Form2
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(651, 517);
            this.ControlBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2560, 1600);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowFullScreen = true;
            this.ShowIcon = false;
            this.ShowTitle = false;
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(26, 26, 651, 517);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 解锁ToolStripMenuItem;
        private ToolStripMenuItem 忘记密码ToolStripMenuItem;
        private ToolStripMenuItem 联系管理员ToolStripMenuItem;
        private ToolStripMenuItem 设置1ToolStripMenuItem;
        private ToolStripMenuItem 设置2ToolStripMenuItem;
    }
}