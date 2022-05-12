using AForge.Video.DirectShow;
using Microsoft.Win32;
using Sunny.UI;

namespace WinFormsDemo
{
    public partial class Form1 : UIForm
    {
        public static Form1 form1;
        FilterInfoCollection videoDevices;//����ͷ�豸����
        VideoCaptureDevice videoSource;//�����豸Դ
                                       //Bitmap img;//����ͼƬ

        System.Timers.Timer t = new System.Timers.Timer(1800000);//ʵ����Timer�࣬���ü��ʱ��Ϊ10000���룻
        //30����Ϊ1800000����
        public Form1()
        {
            SessionSwitchClass SessionCheck = new SessionSwitchClass();

            t.Elapsed += new System.Timers.ElapsedEventHandler(Execute);//����ʱ���ʱ��ִ���¼���
            t.AutoReset = false;//������ִ��һ�Σ�false������һֱִ��(true)��
            t.Enabled = true;//�Ƿ�ִ��System.Timers.Timer.Elapsed�¼���
            t.Stop(); //�ȹرն�ʱ��
            InitializeComponent();
            form1 = this;//�ٰ������帳ֵ��form1
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//���ø����� Ϊfalse
            //��󻯴���
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void  Execute(object source, System.Timers.ElapsedEventArgs e)
        {
            t.Stop(); //�ȹرն�ʱ��
                      // ������ʾ����
            this.Visible = true;
            ShutCamera();//�ͷ�����ͷ
            if (uiComboBox1.Text == "����ͷ1" && videoDevices.Count > 0)
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            else if (uiComboBox1.Text == "����ͷ2" && videoDevices.Count > 1)
                videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            else
            {
                MessageBox.Show("ѡ�������ͷ�����ڣ�����");
                return;
            }
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

            Button1.Enabled = true;//������ʶ���ܡ�
        }
        //˫������ͼ���¼�
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            t.Stop(); //�ȹرն�ʱ��
                      // ������ʾ����
            this.Visible = true;
            ShutCamera();//�ͷ�����ͷ
            if (uiComboBox1.Text == "����ͷ1" && videoDevices.Count > 0)
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            else if (uiComboBox1.Text == "����ͷ2" && videoDevices.Count > 1)
                videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            else
            {
                MessageBox.Show("ѡ�������ͷ�����ڣ�����");
                return;
            }
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

            Button1.Enabled = true;//������ʶ���ܡ�
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            ShutCamera();//�ͷ�����ͷ
            if (e.CloseReason == CloseReason.UserClosing)//���û�����������Ͻ�X��ť��(Alt + F4)ʱ ����          
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void �˳�ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // ���������¼�����
            //RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //registryKey.SetValue("BaichuiMonitor", Application.ExecutablePath);//"BaichuiMonitor"�����Զ���
            //����ʱ���������ڶ���
            this.TopMost = true;
            //ȡ�����ڱ߿� ��form����������window Style
            //�ȼ��������е�����ͷ
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //MessageBox.Show("��⵽��" + videoDevices.Count.ToString() + "������ͷ��");
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("��⵽����û������ͷ-�밲װ����ͷ");
                //�رճ���
                Application.Exit();
            }
            else
            {
                String a = videoDevices.Count.ToString();//1 = 1��

                for (int b = 1;b<=a.ToInt();b++){
                    uiComboBox1.Items.Add("����ͷ"+b);
                }
                uiComboBox1.Text = "����ͷ1";
            }
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShutCamera();//�ͷ�����ͷ
            if (uiComboBox1.Text == "����ͷ1" && videoDevices.Count > 0)
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            else if (uiComboBox1.Text == "����ͷ2" && videoDevices.Count > 1)
                videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            else
            {
                MessageBox.Show("ѡ�������ͷ�����ڣ�����");
                return;
            }
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

            Button1.Enabled = true;//������ʶ���ܡ�
        }

        // �رղ��ͷ�����ͷ
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
            //img = videoSourcePlayer1.GetCurrentVideoFrame();//����
            //pictureBox1.Image = img;
            //Button2.Enabled = true;//���������桱����
            // ���ش������¼�ʱ ��ʱ����
            //����������֤  ��֤��ɺ����ز��ر�����ͷ

            await Task.Delay(3000); //ģ����֤ʱ��
            MessageBox.Show("ʶ�����");
            this.Visible = false;
            ShutCamera();//�ͷ�����ͷ
            t.Start(); //ִ����Ϻ��ٿ�����

        }

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    //"����"��ťclick�¼�

        //        try
        //        {
        //            //�Ե�ǰʱ��Ϊ�ļ���������Ϊjpg��ʽ
        //            //ͼƬ·���ڳ���binĿ¼�µ�Debug��
        //           // TimeSpan tss = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        //            //long a = Convert.ToInt64(tss.TotalMilliseconds) / 1000;  //����Ϊ��λ
        //            //img.Save(string.Format("{0}.jpg", a.ToString()));
        //           // MessageBox.Show("����ɹ���");
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
            /// ������ִ�е�ί��
            /// </summary>
            public Action SessionUnlockAction { get; set; }

            /// <summary>
            /// ������ִ�е�ί��
            /// </summary>
            public Action SessionLockAction { get; set; }

            public SessionSwitchClass()
            {
                SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
            }

            //��������ֹ���й©
            ~SessionSwitchClass()
            {
                //Do this during application close to avoid handle leak
                SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
            }
            //public string UnlockOrLock = "δ����";///������Լ��Ĵ���
            //��ǰ��¼���û��仯����¼��ע���ͽ�������
            public void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
            {
                switch (e.Reason)
                {
                    //�û���¼
                    case SessionSwitchReason.SessionLogon:
                        BeginSessionUnlock();
                        break;
                    //������
                    case SessionSwitchReason.SessionUnlock:
                        BeginSessionUnlock();
                        break;
                    //����
                    case SessionSwitchReason.SessionLock:
                        BeginSessionLock();
                        break;
                    //ע��
                    case SessionSwitchReason.SessionLogoff:
                        break;
                }
            }

            /// <summary>
            /// ��������¼��ִ��
            /// </summary>
            private void BeginSessionUnlock()
            {
                //��������¼��ִ��
                form1.t.Stop(); //�ȹرն�ʱ��
                          // ������ʾ����
                form1.Visible = true;
                //====================================================
                form1.ShutCamera();//�ͷ�����ͷ
                if (form1.uiComboBox1.Text == "����ͷ1" && form1.videoDevices.Count > 0)
                    form1.videoSource = new VideoCaptureDevice(form1.videoDevices[0].MonikerString);
                else if (form1.uiComboBox1.Text == "����ͷ2" && form1.videoDevices.Count > 1)
                    form1.videoSource = new VideoCaptureDevice(form1.videoDevices[1].MonikerString);
                else
                {
                    MessageBox.Show("ѡ�������ͷ�����ڣ�����");
                    return;
                }
                form1.videoSourcePlayer1.VideoSource = form1.videoSource;
                form1.videoSourcePlayer1.Start();

                form1.Button1.Enabled = true;//���������㹦�ܡ�
            }

            /// <summary>
            /// ������ִ��
            /// </summary>
            private void BeginSessionLock()
            {
                //������ִ��
                form1.t.Stop(); //�ȹرն�ʱ��
            }
        }

    }
}
