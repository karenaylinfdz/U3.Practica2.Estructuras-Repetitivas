using System;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Bot�n SumarNumeros
            textBox2.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bot�n A�adir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el par�metro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
