using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Content
    {
        ThreadMessage assembling;
        [JsonProperty] private string content;

        public void putContent(string content)
        {
            this.content = content;
        }
    }
}
