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
            var token = "ufFSRRG5kRRWF7cWQfIXj5dbVHda0mwH8x5vS1OSHxWfCfqXNwvHMqfgXUFyR4Bjt8ACWpSoJwqyj+y0QAy/YB4mrF9+exiJO3YRlCewXgdk6L65H2YgBvNpHPH1ZRqkw7rmqdis2Bh6SEbWaF7X8wdB04t89/1O/w1cDnyilFU=";
            var adminUserId = "U89e2dae55874fe65fd11d313b89f0a00";
            var lineBot = new isRock.LineBot.Bot(token);

            lineBot.PushMessage(adminUserId, "Hello handsome man!");
        }
    }
}