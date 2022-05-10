using Sunny.UI;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WinFormsDemo
{
    public partial class Form1 : UIForm
    {
        FilterInfoCollection videoDevices;//摄像头设备集合
        VideoCaptureDevice videoSource;//捕获设备源
        Bitmap img;//处理图片

        public Form1()
        {

            InitializeComponent();
            //最大化窗体
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //全屏窗体时内容不受任务栏影响
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }
        //最小化事件
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // 判断只有最小化时，隐藏窗体
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        //双击托盘图标事件
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 正常显示窗体
            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            ShutCamera();//释放摄像头
            if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView2.Source =  new Uri("http://mccsdl.top/login");
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView2.Source = new Uri("http://mccsdl.top");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //先检测电脑所有的摄像头
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            MessageBox.Show("检测到了" + videoDevices.Count.ToString() + "个摄像头！");
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShutCamera();//释放摄像头
            if (uiComboBox1.Text == "摄像头1" && videoDevices.Count > 0)
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            else if (uiComboBox1.Text == "摄像头2" && videoDevices.Count > 1)
                videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            else
            {
                MessageBox.Show("选择的摄像头不存在！！！");
                return;
            }
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

            Button1.Enabled = true;//开启“拍摄功能”
        }

        // 关闭并释放摄像头
        public void ShutCamera()
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
                videoSourcePlayer1.VideoSource = null;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                img = videoSourcePlayer1.GetCurrentVideoFrame();//拍摄
                pictureBox1.Image = img;
                Button2.Enabled = true;//开启“保存”功能
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //"保存"按钮click事件
       
                try
                {
                    //以当前时间为文件名，保存为jpg格式
                    //图片路径在程序bin目录下的Debug下
                    TimeSpan tss = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    long a = Convert.ToInt64(tss.TotalMilliseconds) / 1000;  //以秒为单位
                    img.Save(string.Format("{0}.jpg", a.ToString()));
                    MessageBox.Show("保存成功！");
                    Button2.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
