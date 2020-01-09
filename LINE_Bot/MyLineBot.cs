using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINE_Bot
{
    public class MyLineBot
    {
        private readonly string _receiveMsgUserId;
        public static int ColumnCumulativeNumber { get; private set; } = 0;
        public static int ImageColumnCumulativeNumber { get; private set; } = 0;
        public static List<TemplateActionBase> SampleTemplateActions => null;
        private const string ImageUrl = "https://cff2.earth.com/uploads/2019/09/03150152/Fast-fashion-has-an-enormous-carbon-footprint-730x410.jpg";
        private static Bot Bot { get; set; }
        private ITemplateManagerFactory _templateManager;

        public MyLineBot()
        {
            var token = "ufFSRRG5kRRWF7cWQfIXj5dbVHda0mwH8x5vS1OSHxWfCfqXNwvHMqfgXUFyR4Bjt8ACWpSoJwqyj+y0QAy/YB4mrF9+exiJO3YRlCewXgdk6L65H2YgBvNpHPH1ZRqkw7rmqdis2Bh6SEbWaF7X8wdB04t89/1O/w1cDnyilFU=";
            var adminUserId = "U89e2dae55874fe65fd11d313b89f0a00";
            _receiveMsgUserId = adminUserId;
            Bot = new Bot(token);
            _templateManager = TemplateManagerFactory.Create();
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

        private ButtonsTemplate CreateSampleButtonsTemplate()
        {
            return new ButtonsTemplate
            {
                thumbnailImageUrl = new Uri(ImageUrl),
                text = "請問你想買哪一類的服飾?",
                title = "Question",
                actions = CreateSampleTemplateActions().GetRange(0, 3),
                //                altText = "您目前的裝置不支援TemplateMessage，想看😙? 無法顯示啦~🤗"
            };
        }

        private List<TemplateActionBase> CreateSampleTemplateActions()
        {
            return SampleTemplateActions ?? new List<TemplateActionBase>
            {
                new MessageAction {label = "男裝", text = "man"},
                new MessageAction {label = "女裝", text = "woman"},
                new MessageAction {label = "童裝", text = "children"},
                new MessageAction() {label = "標題-文字回覆", text = "回覆文字"},
                new UriAction() {label = "標題-Google", uri = new Uri("http://www.google.com")},
                new PostbackAction()
                    {label = "標題-發生 post back", data = "abc=aaa&def=111", displayText = "Occurred post back"}
            };
        }

        private ConfirmTemplate CreateSampleConfirmTemplate()
        {
            return new ConfirmTemplate()
            {
                text = "請問你想選擇的是...?",
                actions = CreateSampleConfirmActions(),
                altText = "您目前的裝置不支援 ConfirmTemplate，想看😙? 無法顯示啦~🤗"
            };
        }

        private TemplateMessageBase CreateSampleCarouselTemplate()
        {
            return new CarouselTemplate()
            {
                columns = new List<Column>()
                {
                    CreateSampleColumn(),
                    CreateSampleColumn(),
                    CreateSampleColumn()
                }
            };
        }

        private TemplateMessageBase CreateSampleImageCarouselTemplate()
        {
            return new ImageCarouselTemplate()
            {
                columns = new List<ImageCarouselColumn>()
                {
                    CreateSampleImageColumn(),
                    new ImageCarouselColumn()
                    {
                        imageUrl = new Uri(ImageUrl),
                        action = new DateTimePickerAction()
                        {
                            label = "Select time",
                            mode = "time"
                        }
                    }
                }
            };
        }

        private ImageCarouselColumn CreateSampleImageColumn()
        {
            ImageColumnCumulativeNumber++;
            return new ImageCarouselColumn()
            {
                imageUrl = new Uri(ImageUrl),
                action = new MessageAction() { label = $"label {ImageColumnCumulativeNumber}", text = "Message~" }
            };
        }

        private Column CreateSampleColumn()
        {
            ColumnCumulativeNumber++;
            return new Column()
            {
                text = $"ButtonsTemplate 文字訊息{ColumnCumulativeNumber}",
                title = $"ButtonsTemplate 標題{ColumnCumulativeNumber}",
                thumbnailImageUrl = new Uri(ImageUrl),
                actions = CreateSampleTemplateActions().GetRange(3, 3)
            };
        }

        private List<TemplateActionBase> CreateSampleConfirmActions()
        {
            var confirmActions = CreateSampleTemplateActions();
            var countConfirmActionMustHave = 2;
            confirmActions.RemoveRange(countConfirmActionMustHave, confirmActions.Count - countConfirmActionMustHave);

            return confirmActions;
        }

        public void PushMessage(CarouselTemplate carouselTemplate)
        {
            Bot.PushMessage(_receiveMsgUserId, carouselTemplate);
        }

        public void PushMessage(ConfirmTemplate confirmTemplate)
        {
            Bot.PushMessage(_receiveMsgUserId, confirmTemplate);
        }

        public void PushMessage(ImageCarouselTemplate imageCarouselTemplate)
        {
            Bot.PushMessage(_receiveMsgUserId, imageCarouselTemplate);
        }

        public TemplateMessageBase CreateSampleTemplate(TemplateType templateType)
        {
            var templateMessages = new Dictionary<TemplateType, TemplateMessageBase>()
            {
                {TemplateType.ButtonsTemplate, CreateSampleButtonsTemplate()},
                {TemplateType.ConfirmTemplate, CreateSampleConfirmTemplate()},
                {TemplateType.CarouselTemplate, CreateSampleCarouselTemplate() },
                {TemplateType.ImageCarouselTemplate, CreateSampleImageCarouselTemplate() }
            };

            return templateMessages[templateType];
        }
    }

    public class TemplateManagerFactory
    {
        private static ITemplateManagerFactory _customerManager;

        public static ITemplateManagerFactory Create()
        {
            if (_customerManager != null)
            {
                return _customerManager;
            }

            return new SampleTemplateActionManager();
        }
    }

    public class SampleTemplateActionManager : ITemplateManagerFactory
    {
        private List<TemplateActionBase> _templateActionBases;

        public SampleTemplateActionManager()
        {
            _templateActionBases = SampleActionFactory.Create();
        }
    }

    public class SampleActionFactory
    {
        private static List<TemplateActionBase> _templateActionBases;

        public static List<TemplateActionBase> Create()
        {
            if (_templateActionBases != null)
            {
                return _templateActionBases;
            }

            return new List<TemplateActionBase>
            {
                new MessageAction {label = "男裝", text = "man"},
                new MessageAction {label = "女裝", text = "woman"},
                new MessageAction {label = "童裝", text = "children"},
                new MessageAction() {label = "標題-文字回覆", text = "回覆文字"},
                new UriAction() {label = "標題-Google", uri = new Uri("http://www.google.com")},
                new PostbackAction()
                    {label = "標題-發生 post back", data = "abc=aaa&def=111", displayText = "Occurred post back"}
            };
        }
    }
}