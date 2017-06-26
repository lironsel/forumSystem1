using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Message
    {
        [JsonProperty] User sent_by;
        [JsonProperty] Group assembling;
        [JsonProperty] private string message;

        public void sendMessage(string content, string senderID, string groupID) { }
        public void createMessageTamplet(string userID) { }
    }
}
