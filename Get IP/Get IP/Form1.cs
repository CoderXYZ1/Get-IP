using System;
using System.Net;
using System.Windows.Forms;

namespace Mac_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("https://www.myexternalip.com/raw");
                textBox1.Text = htmlCode;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
