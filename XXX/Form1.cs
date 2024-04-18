using System.Runtime.CompilerServices;

namespace XXX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double res1;
        double res2;
        double napr;
        double result;
        double resist;



        private void button1_Click(object sender, EventArgs e)
        {
            double resist = 1/(1/res1 + 1/res2);
            double result = napr / resist;
            MessageBox.Show(Convert.ToString(result));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            res1 = double.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            res2 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            napr = double.Parse(textBox3.Text);
        }
    }
}
