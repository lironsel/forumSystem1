using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class ErrorLogger : Logger
    {
        string forumName;
        
        public ErrorLogger(string name) : base(name + "_Error.txt")
        {
            forumName = name;
        }
    }
}
