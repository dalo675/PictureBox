namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}