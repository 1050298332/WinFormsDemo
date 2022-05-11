using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form2 : UIForm
    {
        public Form2()
        {
            InitializeComponent();
            //最大化窗体
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //全屏窗体时内容不受任务栏影响
            
            //this.FormBorderStyle = FormBorderStyle.None;
        }

    }
}
