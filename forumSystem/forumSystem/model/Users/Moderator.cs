using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Moderator : User
    {
        [JsonProperty] List<string> monitoring;
        [JsonProperty] List<Complaint> complaints;
        [JsonProperty] private double seniority;

        public Moderator(string name, string password) : base(name, password)
        { complaints = new List<Complaint>(); }
        public void getModerator() { }
        public void searchModeator(string moderatorID) { }
    }
}
