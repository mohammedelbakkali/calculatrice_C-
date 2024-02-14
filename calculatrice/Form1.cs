namespace calculatrice
{
    public partial class Form1 : Form

    {
        double a, b, c;
        string opt;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void add(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            opt = "add";
        }

        private void calc(object sender, EventArgs e)
        {
            b = Double.Parse(textBox1.Text);
            switch (opt)
            {
                case "add":
                    b += a;
                    textBox1.Text = "" + b;
                    break;
                case "soust":
                    a -= b;
                    textBox1.Text = "" + a;
                    break;
                case "div":
                    a /= b;
                    textBox1.Text = "" + a;
                    break;
                case "mult":
                    a *= b;
                    textBox1.Text = "" + a;
                    break;

            }
        }

        private void soustraction(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            opt = "soust";
        }

        private void mult(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            opt = "mult";
        }

        private void div(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            opt = "div";
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
