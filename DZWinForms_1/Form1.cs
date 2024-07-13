namespace DZWinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Mi_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Click_Mi.Left = r.Next(0, this.ClientSize.Width - Click_Mi.Width);
            Click_Mi.Top = r.Next(0, this.ClientSize.Height - Click_Mi.Height);

        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            string path = "MyText.txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(InfoText.Text);
            }

        }

        private void MyopenMenuItem_Click(object sender, EventArgs e)
        {
            string path = "MyText.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    InfoText.Text += reader.ReadLine()+Environment.NewLine;
                }
                reader.Close();
            }

        }
    }
}
