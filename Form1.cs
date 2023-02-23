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
        //si clico el botó 1 la imatge és visible
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= true;
        }
        //si clico el botó 2 la imatge és invisible
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
