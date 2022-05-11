using Sunny.UI;
using AForge.Video.DirectShow;

namespace WinFormsDemo
{
    public partial class Form1 : UIForm
    {
        FilterInfoCollection videoDevices;//����ͷ�豸����
        VideoCaptureDevice videoSource;//�����豸Դ
        //Bitmap img;//����ͼƬ

        public Form1()
        {

            InitializeComponent();
            //��󻯴���
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        //˫������ͼ���¼�
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ������ʾ����
            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;
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

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webView2.Source =  new Uri("http://mccsdl.top/login");
        }

        private void ��ʱ�뿪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��ʱ�뿪����ͣ��ʱɨ��ʶ��
            //��form����ҳ��
            Form2 f2 = new Form2();
            f2.Show();
            //webView2.Source = new Uri("http://mccsdl.top");
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

            Button1.Enabled = true;//���������㹦�ܡ�
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

        private void Button1_Click(object sender, EventArgs e)
        {
                //img = videoSourcePlayer1.GetCurrentVideoFrame();//����
                //pictureBox1.Image = img;
                //Button2.Enabled = true;//���������桱����
            

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
    }
}
