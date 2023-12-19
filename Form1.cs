namespace ProductCart
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            CartPanel.BringToFront();
        }
    }
}
