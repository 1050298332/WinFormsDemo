namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //最大化窗体
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //全屏窗体时内容不受任务栏影响
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }
    }
}