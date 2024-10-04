using System.Data;


namespace math4
{
    public partial class Form1 : Form
    {
        bool operation_pressed = false;
        bool dot_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0"))
                textBox1.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void all_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!operation_pressed)
            {
                textBox1.Text = textBox1.Text + b.Text;
                operation_pressed = true;
                dot_pressed = false;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!dot_pressed)
            {
                textBox1.Text = textBox1.Text + ',';
                dot_pressed = true;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {

            var res = operation_Result();
            textBox2.Text = res;

        }

        public string operation_Result()
        {
            DataTable dt = new DataTable();
            return dt.Compute(textBox1.Text.Replace(',','.'), "").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
