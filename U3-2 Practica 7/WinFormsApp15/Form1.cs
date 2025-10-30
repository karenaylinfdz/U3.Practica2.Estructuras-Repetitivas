namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoInferior, rangoSuperior, suma = 0;

            rangoInferior = int.Parse(textBox1.Text);
            rangoSuperior = int.Parse(textBox2.Text);

            for (int i = rangoInferior; i <= rangoSuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }

            textBox3.Text = suma.ToString();
        }
    }
}
