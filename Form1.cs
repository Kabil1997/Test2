namespace Mr.Saleh_Alyazidy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 10;
        }
    }
}