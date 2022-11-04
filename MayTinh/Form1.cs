namespace MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtA.Text != String.Empty)
=======
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
>>>>>>> feature-cal
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKQ.Text = c.ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a=double.Parse(txtA.Text);
            double b=double.Parse(txtB.Text);
            double c = a - b;
            txtKQ.Text=c.ToString();
        }
    }
}