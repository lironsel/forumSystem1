using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Admin : User
    {
        [JsonProperty]
        List<string> forumsAdmined;
        public Admin(string name, string password) : base(name, password) { }
    }
}
