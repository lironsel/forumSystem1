using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Admin : User
    {
        [JsonProperty] string forumAdmined;

        public Admin(string name, string password) : base(name, password) {}
        public Admin(string name, string password, string forum) : base(name, password) { forumAdmined = forum; }
    }
}
