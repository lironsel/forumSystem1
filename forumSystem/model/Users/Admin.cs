using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Admin : User
    {
        public Admin(string name, string password) : base(name, password) {}
    }
}
