using Newtonsoft.Json;
using System;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class friendRequest
    {
        [JsonProperty] User friend_request_to_me;
        [JsonProperty] User recived_by;
    }
}
 