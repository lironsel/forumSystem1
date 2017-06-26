using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Notification
    {
        [JsonProperty] DateTime _date;
        [JsonProperty] string _data;

        public Notification(string data)
        {
            _date = DateTime.Now;
            _data = data;
        }
    }
}
