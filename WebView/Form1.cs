namespace WebView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://my.beu.edu.az/");
        }

        private void youtubeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kiçikEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com/");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com/");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.telegram.org/");
        }

        private void xəritəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com/maps");
        }

        private void telefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+994 77 555 22 21", "Telefon mömrəsi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }
    }
}
