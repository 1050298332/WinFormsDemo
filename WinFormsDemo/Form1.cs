namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //��󻯴���
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //ȫ������ʱ���ݲ���������Ӱ��
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }
    }
}