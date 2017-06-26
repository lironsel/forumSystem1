using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class ActionLogger : Logger
    {
        [JsonProperty]
        string forumName;

        public ActionLogger(string name) : base(name + "_Action.txt")
        {
            forumName = name;
        }
    }
}
