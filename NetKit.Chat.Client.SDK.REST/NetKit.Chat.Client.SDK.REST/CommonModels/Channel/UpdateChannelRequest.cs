// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace NetKit.Chat.Client.SDK.REST.CommonModels.Channel
{
    public class UpdateChannelRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string WelcomeMessage { get; set; }

        public string PhotoUrl { get; set; }
    }
}
