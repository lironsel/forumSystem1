using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Title
    {
        [JsonProperty] ThreadMessage assembling;
        [JsonProperty] private string title;
        public void putTitle() { }
    }
}
