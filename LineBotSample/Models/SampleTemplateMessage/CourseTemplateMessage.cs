using System.Collections.Generic;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message;
using LineMessagingAPI.Models.Message.Template;

namespace LineBotSample.Models.SampleTemplateMessage
{
    public class CourseTemplateMessage
    {
        public TemplateMessageModel Create()
        {
            TemplateMessageModel templateMessageModel = new TemplateMessageModel()
            {
                altText = "課程分類"
            };

            ButtonsTemplateModel buttonsTamplateModel = new ButtonsTemplateModel()
            {
                text = "請選擇以下分類"
            };
            List<ActionModel> buttonsTamplateModelActionList = new List<ActionModel>();

            MessageActionModel newestCourseMessageAction = new MessageActionModel()
            {
                label = "最新課程",
                text = "最新課程"
            };
            buttonsTamplateModelActionList.Add(newestCourseMessageAction);

            MessageActionModel promotionCourseMessageAction = new MessageActionModel()
            {
                label = "優惠課程",
                text = "優惠課程"
            };
            buttonsTamplateModelActionList.Add(promotionCourseMessageAction);

            MessageActionModel hottestCourseMessageAction = new MessageActionModel()
            {
                label = "熱門課程",
                text = "熱門課程"
            };
            buttonsTamplateModelActionList.Add(hottestCourseMessageAction);

            buttonsTamplateModel.actions = buttonsTamplateModelActionList;
            templateMessageModel.template = buttonsTamplateModel;

            return templateMessageModel;
        }
    }
}