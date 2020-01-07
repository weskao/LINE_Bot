using isRock.LineBot;
using System;
using System.Collections.Generic;

namespace LINE_Bot
{
    public class MyLineBot
    {
        private readonly string _adminUserId;
        private readonly string _receiveMsgUserId;
        private static string _token;
        private static Bot Bot { get; set; }

        public MyLineBot()
        {
            _token = "ufFSRRG5kRRWF7cWQfIXj5dbVHda0mwH8x5vS1OSHxWfCfqXNwvHMqfgXUFyR4Bjt8ACWpSoJwqyj+y0QAy/YB4mrF9+exiJO3YRlCewXgdk6L65H2YgBvNpHPH1ZRqkw7rmqdis2Bh6SEbWaF7X8wdB04t89/1O/w1cDnyilFU=";
            _adminUserId = "U89e2dae55874fe65fd11d313b89f0a00";
            _receiveMsgUserId = _adminUserId;
            Bot = new Bot(_token);
        }

        public void PushMessage(string message)
        {
            Bot.PushMessage(_receiveMsgUserId, message);
        }

        public void PushMessage(int packageId, int stickerId)
        {
            Bot.PushMessage(_receiveMsgUserId, 1, 2);
        }

        public void PushMessage(Uri imgUri)
        {
            Bot.PushMessage(_receiveMsgUserId, imgUri);
        }

        public void PushMessage(ButtonsTemplate buttonsTemplate)
        {
            Bot.PushMessage(_receiveMsgUserId, buttonsTemplate);
        }

        public ButtonsTemplate CreateSampleButtonTemplate()
        {
            return new ButtonsTemplate
            {
                thumbnailImageUrl = new Uri("https://cff2.earth.com/uploads/2019/09/03150152/Fast-fashion-has-an-enormous-carbon-footprint-730x410.jpg"),
                text = "請問你想買哪一類的服飾?",
                title = "Question",
                actions = CreateSampleActions(),
                //                altText = "您目前的裝置不支援TemplateMessage，想看😙? 無法顯示啦~🤗"
            };
        }

        public List<TemplateActionBase> CreateSampleActions()
        {
            return new List<TemplateActionBase>()
            {
                new MessageAction {label = "男裝", text = "man"},
                new MessageAction {label = "女裝", text = "woman"},
                new MessageAction {label = "童裝", text = "children"},
            };
        }
    }
}