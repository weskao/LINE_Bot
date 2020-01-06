using System;
using System.IO;
using System.Windows.Forms;

namespace LINE_Bot
{
    public partial class LineBotForm : Form
    {
        private LineBot _lineBot;

        public LineBotForm()
        {
            InitializeComponent();
            CreateBot();
        }

        private void Btn_Send_Text_Click(object sender, EventArgs e)
        {
            _lineBot.PushMessage("Hello handsome man!");
            _lineBot.PushMessage("Good~");
        }

        private void Btn_Send_Emoticon_Click(object sender, EventArgs e)
        {
            _lineBot.PushMessage(1, 2);
        }

        private void Btn_Send_Image_Click(object sender, EventArgs e)
        {
            string imgUrl = TextBox_Image_Url.Text;
            var imgUri = new Uri(imgUrl);

            _lineBot.PushMessage(imgUri);
        }

        private void CreateBot()
        {
            _lineBot = new LineBot();
        }
    }
}