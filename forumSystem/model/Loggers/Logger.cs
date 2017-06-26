using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [JsonObject]
    class Logger
    {
        [JsonProperty] private string log;
        [JsonProperty] private string path;

        public Logger(string path)
        {
            this.path = path;
            log = "";
        }

        public void Log(string data)
        {
            log += ("[" + DateTime.Now + "] " + data + "\n");
        }
    }
}
