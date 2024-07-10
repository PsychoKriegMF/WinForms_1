namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Text += "Выбрано оба варианта" + Environment.NewLine;
            }
            else if (checkBox1.Checked)
            {
                textBox1.Text += (button1).Text + Environment.NewLine;
            }
            else if (checkBox2.Checked)
            {
                textBox1.Text += (button1).Name + Environment.NewLine;
            }
            else
            {
                textBox1.Text += "Не выбрано ничего" + Environment.NewLine;
            }
            if ((button1).Text == "Нажми!")
            {
                (button1).Text = "Нажали";
            }
            else
            {
                (button1).Text = "Нажми!";
            }
            if (radioButton3.Checked)
            {
                textBox1.Text += "))))" + Environment.NewLine;
            }

        }
        private void TextChange2(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (вариант1ToolStripMenuItem.Enabled)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        string filename;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            textBox1.Text += filename + Environment.NewLine;
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                textBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
        }
    }
}
