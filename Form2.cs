using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            btn1.Left = r.Next(0, this.ClientSize.Width - btn1.Width);
            btn1.Top = r.Next(0, this.ClientSize.Height - btn1.Height);
        }
    }
}
