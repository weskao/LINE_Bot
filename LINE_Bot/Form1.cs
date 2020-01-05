using System;
using System.Windows.Forms;

namespace LINE_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Send_Message_Click(object sender, EventArgs e)
        {
            var lineBot = new LineBot();
            lineBot.PushMessage("Hello handsome man!");
        }
    }
}