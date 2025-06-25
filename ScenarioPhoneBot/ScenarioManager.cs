namespace ScenarioPhoneBot
{
    public class ScenarioManager
    {
        public string GetReply(string input)
        {
            input = input.ToLowerInvariant();
            if (input.Contains("咨询"))
            {
                return "您好，感谢您的咨询，我们会尽快为您安排客服";
            }
            else if (input.Contains("投诉"))
            {
                return "很抱歉让您不满意，我们会马上记录并处理";
            }
            return "对不起，我没有理解您的意思，请再说一遍";
        }
    }
}
