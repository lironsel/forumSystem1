using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Complaint
    {
        [JsonProperty] string refers_to;
        [JsonProperty] string submitted_by;
        [JsonProperty] string complaint;

        public Complaint (string complaint, string filedBy, string filedOn)
        {
            this.complaint = complaint;
            this.submitted_by = filedBy;
            this.refers_to = filedOn;
        }
    }
}
