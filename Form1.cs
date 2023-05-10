namespace CartRentalService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CarSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserChoosenCarText.Text = "You have picked" + " " + CarSelectBox.Text + " " + " for rent";
            UserChoosenCarText.Visible = true;

            if (CarSelectBox.Text == "Tesla")
            {
                DateTime now = DateTime.Now;
                StatusText.Text = "you will be charged with  $1200" + " " + now.ToString("F");
                StatusText.Visible = true;
            }
            else if (CarSelectBox.Text == "BenZ Z5")
            {

                DateTime now = DateTime.Now;
                DateText.Text = now.ToString(("F"));
                StatusText.Text = "you will be charged with  $500" + " " + now.ToString("F");
                StatusText.Visible = true;
            }
            else if (CarSelectBox.Text == "Toyota")
            {

                DateTime now = DateTime.Now;
                DateText.Text = now.ToString(("F"));
                StatusText.Text = "you will be charged with  $300" + " " + now.ToString("F");
                StatusText.Visible = true;
            }
            else if (CarSelectBox.Text == "Mercedes")
            {

                DateTime now = DateTime.Now;
                DateText.Text = now.ToString(("F"));
                StatusText.Text = "you will be charged with  $800" + " " + now.ToString("F");
                StatusText.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void StatusText_Click(object sender, EventArgs e)
        {

        }
    }
}