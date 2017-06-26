using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class invitation
    {
        [JsonProperty] User received_by;
        [JsonProperty] User sent_by;
        [JsonProperty] Group invites_to;


        public void inviate_addFrind(string userInviteID, string userInvitedID) { }
        public void creatInvitation() { }
    }
}
