using isRock.LineBot;
using System;

namespace LINE_Bot
{
    public class LineBot
    {
        private readonly string _adminUserId;
        private static string _token;
        private static Bot Bot { get; set; }

        public LineBot()
        {
            _token = "ufFSRRG5kRRWF7cWQfIXj5dbVHda0mwH8x5vS1OSHxWfCfqXNwvHMqfgXUFyR4Bjt8ACWpSoJwqyj+y0QAy/YB4mrF9+exiJO3YRlCewXgdk6L65H2YgBvNpHPH1ZRqkw7rmqdis2Bh6SEbWaF7X8wdB04t89/1O/w1cDnyilFU=";
            _adminUserId = "U89e2dae55874fe65fd11d313b89f0a00";
            Bot = new Bot(_token);
        }

        public void PushMessage(string message)
        {
            Bot.PushMessage(_adminUserId, message);
        }

        public void PushMessage(int packageId, int stickerId)
        {
            Bot.PushMessage(_adminUserId, 1, 2);
        }

        public void PushMessage(Uri imgUri)
        {
            Bot.PushMessage(_adminUserId, imgUri);
        }
    }
}