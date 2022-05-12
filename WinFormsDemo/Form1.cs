using AForge.Video.DirectShow;
using Microsoft.Win32;
using Sunny.UI;

namespace WinFormsDemo
{
    public partial class Form1 : UIForm
    {
        public static Form1 form1;
        FilterInfoCollection videoDevices;//摄像头设备集合
        VideoCaptureDevice videoSource;//捕获设备源
                                       //Bitmap img;//处理图片

        System.Timers.Timer t = new System.Timers.Timer(1800000);//实例化Timer类，设置间隔时间为10000毫秒；
        //30分钟为1800000毫秒
        public Form1()
        {
            SessionSwitchClass SessionCheck = new SessionSwitchClass();

            t.Elapsed += new System.Timers.ElapsedEventHandler(Execute);//到达时间的时候执行事件；
            t.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            t.Stop(); //先关闭定时器
            InitializeComponent();
            form1 = this;//再把主窗体赋值给form1
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
            //最大化窗体
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void  Execute(object source, System.Timers.ElapsedEventArgs e)
        {
            t.Stop(); //先关闭定时器
                      // 正常显示窗体
            this.Visible = true;
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

            Button1.Enabled = true;//开启“识别功能”
        }
        //双击托盘图标事件
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            t.Stop(); //先关闭定时器
                      // 正常显示窗体
            this.Visible = true;
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

            Button1.Enabled = true;//开启“识别功能”
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

        private void Form1_Load(object sender, EventArgs e)
        {

            // 窗体启动事件代码
            //RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //registryKey.SetValue("BaichuiMonitor", Application.ExecutablePath);//"BaichuiMonitor"可以自定义
            //加载时将窗口置于顶层
            this.TopMost = true;
            //取消窗口边框 在form属性设置中window Style
            //先检测电脑所有的摄像头
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //MessageBox.Show("检测到了" + videoDevices.Count.ToString() + "个摄像头！");
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("检测到电脑没有摄像头-请安装摄像头");
                //关闭程序
                Application.Exit();
            }
            else
            {
                String a = videoDevices.Count.ToString();//1 = 1个

                for (int b = 1;b<=a.ToInt();b++){
                    uiComboBox1.Items.Add("摄像头"+b);
                }
                uiComboBox1.Text = "摄像头1";
            }
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

            Button1.Enabled = true;//开启“识别功能”
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

        private async void Button1_Click(object sender, EventArgs e)
        {
            //img = videoSourcePlayer1.GetCurrentVideoFrame();//拍摄
            //pictureBox1.Image = img;
            //Button2.Enabled = true;//开启“保存”功能
            // 隐藏窗体重新计时 定时开启
            //点击后进行验证  验证完成后隐藏并关闭摄像头

            await Task.Delay(3000); //模仿验证时间
            MessageBox.Show("识别完成");
            this.Visible = false;
            ShutCamera();//释放摄像头
            t.Start(); //执行完毕后再开启器

        }

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    //"保存"按钮click事件

        //        try
        //        {
        //            //以当前时间为文件名，保存为jpg格式
        //            //图片路径在程序bin目录下的Debug下
        //           // TimeSpan tss = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        //            //long a = Convert.ToInt64(tss.TotalMilliseconds) / 1000;  //以秒为单位
        //            //img.Save(string.Format("{0}.jpg", a.ToString()));
        //           // MessageBox.Show("保存成功！");
        //           // Button2.Enabled = false;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //}
        private class SessionSwitchClass 
        {
            /// <summary>
            /// 解屏后执行的委托
            /// </summary>
            public Action SessionUnlockAction { get; set; }

            /// <summary>
            /// 锁屏后执行的委托
            /// </summary>
            public Action SessionLockAction { get; set; }

            public SessionSwitchClass()
            {
                SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
            }

            //析构，防止句柄泄漏
            ~SessionSwitchClass()
            {
                //Do this during application close to avoid handle leak
                SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
            }
            //public string UnlockOrLock = "未触发";///这句是自己的代码
            //当前登录的用户变化（登录、注销和解锁屏）
            public void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
            {
                switch (e.Reason)
                {
                    //用户登录
                    case SessionSwitchReason.SessionLogon:
                        BeginSessionUnlock();
                        break;
                    //解锁屏
                    case SessionSwitchReason.SessionUnlock:
                        BeginSessionUnlock();
                        break;
                    //锁屏
                    case SessionSwitchReason.SessionLock:
                        BeginSessionLock();
                        break;
                    //注销
                    case SessionSwitchReason.SessionLogoff:
                        break;
                }
            }

            /// <summary>
            /// 解屏、登录后执行
            /// </summary>
            private void BeginSessionUnlock()
            {
                //解屏、登录后执行
                form1.t.Stop(); //先关闭定时器
                          // 正常显示窗体
                form1.Visible = true;
                //====================================================
                form1.ShutCamera();//释放摄像头
                if (form1.uiComboBox1.Text == "摄像头1" && form1.videoDevices.Count > 0)
                    form1.videoSource = new VideoCaptureDevice(form1.videoDevices[0].MonikerString);
                else if (form1.uiComboBox1.Text == "摄像头2" && form1.videoDevices.Count > 1)
                    form1.videoSource = new VideoCaptureDevice(form1.videoDevices[1].MonikerString);
                else
                {
                    MessageBox.Show("选择的摄像头不存在！！！");
                    return;
                }
                form1.videoSourcePlayer1.VideoSource = form1.videoSource;
                form1.videoSourcePlayer1.Start();

                form1.Button1.Enabled = true;//开启“拍摄功能”
            }

            /// <summary>
            /// 锁屏后执行
            /// </summary>
            private void BeginSessionLock()
            {
                //锁屏后执行
                form1.t.Stop(); //先关闭定时器
            }
        }

    }
}
