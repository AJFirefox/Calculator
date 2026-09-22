namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "0";

        }

        private void One_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "9";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "+";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "/";
        }



    }
}
