using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DABOAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the webhook URL from the textbox when the button is clicked
            string webhook = textBox1.Text;
            SendMs(webhook, textBox2.Text);
        }

        static void SendMs(string webhook, string message)
        {
            // Send the message using the provided webhook
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");
                string payload = "{\"content\": \"" + message + "\"}";
                client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // You can add any functionality here if needed.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can initialize any variables or controls here if needed.
        }
    }
}
